using System;
using System.Collections.Generic;
using System.Linq;

namespace BenderAndURL
{
    class AlgorithmState
    {

        public bool UrlRandomlyStopped;
        public bool StartedChasing;
        public bool BenderAttacked;

        public BoardGame BoardData; //Stores the state of the cans and walls (bender is stored with other coordinates)

        private StatusMessage StatusMessage; //Used for debugging
        public Qmatrix LiveQmatrix; //Moves will be generated from here.

        public double EpisodeRewards; //Session - Reward data
        public double TotalRewards;

        public SquareBoardBase LocationInitial; //Just used for the status message

        public MoveResult ResultThisStep; //Moveresult stored for status

        public double ObtainedReward; //The raw reward for the action we took

        public int CansCollected;
        
        //Default config algorithm state
        //This is called when the program is launched.
        public AlgorithmState()
        {
            BoardData = new BoardGame(); //Produces a shuffled bender and can-filled board 
            InitializeValues(); //Gives us some empty defaults
        }

        //Called from create empty board (after reset), and the constructor
        //Just a useful container for resetting some values when we want to start over, but making a new state would have us lose bender's position.
        public void InitializeValues()
        {
            BoardData.ClearCans(); //Clear the board for our initial launch(this doesn't remove bender, just cans)
            LiveQmatrix = new Qmatrix();
        }

        //Copied from another algorithm state
        //We reset some data, so we dont reflect values that aren't true for the new state
        //This constructor is called when a new step is being generated, so we transfer some values appropriately.
        public AlgorithmState(AlgorithmState setFrom)
        {
            CansCollected = setFrom.CansCollected;

            EpisodeRewards = setFrom.EpisodeRewards; //Reward data
            TotalRewards = setFrom.TotalRewards;

            BoardData = new BoardGame(setFrom.BoardData); //Copy the board

            //Increase steps in here
            LiveQmatrix = new Qmatrix(setFrom.LiveQmatrix); //Copy the q matrix

            //The initial location will be the resulting location of the last step
            LocationInitial = BoardData.GetUnitSquare[UnitType.Bender];            

            //Detect if we reached the limit for this episode


            if (LiveQmatrix.setNumber == Qmatrix.stepLimit || setFrom.BenderAttacked)
                if (LiveQmatrix.episodeNumber == Qmatrix.episodeLimit)
                    AlgorithmManager.AlgorithmEnded = true;
                else
                {
                    StartNewEpisode();
                }
            else
                LiveQmatrix.setNumber++;

        }

