using System.Collections.Generic;

namespace ReinforcementLearning
{
    class Walls
    {
        //A wall is a list of one to two moves that reflect which moves the user cannot do at the square that contains this wall.
        //It is one to two moves because the board is an open square, so there are only at most two corners.
        public HashSet<Move> restricted_moves;

        public string name;

        private static readonly Walls top_wall_data;
        private static readonly Walls bottom_wall_data;
        private static readonly Walls left_wall_data;
        private static readonly Walls right_wall_data;
        private static readonly Walls top_left_wall_data; //top left corner wall
        private static readonly Walls top_right_wall_data;
        private static readonly Walls bottom_left_wall_data;
        private static readonly Walls bottom_right_wall_data; //bottom right corner
        private static readonly Walls empty_wall_data;

        static Walls()
        {
            top_wall_data = new Walls(Move.Up());
            bottom_wall_data = new Walls(Move.Down());
            left_wall_data = new Walls(Move.Left());
            right_wall_data = new Walls(Move.Right());
            top_left_wall_data = new Walls(new Move[] { Move.Left(), Move.Up(), Move.UpLeft() });
            top_right_wall_data = new Walls(new Move[] { Move.Right(), Move.Up(), Move.UpRight() });
            bottom_left_wall_data = new Walls(new Move[] { Move.Left(), Move.Down(), Move.DownLeft()});
            bottom_right_wall_data = new Walls(new Move[] { Move.Right(), Move.Down(), Move.DownRight() } );
            empty_wall_data = new Walls();
        }

        public static Walls top_wall()
        {
            return top_wall_data;
        }
        public static Walls bottom_wall()
        {
            return bottom_wall_data;
        }
        public static Walls left_wall()
        {
            return left_wall_data;
        }
        public static Walls right_wall()
        {
            return right_wall_data;
        }
        public static Walls top_left_wall()
        {
            return top_left_wall_data;
        }
        public static Walls top_right_wall()
        {
            return top_right_wall_data;
        }
        public static Walls bottom_left_wall()
        {
            return bottom_left_wall_data;
        }
        public static Walls bottom_right_wall()
        {
            return bottom_right_wall_data;
        }
        public static Walls empty_wall()
        {
            return empty_wall_data;
        }

        public Walls()
        {
            restricted_moves = new HashSet<Move>(); //Leave the hashset empty
            name = "Empty walls";
        }

        public Walls(Move move_to_set)
        {
            restricted_moves = new HashSet<Move>();
            restricted_moves.Add(move_to_set);
            name = "One sided wall: " + move_to_set.short_name;
        }

        public Walls(Move [] add_from)
        {
            
            restricted_moves = new HashSet<Move>();
            name = "Two sided wall: " + add_from[add_from.Length-1].long_name + "]";
            foreach (var i in add_from)
            {
                restricted_moves.Add(i);
                
            }
            
            
        }
    }
}
