namespace BenderAndURL
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

        static public StatusMessage ErasedMessage;

        static StatusMessage()
        {
            programLaunchMessage = false;
            ErasedMessage = new StatusMessage();
            ErasedMessage.completeMessage = "The board has been reset.";           
        }

        public StatusMessage() { }

        public string GetMessage()
        {
            return completeMessage;
        }

        override public string ToString()
        {
            return "Status Message";
        }

        public StatusMessage(AlgorithmState setFrom)
        {

            string newline = System.Environment.NewLine;

            completeMessage = "";
            if (!programLaunchMessage)
            {
                programLaunchMessage = true;
                completeMessage = "The program has been launched.\nBender's starting position is (";
                completeMessage += (setFrom.BoardData.GetUnitSquare[UnitType.Bender].x + 1).ToString();
                completeMessage += ", " + (setFrom.BoardData.GetUnitSquare[UnitType.Bender].y + 1).ToString() + ").";
            }
            else if (!AlgorithmManager.AlgorithmStarted)

                completeMessage = "The board was reset. Progress has been erased.";

            //Starting data
            else if (setFrom.GetStepNumber() == 0)
            {
                completeMessage = "A new episode has been created.\n";
                completeMessage += "Starting turn [Episode: " + setFrom.GetEpisodeNumber().ToString();
                completeMessage += ", Step: " + setFrom.GetStepNumber().ToString() + "]";
                completeMessage += " at position (" + (setFrom.BoardData.GetUnitSquare[UnitType.Bender].x + 1).ToString();
                completeMessage += ", " + (setFrom.BoardData.GetUnitSquare[UnitType.Bender].y + 1).ToString() + ").";

                foreach(var unit in UnitType.List)
                {
                    completeMessage += System.Environment.NewLine + unit.unitName + "'s initial perception is:";
                    completeMessage += System.Environment.NewLine + setFrom.GetPerception(unit).ToString() + ".";
                }
            }
            else
            {
                //"Episode #, Step # beginning."
                startingData = "Starting turn [Episode: " + setFrom.GetEpisodeNumber().ToString() + ", Step: " + setFrom.GetStepNumber().ToString() + "]";
                startingData += " at position (" + (setFrom.LocationInitial.x + 1).ToString() + ", " + (setFrom.LocationInitial.y + 1).ToString() + ").";

                initialPerceptData = "Bender's initial perception is: " + System.Environment.NewLine;
                initialPerceptData += setFrom.GetPerception(UnitType.Bender).ToString();

                moveBeingAppliedData = "";

                if (setFrom.LiveQmatrix.randomlyMoved)
                    moveBeingAppliedData += "A the move was randomly generated." + System.Environment.NewLine;
                else
                    moveBeingAppliedData += "The move was greedily chosen." + System.Environment.NewLine;

                //if (setFrom.movesThisStep.Count == 0)
                //    moveBeingAppliedData += "No move this turn.";
                if (setFrom.GetUnit(UnitType.Bender).GetMoveThisStep() == Move.Grab)
                    moveBeingAppliedData += "A [Grab] was attempted.";
                else
                    moveBeingAppliedData += "A [" + setFrom.GetUnit(UnitType.Bender).GetMoveThisStep().longName + "] was attempted.";

                //moveresult
                if(setFrom.ResultThisStep != null)
                moveResultData = "The result of the move was [" + setFrom.ResultThisStep.Description + "].";

                //The reward from this action was: 
                string math_sign = "+";
                if (setFrom.ObtainedReward < 0)
                    math_sign = "";
                rewardData = "The reward for this action was: [" + math_sign + setFrom.ObtainedReward.ToString() + "]";
                //reward_data + = ", applied to state ";
                //Add bender perception data in his new location here

                //"Bender's position is:
                newPositionData = "The resulting position was (" + (setFrom.BoardData.GetUnitSquare[UnitType.Bender].x + 1).ToString();
                newPositionData += ", " + (setFrom.BoardData.GetUnitSquare[UnitType.Bender].y + 1).ToString() + ").";

                //New percept

                newPerceptData = "The percept at the new location is: " + System.Environment.NewLine;
                newPerceptData += setFrom.BoardData.Units[UnitType.Bender].PerceptionData.ToString() + ".";

                //"The calculation used on the q matrix was:"

                qmatrixAdjustmentData = "No qmatrix entry was made.";
                if (setFrom.LiveQmatrix.didWeUpdate)
                    qmatrixAdjustmentData = "A q-matrix entry was made for this perception.";

                urlData = "Url made a move of " + setFrom.GetUnit(UnitType.Url).GetMoveThisStep().longName + ".";

                if(setFrom.UrlRandomlyStopped)
                {
                    urlData += newline + "Url randomly hit his change to stop chasing this turn.";
                }

                if (setFrom.StartedChasing)
                    urlData += newline + "Url started chasing Bender.";
                else if (setFrom.BoardData.Units[UnitType.Url].chasing)
                        urlData += System.Environment.NewLine + "Url is chasing bender.";
                else
                        urlData += System.Environment.NewLine + "Url is wandering randomly.";


                //ending data
                if (setFrom.BenderAttacked)
                    endingData += "Bender was attacked this turn, and the board was reset." + newline;
                endingData += "Move [" + setFrom.GetStepNumber().ToString() + "] complete.";

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
