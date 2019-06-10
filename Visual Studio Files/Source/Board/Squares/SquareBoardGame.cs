namespace ReinforcementLearning
{
    //This version of SquareBase will have walls
    class SquareBoardGame : SquareBoardBase
    {
        //This stores the wall data for the square
        //It will determine if there is one wall, two walls, or no walls. Only a single wall object is needed.
        public Walls walls;

        public SquareBoardGame(int x, int y) : base(x, y)
        {
            walls = null;
        }

        //Boardsquare cannot be constructed from a SquareBase, because it will lose its walls.

        public SquareBoardGame(SquareBoardGame set_from) : base(set_from)
        {
            walls = set_from.walls;
        }

        public bool CheckIfWallsPreventMove(Move move_to_check)
        {
            //Check walls
            foreach (var i in walls.RestrictedMoves)
            {
                if (i == move_to_check)
                    return true;
            }

            return false;
        }

        public void copy_status(SquareBoardGame copy_from)
        {
            copy_status((SquareBoardBase)copy_from);
            walls = copy_from.walls;
        }

        public void randomize_beer_presence()
        {
            if (MyRandom.Next(1, 101) < 50)
                beer_can_present = true;
            else
                beer_can_present = false;
        }
    }
}
