namespace BenderAndURL
{
    //This class handles the types of results we get after applying a move to the board.
    class MoveResult
    {
        public string Description;
        public double Value;

        public static readonly MoveResult CanMissing;
        public static readonly MoveResult CanCollected;
        public static readonly MoveResult TravelSucceeded;
        public static readonly MoveResult TravelFailed;
        public static readonly MoveResult EnemyEncountered;        

        //private static MoveResult initialized_result;

        public MoveResult(string descriptionToSet, double valueToSet)
        {
            Description = descriptionToSet;
            Value = valueToSet;
        }

        override public string ToString()
        {
            return Description;
        }

        static MoveResult()
        {
            CanMissing = new MoveResult("Can missing", -10);
            CanCollected = new MoveResult("Can collected", 10);
            TravelSucceeded = new MoveResult("Move successful", 0);
            TravelFailed = new MoveResult("Move failed", -10);
            EnemyEncountered = new MoveResult("Enemey encountered", -10);            
        }
    }
}
