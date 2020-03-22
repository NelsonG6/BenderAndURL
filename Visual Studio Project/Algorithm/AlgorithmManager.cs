using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenderAndURL
{
    class AlgorithmManager
    {
        //Static members

        //Commenting this so i can just use a function that points to the most recent state
        //static public AlgorithmState current state; //This is a pointer to the most recently generated state

        static public List<AlgorithmEpisode> StateHistory; //This is the history of the entire run, and all the configurations and q-matrix instances.
                                                           //The head of this list is the current progress point of our algorithm.

        static public bool AlgorithmStarted; //Used for the status message
        static public bool AlgorithmEnded;

        //This should be called at the program launch, and when the reset config button is pressed
        public static void SetDefaultConfiguration()
        {
            StateHistory = new List<AlgorithmEpisode>(); //initialize history
            StateHistory.Add(new AlgorithmEpisode(1)); //Create the first episode. The current state is retieved from the most recent point. 


            AlgorithmEnded = false;
            AlgorithmStarted = false;
        }

        public static AlgorithmState GetCurrentState()
        {
            int episodeIndex = StateHistory.Count - 1;
            if (episodeIndex == -1)
            {
                return null; //No episodes created
            }
            else
            {
                int stepIndex = StateHistory[episodeIndex].Count() - 1;
                if (stepIndex == -1)
                    return null; //Step index shouldn't be 0, because we shouldn't call this at a time when we created a new episode but didn't put a state there.
                else
                    return StateHistory[episodeIndex][stepIndex];
            }
        }

        //Called at algorithm start, and on reset
        public static void StartAlgorithm()
        {
            AlgorithmStarted = true;
            AddToHistory(FormsHandler.LoadedState); //Copy our state from forms handler
            GetCurrentState().StartNewEpisode();
        }

        //Manages the state history, and making sure the correct state is being created/stored
        public static void StepPrepare() //Go to the most current state, and step forward once. 
        {   //If the algorithm hasn't started, this will just start the algorithm and leave us at step 0.

            //use start new episode if this is the first step
            //step and add, or dont step and dont add
            AlgorithmState stepWith = new AlgorithmState(GetCurrentState());

            //After the copy consctructor above, the state will have the correct episode number.
            //We may need to add a new episode.


            if (stepWith.GetEpisodeNumber() > StateHistory.Count)
            {
                StateHistory.Add(new AlgorithmEpisode(StateHistory.Count + 1)); //Add the first empty episode
            }
            else
            {


                stepWith.Step();
            }

            StateHistory.Last().Add(stepWith); //Add the state to the history list, after everything possible has been done to it.    
            stepWith.GenerateStatusMessage();

            if (GetCurrentState().GetUnit(UnitType.Url).chasing == true)
                FormsHandler.hasUrlStartedChasing = false;

        }

        //Gets the qmatrix view for the give move at bender's current position
        static public string GetQmatrixView(Move moveToGet)
        {
            ValueSet toGet = GetCurrentQmatrix().MatrixData[GetCurrentState().BoardData.Units[UnitType.Bender].GetPerceptionState()];
            return toGet.MoveList[moveToGet].ToString();
        }

        public static Qmatrix GetCurrentQmatrix()
        {
            return GetCurrentState().LiveQmatrix;
        }

        public static BoardGame GetCurrentBoard()
        {
            return GetCurrentState().BoardData;
        }

        //Add a state
        public static void AddToHistory(AlgorithmState toAdd)
        {
            StateHistory.Last().Add(toAdd);
        }

        public static void EraseBoard()
        {
            AlgorithmStarted = false; //Algorithm no longer running
            StateHistory = new List<AlgorithmEpisode>();
            StateHistory.Add(new AlgorithmEpisode(1));
        }

    }
}
