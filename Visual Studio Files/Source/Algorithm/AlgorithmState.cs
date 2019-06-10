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

        static public List<AlgorithmEpisode> state_history; //This is the history of the entire run, and all the configurations and q-matrix instances.
                                                            //The head of this list is the current progress point of our algorithm.

        static public bool algorithm_started; //Used for the status message
        static public bool algorithm_ended;

        public bool bender_attacked;

        //Non-static members
        public BoardGame board_data; //Stores the state of the cans and walls (bender is stored with other coordinates)

        private StatusMessage status_message; //Used for debugging
        public Qmatrix live_qmatrix; //Moves will be generated from here.

        public PerceptionState bender_perception_starting;
        public PerceptionState bender_perception_ending;

        public double episode_rewards; //Session - Reward data
        public double total_rewards;

        public SquareBoardBase location_initial; //Just used for the status message

        public Dictionary<UnitType, Move> moves_this_step;

        public MoveResult result_this_step; //Moveresult stored for status

        public double obtained_reward; //The raw reward for the action we took

        public int cans_collected;

        //This should be called at the program launch, and when the reset config button is pressed
        public static void SetDefaultConfiguration()
        {
            state_history = new List<AlgorithmEpisode>(); //initialize history
            state_history.Add(new AlgorithmEpisode(1)); //Create the first episode. The current state is retieved from the most recent point. 


            algorithm_ended = false;
            algorithm_started = false;           
        }

        public static AlgorithmState GetCurrentState()
        {
            int episode_index = state_history.Count - 1;
            if (episode_index == -1)
            {
                return null; //No episodes created
            }
            else
            {
                int step_index = state_history[episode_index].Count() - 1;
                if (step_index == -1)
                    return null; //Step index shouldn't be 0, because we shouldn't call this at a time when we created a new episode but didn't put a state there.
                else
                    return state_history[episode_index][step_index];
            }
        }

        //Called at algorithm start, and on reset
        public static void StartAlgorithm()
        {
            algorithm_started = true;
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

            if (step_with.GetEpisodeNumber() > state_history.Count)
            {
                state_history.Add(new AlgorithmEpisode(state_history.Count + 1)); //Add the first empty episode
            }
            else
            {


                step_with.Step();
            }

            state_history.Last().Add(step_with); //Add the state to the history list, after everything possible has been done to it.    
            step_with.GenerateStatusMessage();



        }


        //At the algorithm manager level, "generate step" is ambiguous with actually stepping through the algorithm,
        //Or starting the algorithm, and making the first history entry at step 0.
        //Here, a step only happens when we have been asked by the manager to *actually* take a step.
        public void Step()
        {
            board_data.UnitPercieves(UnitType.Bender);
            //Url senses twice. If bender moves into him, he wont start chasing until next turn.
            board_data.UnitPercieves(UnitType.Url);

            Move best_move = null;
            //If prior to bender moving, URL could not see bender, he will not attack this turn.
            foreach (var i in board_data.units[UnitType.Url].perception_data.perception_data)
            {
                if (i.Value == Percept.Enemy)
                {
                    best_move = i.Key;
                }
            }
            if (best_move == null)
                board_data.units[UnitType.Url].chasing = false;


            //Bender section.
            moves_this_step[UnitType.Bender] = live_qmatrix.GenerateStep(bender_perception_starting);
            result_this_step = board_data.ApplyMove(UnitType.Bender, moves_this_step[UnitType.Bender]); //The move should be performed now, if possible.
            obtained_reward = MoveResult.list[result_this_step]; //Get the reward for this action

            episode_rewards += obtained_reward; //Update the rewards total

            if (result_this_step == MoveResult.CanCollected)
                ++cans_collected;

            bender_perception_ending = board_data.units[UnitType.Bender].get_perception_state();

            
            //give the value to the q matrix to digest

            if (GetStepNumber() == Qmatrix.step_limit && GetEpisodeNumber() > Qmatrix.episode_limit)
                algorithm_ended = true;            

            //url 
            board_data.UnitPercieves(UnitType.Url);
            
            List<Move> best_moves = new List<Move>();

            if (board_data.units[UnitType.Url].chasing == true && MyRandom.Next(0, 5) == 0)
                board_data.units[UnitType.Url].chasing = false; //stop chasing randomly
            if (board_data.units[UnitType.Url].chasing == true)
            {   //Greedy selection
                foreach (var i in board_data.units[UnitType.Url].perception_data.perception_data)
                {
                    if (i.Value == Percept.Enemy)
                    {
                        best_move = i.Key;
                    }
                }
            }
            else //Take a random move that isn't into a wall or a diagonal
            {
                foreach (var i in board_data.units[UnitType.Url].perception_data.perception_data)
                {
                    if (i.Value != Percept.Wall && !(Move.Diagonals.Contains(i.Key)))
                        best_moves.Add(i.Key);

                    if (i.Value == Percept.Enemy)
                        board_data.units[UnitType.Url].chasing = true;
                    //When we first start chasing, we pause one time. Otherwise bender would run into us and never learn.
                }
                if (board_data.units[UnitType.Url].chasing == true)
                    best_move = Move.Wait; //Wait if we just started chasing
                else
                    best_move = best_moves[MyRandom.Next(0, best_moves.Count)];
            }

            //detect if bender was attacked
            //See if the move url selected perceives an enemey to do this
            if(best_move != Move.Wait && board_data.units[UnitType.Url].perception_data.perception_data[best_move] == Percept.Enemy)
            {   //Url attacks bender. don't move him just so its visually easier to see.
                obtained_reward = MoveResult.list[MoveResult.EnemeyEncountered];
                bender_attacked = true;
                result_this_step = MoveResult.EnemeyEncountered;
            }

            live_qmatrix.UpdateState(bender_perception_starting, bender_perception_ending, moves_this_step[UnitType.Bender], obtained_reward);

            //Move url, maybe into bender
            board_data.ApplyMove(UnitType.Url, best_move);
            moves_this_step[UnitType.Url] = best_move;
        }

        //Gets the qmatrix view for the give move at bender's current position
        static public string GetQmatrixView(Move move_to_get)
        {
            ValueSet to_get = GetCurrentQmatrix().matrix_data[GetCurrentState().board_data.units[UnitType.Bender].get_perception_state()];
            return to_get.move_list[move_to_get].ToString();
        }

        public void EraseBoardForReset()
        {   //Used ONLY with the restart algorithm button. Keeps a few old things, like bender's position and settings
            algorithm_started = false; //Algorithm no longer running
            InitializeValues();
            state_history = new List<AlgorithmEpisode>();
            state_history.Add(new AlgorithmEpisode(1));
            FormsHandler.ResetConfiguration();
        }

        //Non-static functions
        //Default config algorithm state
        //This is called when the program is launched.
        public AlgorithmState()
        {
            board_data = new BoardGame(); //Produces a shuffled bender and can-filled board 

            moves_this_step = new Dictionary<UnitType, Move>(); //Stores a list of moves for each unit

            InitializeValues(); //Gives us some empty defaults
        }

        //Called from create_empty_board (after reset), and the constructor
        //Just a useful container for resetting some values when we want to start over, but making a new state would have us lose bender's position.
        private void InitializeValues()
        {
            board_data.ClearCans(); //Clear the board for our initial launch(this doesn't remove bender, just cans)
            live_qmatrix = new Qmatrix();
        }

        //Copied from another algorithm state
        //We reset some data, so we dont reflect values that aren't true for the new state
        //This constructor is called when a new step is being generated, so we transfer some values appropriately.
        public AlgorithmState(AlgorithmState set_from)
        {
            cans_collected = set_from.cans_collected;

            episode_rewards = set_from.episode_rewards; //Reward data
            total_rewards = set_from.total_rewards;

            board_data = new BoardGame(set_from.board_data); //Copy the board

            //Increase steps in here
            live_qmatrix = new Qmatrix(set_from.live_qmatrix); //Copy the q matrix
            
            //The initial location will be the resulting location of the last step
            location_initial = board_data.GetUnitSquare[UnitType.Bender];

            bender_perception_starting = set_from.bender_perception_ending;

            moves_this_step = new Dictionary<UnitType, Move>();

            //Detect if we reached the limit for this episode

            if (live_qmatrix.step_number == Qmatrix.step_limit || board_data.BenderAttacked())
                StartNewEpisode();
            else
                live_qmatrix.step_number++;
        }

        public Percept GetBenderPercept(Move direction_to_check)
        {
            return board_data.units[UnitType.Bender].get_percept(direction_to_check);
        }

        //Used to erase session-based progress.
        //This is also called each new episode once we reach the max steps
        //Not called when the program launches
        public void StartNewEpisode()
        {


            cans_collected = 0;
            episode_rewards = 0; //Session - Reward data

            board_data.ShuffleCansAndUnits(); //Shuffle the the current board.

            foreach(var i in board_data.units.Keys)
            {
                board_data.UnitPercieves(i);
            }

            bender_perception_starting = board_data.units[UnitType.Bender].get_perception_state();
            bender_perception_ending = board_data.units[UnitType.Bender].get_perception_state();

            live_qmatrix.ProcessNewEpisode();
        }


        override public string ToString()
        {
            return "[Episode: " + GetEpisodeNumber().ToString() + "][Step: " + GetStepNumber() + "]";
        }

        public static Qmatrix GetCurrentQmatrix()
        {
            return GetCurrentState().live_qmatrix;
        }

        public static BoardGame GetCurrentBoard()
        {
            return GetCurrentState().board_data;
        }

        //Add a state
        public static void AddToHistory(AlgorithmState to_add)
        {
            state_history.Last().Add(to_add);
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
            return live_qmatrix.episode_number;
        }

        public int GetStepNumber()
        {
            return live_qmatrix.step_number;
        }

        private void GenerateStatusMessage()
        {
            status_message = new StatusMessage(this);
        }

        public string GetStatus()
        {
            if(status_message == null)
            {
                StatusMessage status = new StatusMessage(this);
                return status.GetMessage();
                
            }
            return status_message.GetMessage();
        }
    } 
}
