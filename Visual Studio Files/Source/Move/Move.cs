using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforcementLearning
{
    //Moves in this program created from this object:
    //4 movements with grab false
    //one no-movement with grab true

    class Move : IComparable<Move>, IEqualityComparer<Move>
    {   //This class defines the moves bender can make.
        public int[] grid_adjustment; //The motion bender makes from this movement

        readonly static Move left_move;
        readonly static Move right_move;
        readonly static Move up_move;
        readonly static Move down_move;
        readonly static Move grab_move;
        readonly static Move up_left_move;
        readonly static Move up_right_move;
        readonly static Move down_left_move;
        readonly static Move down_right_move;

        public readonly static List<Move> HorizontalMovesAndGrab;

        public readonly static List<Move> AllMoves;

        public bool to_grab; //determines if we grab the can. This is done after the move step.
        //public string name_of_move; //The description of the move, which is used to translate this move into actions when the result isn't movement-based.'
        //Grab is a non-movement based move, in this case.

        public string short_name; //Shorthand name of move
        public string long_name; //Used for the status box display

        public int order; //This is the order we display the boxes in, and the order we encode the state as

        static Move()
        {
            //These should be the only instances of moves created in the program
            //Q moves will be generated frequently, however
            int move_order = 0;

            left_move = new Move();
            left_move.grid_adjustment[0] = -1;
            left_move.grid_adjustment[1] = 0;
            left_move.to_grab = false;
            left_move.short_name = "L";
            left_move.long_name = "Left";
            left_move.order = ++move_order;

            right_move = new Move();
            right_move.grid_adjustment[0] = 1;
            right_move.grid_adjustment[1] = 0;
            right_move.to_grab = false;
            right_move.short_name = "R";
            right_move.long_name = "Right";
            right_move.order = ++move_order;

            down_move = new Move();
            down_move.grid_adjustment[0] = 0;
            down_move.grid_adjustment[1] = -1;
            down_move.to_grab = false;
            down_move.short_name = "D";
            down_move.long_name = "Down";
            down_move.order = ++move_order;

            up_move = new Move();
            up_move.grid_adjustment[0] = 0;
            up_move.grid_adjustment[1] = 1;
            up_move.to_grab = false;
            up_move.short_name = "Up";
            up_move.long_name = "Up";
            up_move.order = ++move_order;

            grab_move = new Move();
            grab_move.grid_adjustment[0] = 0;
            grab_move.grid_adjustment[1] = 0;
            grab_move.to_grab = true;
            grab_move.short_name = "Gr";
            grab_move.long_name = "Grab";
            grab_move.order = ++move_order;

            up_left_move = new Move();
            up_left_move.grid_adjustment[0] = -1;
            up_left_move.grid_adjustment[1] = 1;
            up_left_move.to_grab = false;
            up_left_move.short_name = "UL";
            up_left_move.long_name = "Up-Left";
            up_left_move.order = ++move_order;

            up_right_move = new Move();
            up_right_move.grid_adjustment[0] = 1;
            up_right_move.grid_adjustment[1] = 1;
            up_right_move.to_grab = true;
            up_right_move.short_name = "UR";
            up_right_move.long_name = "Up-Right";
            up_right_move.order = ++move_order;

            down_left_move = new Move();
            down_left_move.grid_adjustment[0] = -1;
            down_left_move.grid_adjustment[1] = -1;
            down_left_move.to_grab = true;
            down_left_move.short_name = "DL";
            down_left_move.long_name = "Down-Left";
            down_left_move.order = ++move_order;

            down_right_move = new Move();
            down_right_move.grid_adjustment[0] = 1;
            down_right_move.grid_adjustment[1] = -1;
            down_right_move.to_grab = true;
            down_right_move.short_name = "DR";
            down_right_move.long_name = "Down-Right";
            down_right_move.order = ++move_order;

            HorizontalMovesAndGrab = new List<Move>();

            HorizontalMovesAndGrab.Add(left_move);
            HorizontalMovesAndGrab.Add(right_move);
            HorizontalMovesAndGrab.Add(up_move);
            HorizontalMovesAndGrab.Add(down_move);
            HorizontalMovesAndGrab.Add(grab_move);

            AllMoves = new List<Move>();
            AllMoves.AddRange(HorizontalMovesAndGrab.ToArray());
            AllMoves.Add(up_left_move);
            AllMoves.Add(up_right_move);
            AllMoves.Add(down_left_move);
            AllMoves.Add(down_right_move);

        }

        public static Move UpLeft()
        {
            return up_left_move;
        }

        public static Move UpRight()
        {
            return up_right_move;
        }

        public static Move DownLeft()
        {
            return down_left_move;
        }

        public static Move DownRight()
        {
            return down_right_move;
        }

        public static Move Left()
        {
            return left_move;
        }

        public static Move Right()
        {
            return right_move;
        }

        public static Move Up()
        {
            return up_move;
        }

        public static Move Down()
        {
            return down_move;
        }

        public static Move Grab()
        {
            return grab_move;
        }

        public static List<Move> GetHorizontalMovesAndGrab()
        {
            return HorizontalMovesAndGrab;
        }

        //might not need this constructor
        public Move()
        {
            grid_adjustment = new int[2] { 0, 0 };
            short_name = "Initialized and not set";
            long_name = "Initialized and not set";
        }

        public Move(Move set_from)
        {
            grid_adjustment[0] = set_from.grid_adjustment[0];
            grid_adjustment[1] = set_from.grid_adjustment[1];

            short_name = set_from.short_name;
        }

        public int CompareTo(Move compare_from)
        {
            return long_name.CompareTo(compare_from.long_name);
        }

        override public string ToString()
        {
            return long_name;
        }

        public bool Equals(Move first, Move second)
        {
            if (first.GetHashCode() == second.GetHashCode())
                return true;
            return false;
        }

        public int GetHashCode(Move check)
        {
            return check.long_name.GetHashCode();
        }
    }
}
