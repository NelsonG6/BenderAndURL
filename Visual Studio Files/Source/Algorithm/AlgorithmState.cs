using System;
using System.Collections.Generic;
using System.Linq;

namespace ReinforcementLearning
{
    class AlgorithmState
    {
        //Static members
        
        //Commenting this so i can just use a function that points to the most recent state
        //static public AlgorithmState current_state; //This is a pointer to the most recently generated state

        static public List<AlgorithmEpisode> stateHistory; //This is the history of the entire run, and all the configurations and q-matrix instances.
                                                            //The head of this list is the current progress point of our algorithm.

        static public bool algorithmStarted; //Used for the status message
        static public bool algorithmEnded;

        public bool benderAttacked;

        //Non-static members
        public BoardGame boardData; //Stores the state of the cans and walls (bender is stored with other coordinates)

        private StatusMessage statusMessage; //Used for debugging
        public Qmatrix liveQmatrix; //Moves will be generated from here.

        public Dictionary<UnitType, PerceptionState> startingPerceptions;

        public double episodeRewards; //Session - Reward data
        public double totalRewards;

        public SquareBoardBase locationInitial; //Just used for the status message

        public Dictionary<UnitType, Move> movesThisStep;

        public MoveResult resultThisStep; //Moveresult stored for status

        public double obtainedReward; //The raw reward for the action we took

        public int cansCollected;

        //This should be called at the program launch, and when the reset config button is pressed
        public static void SetDefaultConfiguration()
        {
            stateHistory = new List<AlgorithmEpisode>(); //initialize history
            stateHistory.Add(new AlgorithmEpisode(1)); //Create the first episode. The current state is retieved from the most recent point. 


            algorithmEnded = false;
            algorithmStarted = false;           
        }

        public static AlgorithmState GetCurrentState()
        {
            int episode_index = stateHistory.Count - 1;
            if (episode_index == -1)
            {
                return null; //No episodes created
            }
            else
            {
                int step_index = stateHistory[episode_index].Count() - 1;
                if (step_index == -1)
                    return null; //Step index shouldn't be 0, because we shouldn't call this at a time when we created a new episode but didn't put a state there.
                else
                    return stateHistory[episode_index][step_index];
            }
        }

        //Called at algorithm start, and on reset
        public static void StartAlgorithm()
        {
            algorithmStarted = true;
            AddToHistory(FormsHandler.loaded_state); //Copy our state from forms handler
            GetCurrentState().StartNewEpisode();
        }

        //Manages the state history, and making sure the correct state is being created/stored
        public static void StepPrepare() //Go to the most current state, and step forward once. 
        {   //If the algorithm hasn't started, this will just start the algorithm and leave us at step 0.

            //use start new episode if this is the first step
            //step and add, or dont step and dont add
            AlgorithmState step_with = new AlgorithmState(GetCurrentState());

            //After the copy consctructor above, the state will have the correct episode number.
            //We may need to add a new episode.


            if (step_with.GetEpisodeNumber() > stateHistory.Count)
            {
                stateHistory.Add(new AlgorithmEpisode(stateHistory.Count + 1)); //Add the first empty episode
            }
            else
            {


                step_with.Step();
            }

            stateHistory.Last().Add(step_with); //Add the state to the history list, after everything possible has been done to it.    
            step_with.GenerateStatusMessage();



        }