        //At the algorithm manager level, "generate step" is ambiguous with actually stepping through the algorithm,
        //Or starting the algorithm, and making the first history entry at step 0.
        //Here, a step only happens when we have been asked by the manager to *actually* take a step.
        public void Step()
        {
            BoardData.UnitPercieves(UnitType.Url);
            BoardData.UnitPercieves(UnitType.Bender);

            Move urlFirstMove;
            Move urlSecondMove = null;
            List<Move> UrlMoves;

            Move benderMove;

            //Url senses twice. If bender moves into him, he wont start chasing until next turn.
            //This is a pre-bender-move view. this is the view we use 
            //At this point, URL is seeing what happened before bender moves.
            //We want to see if URL is attacking bender at his new location. But if he isn't, we'll need to...
            //store where bender used to be, before seeing if he moved out of view, or if we can attack him.
            //url 

            if(GetUnit(UnitType.Url).chasing )
                foreach (var i in BoardData.Units[UnitType.Url].PerceptionData.PerceptionData)
                {
                    if (i.Value == Percept.Enemy)
                    {
                        urlFirstMove = i.Key;
                    }
                }

            //url move should not be null, since once url starts chasing, he should always see bender
            //each perception thereafter
            //Url move will most likely be a diagonal

            //Bender section.
            benderMove = LiveQmatrix.GenerateStep(GetPerception(UnitType.Bender));
            GetUnit(UnitType.Bender).SetMoveThisStep(benderMove); //Store the step for status message



            //Check if bender chose a move that moves him into url.
            //If bender did not make a move that knocks him into the enemy,
            //Only then should bender move
            ResultThisStep = BoardData.ApplyMove(UnitType.Bender, benderMove); //The move should be performed now, if possible.    

            //See if URL can attack bender after bender moved
            //In the below section, we see if URL attacks bender, before updating the q matrix.

            //Update reward in this section
            BoardData.UnitPercieves(UnitType.Url); //what url sees after bender moves
            //Previous optimal move is stored in urlFirstMove

            if(GetUnit(UnitType.Url).chasing && MyRandom.Next(0, InitialSettings.URLStopsChasingChance) == 0)
            {
                UrlRandomlyStopped = true;
                GetUnit(UnitType.Url).chasing = false;
            }

            if (GetUnit(UnitType.Url).chasing)
            {   
                //Loop through Url's perceptions
                foreach (var i in BoardData.Units[UnitType.Url].PerceptionData.PerceptionData)
                {   //Url is already chasing.
                    //See if bender made a bad move, and even though he moves before us,
                    //he didn't avoid us properly
                    if (i.Value == Percept.Enemy)
                        urlSecondMove = i.Key;
                }
                if(urlSecondMove != null)
                {   //Bender made a bad move. Attack him.
                    ObtainedReward = MoveResult.EnemyEncountered.Value;
                    BenderAttacked = true;
                    ResultThisStep = MoveResult.EnemyEncountered;
                    urlFirstMove = urlSecondMove;
                }
                else
                {   //Bender ran away correctly. Copy his move and follow him.
                    urlFirstMove = benderMove;
                }
            }
            else
            {   //Url is not chasing. See if after bender moved, we he ran into url.
                //If so, start chasing.
                foreach (var i in BoardData.Units[UnitType.Url].PerceptionData.PerceptionData)
                {
                    if (i.Value == Percept.Enemy)
                    {
                        urlSecondMove = i.Key;
                    }
                }
                if(urlSecondMove != null)
                {   //We found a move that detects bender. Start chasing.
                    StartedChasing = true;
                    GetUnit(UnitType.Url).chasing = true;
                    urlFirstMove = Move.Wait;
                }
                else
                {   //urlsecond move was null, so we didn't see bender. Normal behavior.
                    //Pick a random move that isn't moving into a wall or sitting still.
                    UrlMoves = new List<Move>();

                    //Left off with looping through url's perceptions to find a non-wall, non grab move.
                    foreach (var i in BoardData.Units[UnitType.Url].PerceptionData.PerceptionData)
                    {
                        if(i.Value != Percept.Wall && i.Key != Move.Grab && i.Key != Move.Wait && Move.CardinalMoves.Contains(i.Key))
                            UrlMoves.Add(i.Key);
                    }
                    //Its impossible not to have a move here, so take a random one thats available.
                    urlFirstMove = UrlMoves[MyRandom.Next(0, UrlMoves.Count)];
                }
            }

            ObtainedReward = ResultThisStep.Value; //Get the reward for this action

            EpisodeRewards += ObtainedReward; //Update the rewards total

            if (ResultThisStep == MoveResult.CanCollected)
                ++CansCollected;

            //give the value to the q matrix to digest

            if (GetStepNumber() == Qmatrix.stepLimit && GetEpisodeNumber() > Qmatrix.episodeLimit)
                AlgorithmManager.AlgorithmEnded = true;

            if (benderMove == null)
                BoardData.Units[UnitType.Url].chasing = false;

            PerceptionState startingState = GetUnit(UnitType.Bender).GetStartingPerceptionState();
            LiveQmatrix.UpdateState(startingState, GetPerception(UnitType.Bender), benderMove, ObtainedReward);

            GetUnit(UnitType.Url).SetMoveThisStep(urlFirstMove); //for status smessage

            //Move url
            if (!BenderAttacked)
            {
                BoardData.ApplyMove(UnitType.Url, urlFirstMove);
                urlFirstMove = null;

                //Now that url moved, detect if he is chasing again.
                if(GetUnit(UnitType.Url).chasing == false)
                {
                    foreach (var i in BoardData.Units[UnitType.Url].PerceptionData.PerceptionData)
                    {
                        if (i.Value == Percept.Enemy)
                            urlFirstMove = i.Key;
                    }
                    if (urlFirstMove != null)
                    {
                        GetUnit(UnitType.Url).chasing = true;
                        StartedChasing = true;
                    }
                }
            }

            //Now that url has moved, see if bender is in view. If so, chase him.

            //Make each unit perceieve after their step
            UnitPerceives(UnitType.Bender);
            UnitPerceives(UnitType.Url);
        }

        //Used to erase session-based progress.
        //This is also called each new episode once we reach the max steps
        //Not called when the program launches
        public void StartNewEpisode()
        {
            

            CansCollected = 0;
            EpisodeRewards = 0; //Session - Reward data

            BoardData.ShuffleCansAndUnits(); //Shuffle the the current board.

            //Each unit perceives 
            foreach(var i in BoardData.Units.Keys)
            {
                BoardData.UnitPercieves(i);
            }

            LiveQmatrix.ProcessNewEpisode();
            StatusMessage = new StatusMessage(this);
        }


        override public string ToString()
        {
            return "[Episode: " + GetEpisodeNumber().ToString() + "][Step: " + GetStepNumber() + "]";
        }


        
        public int GetEpisodeLimit()
        {
            return Qmatrix.episodeLimit;
        }

        public int GetStepLimit()
        {
            return Qmatrix.stepLimit;
        }

        public int GetEpisodeNumber()
        {
            return LiveQmatrix.episodeNumber;
        }

        public int GetStepNumber()
        {
            return LiveQmatrix.setNumber;
        }

        public void GenerateStatusMessage()
        {
            StatusMessage = new StatusMessage(this);
        }

        public string GetStatus()
        {
            if(StatusMessage == null)
            {
                StatusMessage status = new StatusMessage(this);
                return status.GetMessage();
                
            }
            return StatusMessage.GetMessage();
        }

        public void UnitPerceives(UnitType toSee)
        {
            BoardData.UnitPercieves(toSee);
        }

        public PerceptionState GetPerception(UnitType toSee)
        {
            return BoardData.Units[toSee].PerceptionData;
        }

        public UnitBase GetUnit(UnitType toGet)
        {
            return BoardData.Units[toGet];
        }

        public void SetErasedStatus()
        {
            StatusMessage = StatusMessage.ErasedMessage;
        }
    } 
}
