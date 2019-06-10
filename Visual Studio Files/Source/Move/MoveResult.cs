using System.Collections.Generic;

namespace ReinforcementLearning
{
    //This class handles the types of results we get after applying a move to the board.
    class MoveResult
    {
        public string result_data;

        public static readonly MoveResult CanMissing;
        public static readonly MoveResult CanCollected;
        public static readonly MoveResult MoveSuccessful;
        public static readonly MoveResult MoveFailed;
        public static readonly List<MoveResult> list_of_move_results;

        private static MoveResult initialized_result;

        public MoveResult(string to_set)
        {
            result_data = to_set;
        }

        static MoveResult()
        {
            CanMissing = new MoveResult("Can missing");
            CanCollected = new MoveResult("Can collected");
            MoveSuccessful = new MoveResult("Move successful");
            MoveFailed = new MoveResult("Move failed");

            list_of_move_results = new List<MoveResult>();
            list_of_move_results.Add(CanMissing);
            list_of_move_results.Add(CanCollected);
            list_of_move_results.Add(MoveSuccessful);
            list_of_move_results.Add(MoveFailed);

            initialized_result = new MoveResult("Initialized");
        }
    }
}
