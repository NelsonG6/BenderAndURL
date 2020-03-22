using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BenderAndURL
{
    static class FormsHandler
    {
        static public bool hasUrlStartedChasing;
        
        //Initial settings
        static public TextBox NumberOfEpisodes;
        static public TextBox NumberOfSteps;
        static public TextBox EtaInitial;
        static public TextBox GammaInitial;
        static public TextBox EpsilonInitial;
        //Rewards
        static public TextBox WallPunishmentTextbox;
        static public TextBox EmptySquarePunishmentTextbox;
        static public TextBox BeerRewardTextbox;
        static public TextBox SuccessfulMoveTextbox;

        //Q-matrix view
        static public ComboBox QmatrixStateComboboxLarge; //The larger dropdown
        static public TextBox QmatrixStoredEntires;
        
        //Session progress
        static public TextBox StepNumber;
        static public TextBox EpisodeNumber;
        static public TextBox EpsilonThisSession;
        static public TextBox GammaThisSession;
        //Rewards
        static public TextBox BeerCollected;
        static public TextBox BeerRemaining;
        static public TextBox RewardThisEpisode;
        static public TextBox RewardTotal;

        static public RichTextBox StatusBox;

        //List of groupbox controls
        static Control form1Control;
        static GroupBox GroupboxInitialSettings;
        static GroupBox GroupboxRewards;
        static GroupBox GroupboxQmatrix;
        static GroupBox GroupboxMatrixSelect;
        static GroupBox GroupboxQmatrixValues;
        static GroupBox GroupboxSessionProgress;
        static GroupBox GroupboxCanData;
        static GroupBox GroupboxRewardData;
        static GroupBox GroupboxCurrentPosition;
        static GroupBox GroupboxAlgorithmProgress;
        static GroupBox GroupboxHistory;


        //Control progress
        static ComboBox ControlProgressSteps;
        static ComboBox ControlProgressEpisodes;
        static ComboBox ControlProgressDelay;

        //History
        static ComboBox ComboboxHistoryEpisodes;
        static ComboBox ComboboxHistorySteps;

        static public bool LockIndexChangeEvents;

        //static public bool is_drop_down_open; //why do i need this?        

        static public bool Halted;

        static public List<TextBox> ListSessionProgress;

        //store a textbox that displays the percepts of the current position for each move
        static public Dictionary<Move, TextBox> ListCurrentPositionTextboxes;
        //Store a textbox that displays a q-matrix value for each move
        static public Dictionary<Move, TextBox> ListQmatrixValueTextboxes;
        static public Dictionary<Move, ComboBox> ListQmatrixComboboxes; //Store a q-matrix combobox for each move

        //Current position

        //static public List<List<PictureSquare>> current_board;
        //replacing this with a board object
        //not sure if polypmorphism will like that

        //This will be set from the outside, and we will display whatever is in here.
        //static public AlgorithmState current_state;

        static public AlgorithmState LoadedState; //The forms handler essentially always stores one state to be displayed at a time.

        static public BoardDisplay PictureBoard; //Stored seperately from the algorithm state because this board will store PictureSquares

        //Main entry point for my source code
        static FormsHandler()
        {

        }

        static public void Load()
        {
            PictureBoard = new BoardDisplay();
            LoadedState = new AlgorithmState();

            InitialSettings.Initialize();

            LockIndexChangeEvents = false;
            Halted = false;
            //Pass textboxes to the board, so it can manage them.

            LinkHandlerToForm();

            //Initialize dropdown boxes
            ControlProgressSteps.SelectedIndex = 0;
            ControlProgressEpisodes.Text = "0"; ;
            ControlProgressDelay.Text = InitialSettings.MsDelay.ToString();

            foreach (var i in ListQmatrixComboboxes)
            {
                i.Value.SelectedIndex = -1;
            }

            DisplayInitialSettings();
        }

        static public void Initialize()
        {

        }

        //This is ran every time we step through the algorithm.
        //Handles updating all the fields that change every time we look at new data
        //This method handles any time we are updating what is displayed for any reason once the algorithm is active
        //We expect the algorithm state to be set from the outside before we enter this.
        //This will also handle updating the history dropdowns
        static public void DisplayState()
        {
            PictureBoard.ClonePosition(LoadedState.BoardData); //This copies the state's board over to our PictureSquare board.

            //Textboxes update
            if (AlgorithmManager.AlgorithmStarted) //Only display this if we've started
            {
                //This will configure the q-matrix dropdowns properly, and handle if there is no qmatrix as well.
                //This doesn't affect the stored entries textbox
                HandleQmatrixForms(LoadedState);

                //Session progress
                StepNumber.Text = LoadedState.GetStepNumber().ToString();
                EpisodeNumber.Text = LoadedState.GetEpisodeNumber().ToString();
                EpsilonThisSession.Text = GetString(LoadedState.LiveQmatrix.Epsilon);
                GammaThisSession.Text = LoadedState.LiveQmatrix.Gamma.ToString();

                //If this moveset doesn't exist, we should get an error.
                //This function should only be called at the algorithm start, or from a dropdown that has a valid q-matrix combination.
                //These textboxes handle percepts

                PerceptionState toView = LoadedState.BoardData.Units[UnitType.Bender].PerceptionData;

                foreach (var i in Move.HorizontalMovesAndGrab)
                {
                    ListCurrentPositionTextboxes[i].Text = toView.PerceptionData[i].ToString();
                }

                BeerRemaining.Text = LoadedState.BoardData.GetCansRemaining().ToString();
                BeerCollected.Text = LoadedState.CansCollected.ToString();
                RewardThisEpisode.Text = LoadedState.EpisodeRewards.ToString();
                RewardTotal.Text = LoadedState.TotalRewards.ToString();

                //Update the history episode dropdown
                if (ComboboxHistoryEpisodes.Items.Count < AlgorithmManager.StateHistory.Count)
                    ComboboxHistoryEpisodes.Items.Add(AlgorithmManager.StateHistory.Last());

                ComboboxHistoryEpisodes.SelectedIndex = ComboboxHistoryEpisodes.Items.Count - 1;

                if (!ComboboxHistorySteps.Items.Contains(LoadedState) || LoadedState.GetStepNumber() == 0)
                {
                    ComboboxHistorySteps.Items.Clear();
                    ComboboxHistorySteps.Items.AddRange(AlgorithmManager.StateHistory.Last().ToArray());
                    ComboboxHistorySteps.Text = LoadedState.ToString();
                }
            }

            
            StatusBox.Text = LoadedState.GetStatus();

            //Handle drawing the board
            foreach (var i in PictureBoard.BoardData)
            {
                foreach (var j in i)
                {
                    ((SquareBoardDisplay)j).SetPicture();
                }
            }

            DisplayInitialSettings();

            //If the algorithm is ended, disable the stepping groupbox.
            if(AlgorithmManager.AlgorithmEnded == true)
            {
                GroupboxAlgorithmProgress.Enabled = false;
            }
        }

        static public void DisplayInitialSettings()
        {
            //initial settings
            NumberOfEpisodes.Text = LoadedState.GetEpisodeLimit().ToString(); //Constructor launcher for algorithmstate 6-5
            NumberOfSteps.Text = LoadedState.GetStepLimit().ToString();

            EtaInitial.Text = GetString(LoadedState.LiveQmatrix.Eta);
            GammaInitial.Text = GetString(LoadedState.LiveQmatrix.Gamma);
            EpsilonInitial.Text = GetString(LoadedState.LiveQmatrix.Epsilon);
            EmptySquarePunishmentTextbox.Text = MoveResult.CanMissing.Value.ToString();
            WallPunishmentTextbox.Text = MoveResult.TravelFailed.Value.ToString();
            BeerRewardTextbox.Text = MoveResult.CanCollected.Value.ToString();
            SuccessfulMoveTextbox.Text = MoveResult.TravelSucceeded.Value.ToString();
        }

        //This is used to display rows of the qmatrix and the q-values for each move
        //This is called from FormsHandler.DisplayState, as well as directly from the dropdowns when their contents are changed.
        //When this is called from displaystate, the perception to view may not be valid.
        //When this is called from the dropdown, the perception should exist in the qmatrix.
        static private void HandleQmatrixForms(AlgorithmState currentState)
        {
            QmatrixStoredEntires.Text = currentState.LiveQmatrix.MatrixData.Count.ToString();

            //May not have qmatrix data at the step being displayed.
            if (currentState.LiveQmatrix.MatrixData.Count == 0)
            {   //There are no q-matrix entries.
                //reset qmatrix combo boxes
                foreach (var i in ListQmatrixComboboxes.Values)
                {
                    i.Items.Clear();
                    i.Items.Add("None");
                }

                QmatrixStateComboboxLarge.Items.Clear();
                QmatrixStateComboboxLarge.Items.Add("A q-matrix entry has not yet been made.");


                //reset qmatrix textboxes
                foreach (var i in ListQmatrixValueTextboxes.Values) { i.Clear(); }
            }
            else
            {
                //Build q-matrix dropdowns.
                //use a hashset to avoid adding duplicates
                //For each move, we want a hashet of percepts, in other words all the percepts that this move sees in the q matrix entries that exist.
                Dictionary<Move, HashSet<Percept>> dropdownTextItems = new Dictionary<Move, HashSet<Percept>>();

                //Initialize hashsets before looping over perceptionstates
                foreach (var i in Move.HorizontalMovesAndGrab)
                {
                    dropdownTextItems.Add(i, new HashSet<Percept>());
                }

                //Copy the items over to the small comboboxes.
                foreach (var i in currentState.LiveQmatrix.MatrixData.Keys)
                {
                    foreach (var j in Move.HorizontalMovesAndGrab)
                    {
                        //For each qmatrix entry, copy each percept over to dropdowns dictionary for the appropriate move.
                        dropdownTextItems[j].Add(i.PerceptionData[j]);
                    }
                }


                //Cycle through the moves to add to select each small combobox
                foreach (var i in Move.HorizontalMovesAndGrab)
                {
                    ListQmatrixComboboxes[i].Items.Clear();
                    //Cycle through the percepts we gathered for this move's dropdown
                    foreach (var j in dropdownTextItems[i].OrderBy(o => o.perceptData))
                    {
                        ListQmatrixComboboxes[i].Items.Add(j); //I think i can just give my objects a tostring method
                    }
                }

                //Refresh the overall-state dropdown
                QmatrixStateComboboxLarge.Items.Clear();
                foreach (var i in currentState.LiveQmatrix.MatrixData.Keys.OrderBy(o => o.ID))
                {
                    QmatrixStateComboboxLarge.Items.Add(i);
                }

                if (currentState.LiveQmatrix.MatrixData.Keys.Contains(currentState.GetPerception(UnitType.Bender)))
                    ViewQmatrixConfiguration(currentState.GetPerception(UnitType.Bender));
                else
                    ViewQmatrixConfiguration(LoadedState.LiveQmatrix.MatrixData.Keys.First()); //Just grab the first q-matrix item

            }
        }

        //This is called when the dropdown menu boxes change, as well as from display_state().
        //This will update the comboboxes, state dropdown, and the q-matrix value textboxes.
        static public void ViewQmatrixConfiguration(PerceptionState stateToView)
        {
            //We're only handed states that exist in the q-matrix already

            //Handle the small dropdowns
            //Set the dropdown to be selected to the correct percept
            //These will trigger the selected_indexChanged events
            //So I'll managed this with a lock
            LockIndexChangeEvents = true;
            foreach (var i in Move.HorizontalMovesAndGrab)
            {
                ListQmatrixComboboxes[i].SelectedIndex = ListQmatrixComboboxes[i].Items.IndexOf(stateToView.PerceptionData[i]);
            }

            //Handle the large dropdown
            QmatrixStateComboboxLarge.SelectedIndex = QmatrixStateComboboxLarge.Items.IndexOf(stateToView);

            //Handle the values stored in the textboxes

            foreach (var i in Move.HorizontalMovesAndGrab)
            {
                ListQmatrixValueTextboxes[i].Text = LoadedState.LiveQmatrix.MatrixData[stateToView].MoveList[i].ToString();
            }

            LockIndexChangeEvents = false;
        }


        

        //Used after "algorithm reset" button is pressed. Not used during algorithm run.
        static public void ResetConfiguration()
        {
            LoadedState.InitializeValues(); //Special function that creates a new board but keeps bender's position   
                                            //clear the board and keep bender 
                                            //This needs to handle the data that is not viewed when the algorithm isn't running

            LoadedState.SetErasedStatus();

            LockIndexChangeEvents = true;

            //Clear qmatrix value textboxes
            foreach(var i in ListQmatrixValueTextboxes)
            {
                i.Value.Clear();
            }

            //Session progess textboxes
            foreach(var i in ListSessionProgress)
            {
                i.Clear();
            }

            foreach (var i in ListQmatrixComboboxes.Values) { i.Items.Clear(); i.Text = ""; }
            foreach (var i in ListQmatrixValueTextboxes.Values) { i.Clear(); }

            LockIndexChangeEvents = false;

            QmatrixStateComboboxLarge.Text = "Select a board state...";

            ComboboxHistorySteps.Items.Clear();
            ComboboxHistorySteps.Text = "View prior steps...";

            ComboboxHistoryEpisodes.Items.Clear();
            ComboboxHistoryEpisodes.Text = "View prior episodes...";

            LoadedState.LiveQmatrix = new Qmatrix();

            DisplayState();            
        }


        //Triggers the constructor. Adds a PictureBox to a PictureSquare.
        static public void Add(int i, int j, SquareBoardDisplay squareToSet)
        {
            PictureBoard.BoardData[i][j] = squareToSet;
        }
        
        static public void LargeDropdownChanged()
        {
            ViewQmatrixConfiguration((PerceptionState)QmatrixStateComboboxLarge.SelectedItem);
        }

        static public void SmallDropdownChanged(ComboBox changedDropdown)
        {
            if(changedDropdown.SelectedText != "None.")
            {

                PerceptionState toSet = new PerceptionState(UnitType.Bender);
                Move perceptMove = null;

                foreach (var i in Move.HorizontalMovesAndGrab)
                {
                    if (changedDropdown == ListQmatrixComboboxes[i])
                        perceptMove = i;
                }

                //get the percept of the dropdown
                Percept keepForBestFit = (Percept)changedDropdown.SelectedItem;

                //Build a perception state that matches the dropdowns
                foreach (var i in Move.HorizontalMovesAndGrab)
                {
                    toSet.PerceptionData[i] = (Percept)ListQmatrixComboboxes[i].SelectedItem;
                }

                toSet.SetName();

                //This state may not exist in our q-matrix states, because we only changed one of the dropdowns.
                //The best solution i think is to make the other dropdowns find the most accurate state.
                //Compare all the states in the q-matrix, and display any that is tied for best matched.
                //Also, the matching state must have the same item as the dropdown we just changed.

                int compareValue = 0;
                int temp;
                PerceptionState bestPerceptionstate = null;
                foreach (PerceptionState i in QmatrixStateComboboxLarge.Items)
                {
                    temp = toSet.Compare(i);
                    if (temp > compareValue && i.Contains(perceptMove, keepForBestFit))
                    {
                        bestPerceptionstate = i;
                        compareValue = temp;
                    }
                }

                ViewQmatrixConfiguration(bestPerceptionstate);
            }


        }

        //Displays the most recent state in the algorithm history list
        static public void LoadAndDisplayState(AlgorithmState toDisplay)
        {
            LoadedState = toDisplay;
            DisplayState();
        }

        static public void LinkHandlerToForm()
        {
            form1Control = Application.OpenForms["Form1"];
            GroupboxInitialSettings = form1Control.Controls["GroupboxInitialSettings"] as GroupBox;
            GroupboxRewards = GroupboxInitialSettings.Controls["GroupboxRewards"] as GroupBox; ;
            GroupboxQmatrix = form1Control.Controls["GroupboxQmatrix"] as GroupBox; ;
            GroupboxMatrixSelect = GroupboxQmatrix.Controls["GroupboxQmatrixSelect"] as GroupBox; ;
            GroupboxQmatrixValues = form1Control.Controls["GroupboxQmatrix"].Controls["GroupboxQmatrixValues"] as GroupBox; ;
            GroupboxSessionProgress = form1Control.Controls["GroupboxSessionProgress"] as GroupBox; ;
            GroupboxCanData = GroupboxSessionProgress.Controls["GroupboxCanDataThisEpisode"] as GroupBox; ;
            GroupboxRewardData = GroupboxSessionProgress.Controls["GroupboxRewardData"] as GroupBox; ;
            GroupboxCurrentPosition = GroupboxSessionProgress.Controls["GroupboxCurrentPercepts"] as GroupBox; ;

            //Initial settings
            NumberOfEpisodes = GroupboxInitialSettings.Controls["TextboxInitialSettingsNumberOfEpisodes"] as TextBox;
            NumberOfSteps = GroupboxInitialSettings.Controls["TextboxInitialSettingsNumberOfSteps"] as TextBox;
            EtaInitial = GroupboxInitialSettings.Controls["TextboxInitialSettingsEta"] as TextBox;
            GammaInitial = GroupboxInitialSettings.Controls["TextboxInitialSettingsGamma"] as TextBox;
            EpsilonInitial = GroupboxInitialSettings.Controls["TextboxInitialSettingsEpsilon"] as TextBox;
            //Rewards
            WallPunishmentTextbox = GroupboxRewards.Controls["TextboxInitialSettingsRewardsWall"] as TextBox;
            EmptySquarePunishmentTextbox = GroupboxRewards.Controls["TextboxInitialSettingsRewardsEmptyGrab"] as TextBox;
            BeerRewardTextbox = GroupboxRewards.Controls["TextboxInitialSettingsRewardsBeer"] as TextBox;
            SuccessfulMoveTextbox = GroupboxRewards.Controls["TextboxInitialSettingsRewardsSuccessMove"] as TextBox;

            //Q-Matrix view
            QmatrixStateComboboxLarge = GroupboxMatrixSelect.Controls["ComboboxQmatrixSelect"] as ComboBox;
            QmatrixStoredEntires = GroupboxQmatrix.Controls["TextboxQmatrixStoredEntries"] as TextBox;

            ListQmatrixComboboxes = new Dictionary<Move, ComboBox>
            {
                [Move.Left] = GroupboxMatrixSelect.Controls["ComboboxQmatrixLeft"] as ComboBox,
                [Move.Right] = GroupboxMatrixSelect.Controls["ComboboxQmatrixRight"] as ComboBox,
                [Move.Up] = GroupboxMatrixSelect.Controls["ComboboxQmatrixUp"] as ComboBox,
                [Move.Down] = GroupboxMatrixSelect.Controls["ComboboxQmatrixDown"] as ComboBox,
                [Move.Grab] = GroupboxMatrixSelect.Controls["ComboboxQmatrixGrab"] as ComboBox
            };

            ListQmatrixValueTextboxes = new Dictionary<Move, TextBox>
            {
                [Move.Left] = GroupboxQmatrixValues.Controls["TextboxQmatrixValuesLeft"] as TextBox,
                [Move.Right] = GroupboxQmatrixValues.Controls["TextboxQmatrixValuesRight"] as TextBox,
                [Move.Down] = GroupboxQmatrixValues.Controls["TextboxQmatrixValuesDown"] as TextBox,
                [Move.Up] = GroupboxQmatrixValues.Controls["TextboxQmatrixValuesUp"] as TextBox,
                [Move.Grab] = GroupboxQmatrixValues.Controls["TextboxQmatrixValuesCurrent"] as TextBox
            };

            //Session progress
            StepNumber = GroupboxSessionProgress.Controls["TextboxSessionProgressStepNumber"] as TextBox;
            EpisodeNumber = GroupboxSessionProgress.Controls["TextboxSessionProgressEpisodeNumber"] as TextBox;
            EpsilonThisSession = GroupboxSessionProgress.Controls["TextboxSessionProgessEpsilon"] as TextBox;
            GammaThisSession = GroupboxSessionProgress.Controls["TextboxSessionProgressGamma"] as TextBox;

            //Can data and reward data
            BeerRemaining = GroupboxCanData.Controls["TextboxCanDataRemaining"] as TextBox;
            BeerCollected = GroupboxCanData.Controls["TextboxCanDataCollected"] as TextBox;
            RewardThisEpisode = GroupboxRewardData.Controls["TextboxRewardsDataThisEpisode"] as TextBox;
            RewardTotal = GroupboxRewardData.Controls["TextboxRewardsDataTotal"] as TextBox;

            //Current position
            ListCurrentPositionTextboxes = new Dictionary<Move, TextBox>
            {
                [Move.Left] = GroupboxCurrentPosition.Controls["TextboxCurrentPerceptsLeft"] as TextBox,
                [Move.Right] = GroupboxCurrentPosition.Controls["TextboxCurrentPerceptsRight"] as TextBox,
                [Move.Up] = GroupboxCurrentPosition.Controls["TextboxCurrentPerceptsUp"] as TextBox,
                [Move.Down] = GroupboxCurrentPosition.Controls["TextboxCurrentPerceptsDown"] as TextBox,
                [Move.Grab] = GroupboxCurrentPosition.Controls["TextboxCurrentPerceptsCurrentSquare"] as TextBox
            };

            //Add all these textboxes to a list
            ListSessionProgress = new List<TextBox>();
            foreach (var i in ListCurrentPositionTextboxes)
            {
                ListSessionProgress.Add(i.Value);
            }
            foreach (var i in ListQmatrixValueTextboxes)
            {
                ListSessionProgress.Add(i.Value);
            }

            ListSessionProgress.Add(StepNumber);
            ListSessionProgress.Add(EpisodeNumber);
            ListSessionProgress.Add(EpsilonThisSession);
            ListSessionProgress.Add(GammaThisSession);
            ListSessionProgress.Add(BeerRemaining);
            ListSessionProgress.Add(BeerCollected);
            ListSessionProgress.Add(RewardThisEpisode);
            ListSessionProgress.Add(RewardTotal);
            ListSessionProgress.Add(QmatrixStoredEntires);

            //Control progess
            GroupboxAlgorithmProgress = form1Control.Controls["GroupboxAlgorithmProgress"] as GroupBox;
            ControlProgressSteps = GroupboxAlgorithmProgress.Controls["ComboboxAdvanceSteps"] as ComboBox;
            ControlProgressEpisodes = GroupboxAlgorithmProgress.Controls["ComboboxAdvanceEpisodes"] as ComboBox;
            ControlProgressDelay = GroupboxAlgorithmProgress.Controls["ComboboxDelayMS"] as ComboBox;

            //Status message
            StatusBox = form1Control.Controls["GroupboxStatusMessage"].Controls["RichTextboxStatusMessage"] as RichTextBox;

            //History
            GroupboxHistory = form1Control.Controls["GroupboxHistory"] as GroupBox;
            ComboboxHistoryEpisodes = GroupboxHistory.Controls["ComboboxHistoryEpisode"] as ComboBox;
            ComboboxHistorySteps = GroupboxHistory.Controls["ComboboxHistoryStep"] as ComboBox;
        }

        public static string GetString(double toConvert)
        {
            return toConvert.ToString();
            //gotta fix this display setting later
        }
    }


}