        //At the algorithm manager level, "generate step" is ambiguous with actually stepping through the algorithm,
        //Or starting the algorithm, and making the first history entry at step 0.
        //Here, a step only happens when we have been asked by the manager to *actually* take a step.
        public void Step()
        {
            boardData.UnitPercieves(UnitType.Bender);
            //Url senses twice. If bender moves into him, he wont start chasing until next turn.
            boardData.UnitPercieves(UnitType.Url);

            Move best_move = null;
            //If prior to bender moving, URL could not see bender, he will not attack this turn.
            foreach (var i in boardData.units[UnitType.Url].perceptionData.perception_data)
            {
                if (i.Value == Percept.Enemy)
                {
                    best_move = i.Key;
                }
            }
            if (best_move == null)
                boardData.units[UnitType.Url].chasing = false;


            //Bender section.
            movesThisStep[UnitType.Bender] = liveQmatrix.GenerateStep(startingPerceptions[UnitType.Bender]);
            resultThisStep = boardData.ApplyMove(UnitType.Bender, movesThisStep[UnitType.Bender]); //The move should be performed now, if possible.
            obtainedReward = MoveResult.list[resultThisStep]; //Get the reward for this action

            episodeRewards += obtainedReward; //Update the rewards total

            if (resultThisStep == MoveResult.CanCollected)
                ++cansCollected;

            //give the value to the q matrix to digest

            if (GetStepNumber() == Qmatrix.step_limit && GetEpisodeNumber() > Qmatrix.episode_limit)
                algorithmEnded = true;            

            //url 
            boardData.UnitPercieves(UnitType.Url);
            
            List<Move> best_moves = new List<Move>();

            if (boardData.units[UnitType.Url].chasing == true && MyRandom.Next(0, 5) == 0)
                boardData.units[UnitType.Url].chasing = false; //stop chasing randomly
            if (boardData.units[UnitType.Url].chasing == true)
            {   //Greedy selection
                foreach (var i in boardData.units[UnitType.Url].perceptionData.perception_data)
                {
                    if (i.Value == Percept.Enemy)
                    {
                        best_move = i.Key;
                    }
                }
            }
            else //Take a random move that isn't into a wall or a diagonal
            {
                foreach (var i in boardData.units[UnitType.Url].perceptionData.perception_data)
                {
                    if (i.Value != Percept.Wall && !(Move.Diagonals.Contains(i.Key)))
                        best_moves.Add(i.Key);

                    if (i.Value == Percept.Enemy)
                        boardData.units[UnitType.Url].chasing = true;
                    //When we first start chasing, we pause one time. Otherwise bender would run into us and never learn.
                }
                if (boardData.units[UnitType.Url].chasing == true)
                    best_move = Move.Wait; //Wait if we just started chasing
                else
                    best_move = best_moves[MyRandom.Next(0, best_moves.Count)];
            }

            //detect if bender was attacked
            //See if the move url selected perceives an enemy to do this
            if(best_move != Move.Wait && boardData.units[UnitType.Url].perceptionData.perception_data[best_move] == Percept.Enemy)
            {   //Url attacks bender. don't move him just so its visually easier to see.
                obtainedReward = MoveResult.list[MoveResult.EnemyEncountered];
                benderAttacked = true;
                resultThisStep = MoveResult.EnemyEncountered;
            }

            liveQmatrix.UpdateState(startingPerceptions[UnitType.Bender], GetPerception(UnitType.Bender), movesThisStep[UnitType.Bender], obtainedReward);

            //Move url, maybe into bender
            boardData.ApplyMove(UnitType.Url, best_move);
            movesThisStep[UnitType.Url] = best_move;

            //Make each unit perceieve after their step
            
        }

        //Gets the qmatrix view for the give move at bender's current position
        static public string GetQmatrixView(Move move_to_get)
        {
            ValueSet to_get = GetCurrentQmatrix().matrix_data[GetCurrentState().boardData.units[UnitType.Bender].get_perception_state()];
            return to_get.moveList[move_to_get].ToString();
        }

        public void EraseBoardForReset()
        {   //Used ONLY with the restart algorithm button. Keeps a few old things, like bender's position and settings
            algorithmStarted = false; //Algorithm no longer running
            InitializeValues();
            stateHistory = new List<AlgorithmEpisode>();
            stateHistory.Add(new AlgorithmEpisode(1));
            FormsHandler.ResetConfiguration();
        }

        //Non-static functions
        //Default config algorithm state
        //This is called when the program is launched.
        public AlgorithmState()
        {
            boardData = new BoardGame(); //Produces a shuffled bender and can-filled board 

            

            InitializeValues(); //Gives us some empty defaults
        }

