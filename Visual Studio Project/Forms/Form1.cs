using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenderAndURL
{
    public partial class Form1 : Form
    {
        public Form1() //First entry point of the program
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized; //Start with the window maximized
        }

        private void Form1Load(object sender, EventArgs e)
        {

            AlgorithmManager.SetDefaultConfiguration();

            //Second entry point of the program.
            //When the form loads, we'll create some pictureboxes, that will function as the robot world grid.            

            FormsHandler.Load();
            PictureBox picturebox_inProgress; //Temporary picturebox
            SquareBoardDisplay squareTo_build; //This is object inherits from boardSquare, but has a picture element.

            //Create pictureboxes and pass them to our board
            for (int i = 0; i < InitialSettings.SizeOfBoard; i++)
            {
                for (int j = 0; j < InitialSettings.SizeOfBoard; j++)
                {
                    //Fill in the column with rows
                    picturebox_inProgress = new PictureBox();
                    squareTo_build = new SquareBoardDisplay(i, j);
                    picturebox_inProgress.Name = i.ToString() + "-" + j.ToString(); //Each name is the coordinate
                    picturebox_inProgress.Location =
                        new Point(  InitialSettings.XOffset + (i * InitialSettings.EdgeLength),
                                    InitialSettings.YOffset + (j * InitialSettings.EdgeLength));
                    picturebox_inProgress.Size = new Size(InitialSettings.EdgeLength, InitialSettings.EdgeLength);
                    picturebox_inProgress.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturebox_inProgress.BackgroundImageLayout = ImageLayout.Stretch;
                    Controls.Add(picturebox_inProgress);
                    squareTo_build.pictureData = picturebox_inProgress;
                    FormsHandler.Add(i, 9-j, squareTo_build); //9-j to handle the board layout, for some reason!
                }
            }

            //Called from the restart button, but works here on initial launch.
            //This triggers the constructor for algorithm manager, as well

            RichTextboxStatusMessage.Text = "Program launched.";
            
            FormsHandler.DisplayState(); //First time we display the board.
        }

        private void ChangeEnabledSetting()
        {
            //Buttons
            ButtonConfigurationStartAlgorithm.Enabled = !ButtonConfigurationStartAlgorithm.Enabled;
            ButtonStopAlgorithm.Enabled = !ButtonStopAlgorithm.Enabled;

            //Groupboxes
            //Left side
            GroupboxConfiguration.Enabled = !GroupboxConfiguration.Enabled;
            GroupboxAlgorithmProgress.Enabled = !GroupboxAlgorithmProgress.Enabled;

            //Right side
            GroupboxQmatrix.Enabled = !GroupboxQmatrix.Enabled;
            GroupboxSessionProgress.Enabled = !GroupboxSessionProgress.Enabled;
            GroupboxHistory.Enabled = !GroupboxHistory.Enabled;
        }

        private void StartAlgorithm(object sender, EventArgs e)
        {
            ChangeEnabledSetting(); //Toggle controls
            AlgorithmManager.StartAlgorithm();

            FormsHandler.LoadAndDisplayState(AlgorithmManager.GetCurrentState());
        }

        private void RestartAlgorithmButtonClicked(object sender, EventArgs e)
        {
            FormsHandler.LoadedState = AlgorithmManager.GetCurrentState();
            AlgorithmManager.EraseBoard();
            
            FormsHandler.ResetConfiguration(); //Clear comboboxes and other forms
            ChangeEnabledSetting(); //Togle controls
        }

        //Advance algorithm button
        async private void ButtonAdvanceStepsComboboxClicked(object sender, EventArgs e)
        {
            FormsHandler.Halted = false;
            int stepsToTake = Int32.Parse(ComboboxAdvanceSteps.Text);
            int episodes = Int32.Parse(ComboboxAdvanceEpisodes.Text);
            if (episodes > 0)
                stepsToTake += (Int32.Parse(ComboboxAdvanceEpisodes.Text) * FormsHandler.LoadedState.GetStepLimit()) + 1; //+1 to get the new episode generated

            int initial_delay = Int32.Parse(ComboboxDelayMS.Text);
            int delay = initial_delay;

            if(CheckboxLoopUntilChasing.Checked)
            {
                FormsHandler.hasUrlStartedChasing = true;
            }

            if(FormsHandler.hasUrlStartedChasing)
            {
                while(FormsHandler.hasUrlStartedChasing)
                {
                    AlgorithmManager.StepPrepare();
                    
                }
                FormsHandler.LoadAndDisplayState(AlgorithmManager.GetCurrentState());
            }


            else if(stepsToTake > 1)
            {
                TextboxInProgressSteps.Text = stepsToTake.ToString();
                GroupboxCountDown.Enabled = true;
                GroupboxAlgorithmProgress.Enabled = false;
                GroupboxHistory.Enabled = false;
                while (stepsToTake-- > 0 && !FormsHandler.Halted)
                {
                    AlgorithmManager.StepPrepare();
                    FormsHandler.LoadAndDisplayState(AlgorithmManager.GetCurrentState());
                    TextboxInProgressSteps.Text = stepsToTake.ToString();
                    do
                    {
                        await Task.Delay(1);
                        TextboxInProgressTime.Text = delay.ToString();
                    } while (--delay > 0 && !FormsHandler.Halted);
                    delay = initial_delay;
                }
                GroupboxAlgorithmProgress.Enabled = true;
                GroupboxCountDown.Enabled = false;
                GroupboxHistory.Enabled = true;
            }

            else
            {
                AlgorithmManager.StepPrepare();
                FormsHandler.LoadAndDisplayState(AlgorithmManager.GetCurrentState());
            }
            
        }

        private void SetEpisodeFromCombobox(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(ComboboxConfigurationNumberOfEpisodes.Text, out int result);
            if (!success)
                ComboboxConfigurationNumberOfEpisodes.Text = "Invalid.";
            else
            {
                Qmatrix.episodeLimit = result;
                FormsHandler.DisplayInitialSettings();
            }
        }

        private void SetStepsFromCombobox(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(ComboboxConfigurationNumberOfStepsPerEpisode.Text, out int result);
            if (!success)
                ComboboxConfigurationNumberOfStepsPerEpisode.Text = "Invalid.";
            else
            {
                Qmatrix.stepLimit = result;
                FormsHandler.DisplayInitialSettings();
            }
        }

        private void SetEtaFromCombobox(object sender, EventArgs e)
        {

            bool success = double.TryParse(ComboboxConfigurationEta.Text, out double result);
            if (!success)
                ComboboxConfigurationEta.Text = "Invalid.";
            else
            {
                FormsHandler.LoadedState.LiveQmatrix.Eta = result;
                FormsHandler.DisplayInitialSettings();
            }
        }

        private void SetYFromCombobox(object sender, EventArgs e)
        {
            bool success = double.TryParse(ComboboxConfigurationGamma.Text, out double result);
            if (!success)
                ComboboxConfigurationGamma.Text = "Invalid.";
            else
            {
                FormsHandler.LoadedState.LiveQmatrix.Gamma = result;
                FormsHandler.DisplayInitialSettings();
            }
        }

        /*
        private void AdvanceOneStep(object sender, EventArgs e)
        {

        }
        */

        private void ComboboxConfigurationEpsilonClicked(object sender, EventArgs e)
        {
            bool success = double.TryParse(ComboboxConfigurationEpsilon.Text, out double result);
            if (!success)
                ComboboxConfigurationEpsilon.Text = "Invalid.";
            else
            {
                FormsHandler.LoadedState.LiveQmatrix.Epsilon = result;
                FormsHandler.DisplayInitialSettings();
            }
        }

        private void ComboboxRewardsRanIntoWallClicked(object sender, EventArgs e)
        {
            bool success = double.TryParse(ComboboxRewardsRanIntoWall.Text, out double result);
            if (!success)
                ComboboxRewardsRanIntoWall.Text = "Invalid.";
            else
            {
                MoveResult.TravelFailed.Value = result;
                FormsHandler.DisplayInitialSettings();
            }
        }

        /*
        private void button5Click(object sender, EventArgs e)
        {
            bool success = double.TryParse(ComboboxRewardsGrabbedEmptySquare.Text, out double result);
            if (!success)
                ComboboxRewardsGrabbedEmptySquare.Text = "Invalid.";
            else
            {
                MoveResult.CanMissing.Value = result;
                FormsHandler.DisplayInitialSettings();
            }
        }
        */
        private void ComboboxRewardsCollectedBeerClicked(object sender, EventArgs e)
        {
            bool success = double.TryParse(ComboboxRewardsCollectedBeer.Text, out double result);
            if (!success)
                ComboboxRewardsCollectedBeer.Text = "Invalid.";
            else
            {
                MoveResult.CanCollected.Value = result;
                FormsHandler.DisplayInitialSettings();
            }
        }

        private void ResetConfigButtonClicked(object sender, EventArgs e)
        {
            FormsHandler.ResetConfiguration();
        }

        private void ComboboxRewardsMovedWithoutHittingWallClicked(object sender, EventArgs e)
        {
            bool success = double.TryParse(ComboboxRewardsMovedWithoutHittingWall.Text, out double result);
            if (!success)
                ComboboxRewardsMovedWithoutHittingWall.Text = "Invalid.";
            else
            {
                MoveResult.TravelSucceeded.Value = result;
                FormsHandler.DisplayInitialSettings();
            }
        }

        private void ComboboxEpisodeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SetEpisodeFromCombobox(sender, e);
            }  
        }

        private void ComboboxStepsKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SetStepsFromCombobox(sender, e);
            }
        }

        private void ComboboxEtaKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SetEtaFromCombobox(sender, e);
            }
        }

        private void ComboboxGammaKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SetYFromCombobox(sender, e);
            }
        }

        private void ComboboxEpsilonKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComboboxConfigurationEpsilonClicked(sender, e);
            }
        }

        private void ComboboxBeerKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComboboxRewardsCollectedBeerClicked(sender, e);
            }
        }

        private void ComboboxEmptysquareKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComboboxRewardsGrabbedEmptySquareClicked(sender, e);
            }
        }

        private void ComboboxRewardsGrabbedEmptySquareClicked(object sender, EventArgs e)
        {
            bool success = double.TryParse(ComboboxRewardsGrabbedEmptySquare.Text, out double value);
            if (!success)
                ComboboxRewardsGrabbedEmptySquare.Text = "Invalid.";
            else
            {
                MoveResult.CanMissing.Value = value;
                FormsHandler.DisplayInitialSettings();
            }
        }

        private void ComboboxWallpunishmentKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComboboxRewardsRanIntoWallClicked(sender, e);
            }
        }

        private void ComboboxMovedWithoutWallKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ComboboxRewardsMovedWithoutHittingWallClicked(sender, e);
            }
        }

        private void Form1KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (ComboboxConfigurationNumberOfEpisodes.Text == "Invalid.")
                ComboboxConfigurationNumberOfEpisodes.Text = "";
        }

        private void QmatrixSmallDropdownChanged(object sender, EventArgs e)
        {
            if (!FormsHandler.LockIndexChangeEvents && ((ComboBox)sender).SelectedIndex > -1)
                if (((ComboBox)sender).SelectedText != "None.") 
                FormsHandler.SmallDropdownChanged((ComboBox)sender);
        }

        private void ComboboxQmatrixSelectIndexChanged(object sender, EventArgs e)
        {
            if (!FormsHandler.LockIndexChangeEvents && ((ComboBox)sender).SelectedIndex > -1)
                FormsHandler.LargeDropdownChanged();
        }

        private void ComboboxClickedClearText(object sender, EventArgs e)
        {

        }

        private void DropdownOpened(object sender, EventArgs e)
        {
            
        }

        private void DropdownClosed(object sender, EventArgs e)
        {

        }

        private void ComboboxAdvanceStepsLeave(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(ComboboxAdvanceSteps.Text, out int result);
            if (!success || result < 1)
            {
                if (Int32.Parse(ComboboxAdvanceEpisodes.Text) > 0)
                    ComboboxAdvanceSteps.Text = "0";
                else
                    ComboboxAdvanceSteps.Text = "1";
            }
            else            
                ComboboxAdvanceSteps.Text = result.ToString();

                
        }

        private void ComboboxAdvanceEpisodesLeave(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(ComboboxAdvanceEpisodes.Text, out int result);
            if (!success || result < 0)
            {
                ComboboxAdvanceEpisodes.Text = "0";
                if (Int32.Parse(ComboboxAdvanceSteps.Text) == 0)
                    ComboboxAdvanceSteps.Text = "1";


            }
        }

        private void ComboboxDelayMsLeave(object sender, EventArgs e)
        {
            bool success = Int32.TryParse(ComboboxDelayMS.Text, out int result);
            if (!success || result < 0)
                ComboboxDelayMS.Text = InitialSettings.MsDelay.ToString();
            else
                ComboboxDelayMS.Text = result.ToString();
        }

        private void ButtonStopClicked(object sender, EventArgs e)
        {
            FormsHandler.Halted = true;
            GroupboxAlgorithmProgress.Enabled = true;
            GroupboxCountDown.Enabled = false;
        }

        private void HistoryIndexChanged(object sender, EventArgs e)
        {
            ComboBox sender_box = (ComboBox)sender;
            if (sender_box.SelectedIndex > -1)
            {
                ComboboxHistoryStep.Items.Clear();

                AlgorithmEpisode to_display = (AlgorithmEpisode)sender_box.SelectedItem;
                ComboboxHistoryStep.Items.AddRange(to_display.stateHistoryData.ToArray());
                ComboboxHistoryStep.SelectedIndex = 0;

                AlgorithmState stateTo_display = (AlgorithmState)ComboboxHistoryStep.Items[0];
                FormsHandler.LoadAndDisplayState(stateTo_display);
            }
        }

        /*
        private void dropdownclosed_historysteps(object sender, EventArgs e)
        {
            
        }
        */

        private void ComboboxHistorystepSelectedIndexChanged(object sender, EventArgs e)
        {
            AlgorithmState stateTo_dislay = (AlgorithmState)((ComboBox)sender).SelectedItem;
            FormsHandler.LoadAndDisplayState(stateTo_dislay);
        }

        private void DropdownClosedNumberEpisodes(object sender, EventArgs e)
        {
            
            SetEpisodeFromCombobox(sender, e);
        }

        private void ComboboxHistoryEpisodeKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bool success = Int32.TryParse(ComboboxHistoryEpisode.Text, out int result);
                if (!success || result < 1 || result > ComboboxHistoryEpisode.Items.Count)
                    ComboboxHistoryEpisode.Text = "Invalid.";
                else
                    ComboboxHistoryEpisode.SelectedIndex = result - 1;
            }
        }

        private void ComboboxHistoryStepKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bool success = Int32.TryParse(ComboboxHistoryStep.Text, out int result);
                if (!success || result < 1 || result > ComboboxHistoryStep.Items.Count)
                    ComboboxHistoryStep.Text = "Invalid.";
                else
                {
                    ComboboxHistoryStep.SelectedIndex = result;
                    FormsHandler.LoadAndDisplayState((AlgorithmState)ComboboxHistoryStep.SelectedItem);
                }
                    
            }
        }

        private void ComboboxDelayMsKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bool success = Int32.TryParse(ComboboxDelayMS.Text, out int result);
                if (!success || result < InitialSettings.MsDelay)
                    ComboboxDelayMS.Text = InitialSettings.MsDelay.ToString();
                else
                    ComboboxDelayMS.Text = result.ToString();
            }
        }

        private void CheckBox1Changed(object sender, EventArgs e)
        {
            ComboboxAdvanceSteps.Enabled = !ComboboxAdvanceSteps.Enabled;
            ComboboxAdvanceEpisodes.Enabled = !ComboboxAdvanceEpisodes.Enabled;
        }

        private void ComboboxAdvanceEpisodesSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
