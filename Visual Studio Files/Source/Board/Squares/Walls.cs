using System.Collections.Generic;

namespace ReinforcementLearning
{
    class Walls
    {
        //A wall is a list of one to two moves that reflect which moves the user cannot do at the square that contains this wall.
        //It is one to two moves because the board is an open square, so there are only at most two corners.
        public HashSet<Move> RestrictedMoves;

        public string name;

        public static readonly Walls Top;
        public static readonly Walls Bottom;
        public static readonly Walls Left;
        public static readonly Walls Right;
        public static readonly Walls TopLeft; //top left corner wall
        public static readonly Walls TopRight;
        public static readonly Walls BottomLeft;
        public static readonly Walls BottomRight; //bottom right corner
        public static readonly Walls EmptyWallData;

        static Walls()
        {
            //Three moves here
            Move[] left_moves = new Move[] { Move.Left, Move.UpLeft, Move.DownLeft };
            Move[] right_moves = new Move[] { Move.Right, Move.UpRight, Move.DownRight };
            Move[] up_moves = new Move[] { Move.Up, Move.UpRight, Move.UpLeft };
            Move[] down_moves = new Move[] { Move.Down, Move.DownRight, Move.DownLeft };

            Top = new Walls(up_moves);
            Bottom = new Walls(down_moves);
            Left = new Walls(left_moves);
            Right = new Walls(right_moves);

            //five moves here
            //Topleft
            HashSet<Move> list = new HashSet<Move>();
            list.UnionWith(Top.RestrictedMoves);
            list.UnionWith(Left.RestrictedMoves);
            TopLeft = new Walls(GetArray(list));

            //Topright
            list = new HashSet<Move>();
            list.UnionWith(up_moves);
            list.UnionWith(right_moves);
            TopRight = new Walls(GetArray(list));

            list = new HashSet<Move>();
            list.UnionWith(down_moves);
            list.UnionWith(left_moves);
            BottomLeft = new Walls(GetArray(list));

            list = new HashSet<Move>();
            list.UnionWith(down_moves);
            list.UnionWith(right_moves);
            BottomRight = new Walls(GetArray(list));

            EmptyWallData = new Walls();
        }

        public static void Initialize()
        {

        }

        public Walls()
        {
            RestrictedMoves = new HashSet<Move>(); //Leave the hashset empty
            name = "Empty walls";
        }

        public Walls(Move[] add_from)
        {
            List<Move> present_cardinals = new List<Move>();
            foreach (var i in add_from)
            {
                if(Move.CardinalMoves.Contains(i))
                    present_cardinals.Add(i);
            }

            string wall_name = "";

            foreach(var i in present_cardinals)
            {
                wall_name += i.long_name;
            }

            RestrictedMoves = new HashSet<Move>();
            if (present_cardinals.Count <= 1)
            
                name = "One sided wall: " + wall_name + "]";
            
            else
            
                name = "Two sided wall: " + wall_name + "]";
            
            
            foreach (var i in add_from)
            {
                RestrictedMoves.Add(i);

            }

        }

        private static Move[] GetArray(HashSet<Move> to_search)
        {
            List<Move> to_return = new List<Move>();

            foreach (var i in to_search)
            {
                to_return.Add(i);
            }

            return to_return.ToArray();
        }
        

    }
}