        //Called from create_empty_board (after reset), and the constructor
        //Just a useful container for resetting some values when we want to start over, but making a new state would have us lose bender's position.
        private void InitializeValues()
        {
            boardData.ClearCans(); //Clear the board for our initial launch(this doesn't remove bender, just cans)
            liveQmatrix = new Qmatrix();
            startingPerceptions = new Dictionary<UnitType, PerceptionState>();
            movesThisStep = new Dictionary<UnitType, Move>(); //Stores a list of moves for each unit

            foreach (var i in UnitType.BaseUnits)
            {   //Initialize the perception lists
                startingPerceptions.Add(i, null);
                movesThisStep.Add(i, null);
            }
        }

        //Copied from another algorithm state
        //We reset some data, so we dont reflect values that aren't true for the new state
        //This constructor is called when a new step is being generated, so we transfer some values appropriately.
        public AlgorithmState(AlgorithmState set_from)
        {
            cansCollected = set_from.cansCollected;

            episodeRewards = set_from.episodeRewards; //Reward data
            totalRewards = set_from.totalRewards;

            boardData = new BoardGame(set_from.boardData); //Copy the board

            //Increase steps in here
            liveQmatrix = new Qmatrix(set_from.liveQmatrix); //Copy the q matrix
            
            //The initial location will be the resulting location of the last step
            locationInitial = boardData.GetUnitSquare[UnitType.Bender];

            startingPerceptions = new Dictionary<UnitType, PerceptionState>();
            startingPerceptions[UnitType.Bender] = set_from.GetPerception(UnitType.Bender);

            movesThisStep = new Dictionary<UnitType, Move>();

            //Detect if we reached the limit for this episode


            if (liveQmatrix.step_number == Qmatrix.step_limit || boardData.BenderAttacked())
                if (liveQmatrix.episode_number == Qmatrix.episode_limit)
                    algorithmEnded = true;
                else
                {
                    StartNewEpisode();
                }
            else
                liveQmatrix.step_number++;

        }

        public Percept GetBenderPercept(Move direction_to_check)
        {
            return boardData.units[UnitType.Bender].get_percept(direction_to_check);
        }

        //Used to erase session-based progress.
        //This is also called each new episode once we reach the max steps
        //Not called when the program launches
        public void StartNewEpisode()
        {
            

            cansCollected = 0;
            episodeRewards = 0; //Session - Reward data

            boardData.ShuffleCansAndUnits(); //Shuffle the the current board.

            //Each unit perceives 
            foreach(var i in boardData.units.Keys)
            {
                boardData.UnitPercieves(i);
            }

            liveQmatrix.ProcessNewEpisode();
        }


        override public string ToString()
        {
            return "[Episode: " + GetEpisodeNumber().ToString() + "][Step: " + GetStepNumber() + "]";
        }

        public static Qmatrix GetCurrentQmatrix()
        {
            return GetCurrentState().liveQmatrix;
        }

        public static BoardGame GetCurrentBoard()
        {
            return GetCurrentState().boardData;
        }

        //Add a state
        public static void AddToHistory(AlgorithmState to_add)
        {
            stateHistory.Last().Add(to_add);
        }
        
        public int GetEpisodeLimit()
        {
            return Qmatrix.episode_limit;
        }

        public int GetStepLimit()
        {
            return Qmatrix.step_limit;
        }

        public int GetEpisodeNumber()
        {
            return liveQmatrix.episode_number;
        }

        public int GetStepNumber()
        {
            return liveQmatrix.step_number;
        }

        private void GenerateStatusMessage()
        {
            statusMessage = new StatusMessage(this);
        }

        public string GetStatus()
        {
            if(statusMessage == null)
            {
                StatusMessage status = new StatusMessage(this);
                return status.GetMessage();
                
            }
            return statusMessage.GetMessage();
        }

        private void UnitPerceives(UnitType toSee)
        {
            boardData.UnitPercieves(toSee);
        }

        private PerceptionState GetPerception(UnitType toSee)
        {
            return boardData.units[toSee].perceptionData;
        }
    } 
}
