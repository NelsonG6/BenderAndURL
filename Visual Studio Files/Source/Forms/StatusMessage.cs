namespace ReinforcementLearning
{
    //A container class for the status message data posted every move
    class StatusMessage
    {
        public static bool programLaunchMessage;

        string completeMessage;

        string startingData;

        string initialPerceptData;

        string moveBeingAppliedData;
        string moveResultData;
        string rewardData;

        string newPerceptData;
        string newPositionData;
        string qmatrixAdjustmentData;
        string endingData;

        string urlData;

        static StatusMessage()
        {
            programLaunchMessage = false;
        }

        public string GetMessage()
        {
            return completeMessage;
        }

        override public string ToString()
        {
            return "Status Message";
        }

        public StatusMessage(AlgorithmState set_from)
        {
            completeMessage = "";
            if (!programLaunchMessage)
            {
                programLaunchMessage = true;
                completeMessage = "The program has been launched.\nBender's starting position is (";
                completeMessage += (set_from.boardData.GetUnitSquare[UnitType.Bender].x + 1).ToString();
                completeMessage += ", " + (set_from.boardData.GetUnitSquare[UnitType.Bender].y + 1).ToString() + ").";
            }
            else if (!AlgorithmState.algorithmStarted)

                completeMessage = "The board was reset. Progress has been erased.";

            //Starting data
            else if (set_from.GetStepNumber() == 0)
            {
                completeMessage = "A new episode has been created.\n";
                completeMessage += "Starting turn [Episode: " + set_from.GetEpisodeNumber().ToString();
                completeMessage += ", Step: " + set_from.GetStepNumber().ToString() + "]";
                completeMessage += " at position (" + (set_from.boardData.GetUnitSquare[UnitType.Bender].x + 1).ToString();
                completeMessage += ", " + (set_from.boardData.GetUnitSquare[UnitType.Bender].y + 1).ToString() + ").";
                completeMessage += System.Environment.NewLine + "Bender's initial perception is:";
                completeMessage += System.Environment.NewLine + set_from.startingPerceptions[UnitType.Bender].ToString() + ".";
            }
            else
            {

                //"Episode #, Step # beginning."
                startingData = "Starting turn [Episode: " + set_from.GetEpisodeNumber().ToString() + ", Step: " + set_from.GetStepNumber().ToString() + "]";
                startingData += " at position (" + (set_from.locationInitial.x + 1).ToString() + ", " + (set_from.locationInitial.y + 1).ToString() + ").";

                initialPerceptData = "Bender's initial perception is: " + System.Environment.NewLine;
                initialPerceptData += set_from.startingPerceptions[UnitType.Bender].ToString();

                moveBeingAppliedData = "";

                if (set_from.liveQmatrix.randomly_moved)
                    moveBeingAppliedData += "A the move was randomly generated." + System.Environment.NewLine;
                else
                    moveBeingAppliedData += "The move was greedily chosen." + System.Environment.NewLine;

                if (set_from.movesThisStep.Count == 0)
                    moveBeingAppliedData += "No move this turn.";
                else if (set_from.movesThisStep[UnitType.Bender] == Move.Grab)
                    moveBeingAppliedData += "A [Grab] was attempted.";
                else
                    moveBeingAppliedData += "A [" + set_from.movesThisStep[UnitType.Bender].long_name + "] was attempted.";

                //moveresult
                if(set_from.resultThisStep != null)
                moveResultData = "The result of the move was [" + set_from.resultThisStep.result_data + "].";

                //The reward from this action was: 
                string math_sign = "+";
                if (set_from.obtainedReward < 0)
                    math_sign = "";
                rewardData = "The reward for this action was: [" + math_sign + set_from.obtainedReward.ToString() + "]";
                //reward_data + = ", applied to state ";
                //Add bender perception data in his new location here

                //"Bender's position is:
                newPositionData = "The resulting position was (" + (set_from.boardData.GetUnitSquare[UnitType.Bender].x + 1).ToString();
                newPositionData += ", " + (set_from.boardData.GetUnitSquare[UnitType.Bender].y + 1).ToString() + ").";

                //New percept

                newPerceptData = "The percept at the new location is: " + System.Environment.NewLine;
                newPerceptData += set_from.boardData.units[UnitType.Bender].perceptionData.ToString() + ".";

                //"The calculation used on the q matrix was:"

                qmatrixAdjustmentData = "No qmatrix entry was made.";
                if (set_from.liveQmatrix.did_we_update)
                    qmatrixAdjustmentData = "A q-matrix entry was made for this perception.";

                if (set_from.movesThisStep.Keys.Count != 0)
                {
                    urlData = "Url made a move of " + set_from.movesThisStep[UnitType.Url].long_name + ".";
                    if (set_from.boardData.units[UnitType.Url].chasing)
                        urlData += System.Environment.NewLine + "Url is chasing bender.";
                    else
                        urlData += System.Environment.NewLine + "Url is wandering randomly.";

                }


                //ending data
                if(set_from.benderAttacked)
                {
                    endingData += "Bender was attacked this turn, and the board was reset.";
                }
                endingData = "Move [" + set_from.GetStepNumber().ToString() + "] complete.";

                string newline = System.Environment.NewLine;

                completeMessage = startingData;
                completeMessage += newline + initialPerceptData;
                completeMessage += newline + moveBeingAppliedData;
                completeMessage += newline + moveResultData;
                completeMessage += newline + rewardData;
                completeMessage += newline + newPositionData;
                completeMessage += newline + newPerceptData;
                completeMessage += newline + urlData;
                completeMessage += newline + qmatrixAdjustmentData;
                completeMessage += newline + endingData;

            }
        }

    }
}
