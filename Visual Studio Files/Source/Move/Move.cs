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

        public readonly static Move Left;
        public readonly static Move Right;
        public readonly static Move Up;
        public readonly static Move Down;
        public readonly static Move Grab;
        public readonly static Move UpLeft;
        public readonly static Move UpRight;
        public readonly static Move DownLeft;
        public readonly static Move DownRight;
        public readonly static Move Wait;

        public readonly static List<Move> HorizontalMovesAndGrab;

        public readonly static List<Move> AllMoves;

        public readonly static List<Move> CardinalMoves;

        public readonly static List<Move> Diagonals;

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

            Diagonals = new List<Move>();

            Left = new Move();
            Left.grid_adjustment[0] = -1;
            Left.grid_adjustment[1] = 0;
            Left.to_grab = false;
            Left.short_name = "L";
            Left.long_name = "Left";
            Left.order = ++move_order;

            Right = new Move();
            Right.grid_adjustment[0] = 1;
            Right.grid_adjustment[1] = 0;
            Right.to_grab = false;
            Right.short_name = "R";
            Right.long_name = "Right";
            Right.order = ++move_order;

            Down = new Move();
            Down.grid_adjustment[0] = 0;
            Down.grid_adjustment[1] = -1;
            Down.to_grab = false;
            Down.short_name = "D";
            Down.long_name = "Down";
            Down.order = ++move_order;

            Up = new Move();
            Up.grid_adjustment[0] = 0;
            Up.grid_adjustment[1] = 1;
            Up.to_grab = false;
            Up.short_name = "Up";
            Up.long_name = "Up";
            Up.order = ++move_order;

            Grab = new Move();
            Grab.grid_adjustment[0] = 0;
            Grab.grid_adjustment[1] = 0;
            Grab.to_grab = true;
            Grab.short_name = "Gr";
            Grab.long_name = "Grab";
            Grab.order = ++move_order;

            UpLeft = new Move();
            UpLeft.grid_adjustment[0] = -1;
            UpLeft.grid_adjustment[1] = 1;
            UpLeft.to_grab = false;
            UpLeft.short_name = "UL";
            UpLeft.long_name = "Up-Left";
            UpLeft.order = ++move_order;

            UpRight = new Move();
            UpRight.grid_adjustment[0] = 1;
            UpRight.grid_adjustment[1] = 1;
            UpRight.to_grab = true;
            UpRight.short_name = "UR";
            UpRight.long_name = "Up-Right";
            UpRight.order = ++move_order;

            DownLeft = new Move();
            DownLeft.grid_adjustment[0] = -1;
            DownLeft.grid_adjustment[1] = -1;
            DownLeft.to_grab = true;
            DownLeft.short_name = "DL";
            DownLeft.long_name = "Down-Left";
            DownLeft.order = ++move_order;

            DownRight = new Move();
            DownRight.grid_adjustment[0] = 1;
            DownRight.grid_adjustment[1] = -1;
            DownRight.to_grab = true;
            DownRight.short_name = "DR";
            DownRight.long_name = "Down-Right";
            DownRight.order = ++move_order;

            HorizontalMovesAndGrab = new List<Move>();
            CardinalMoves = new List<Move>();

            CardinalMoves.Add(Left);
            CardinalMoves.Add(Right);
            CardinalMoves.Add(Up);
            CardinalMoves.Add(Down);

            HorizontalMovesAndGrab.AddRange(CardinalMoves);
            HorizontalMovesAndGrab.Add(Grab);

            AllMoves = new List<Move>();
            AllMoves.AddRange(HorizontalMovesAndGrab.ToArray());
            AllMoves.Add(UpLeft);
            AllMoves.Add(UpRight);
            AllMoves.Add(DownLeft);
            AllMoves.Add(DownRight);

            Wait = new Move();
            Wait.grid_adjustment[0] = 0;
            Wait.grid_adjustment[1] = 0;
            Wait.to_grab = false;
            Wait.short_name = "W";
            Wait.long_name = "Wait";
            Wait.order = ++move_order;

            Diagonals.Add(UpLeft);
            Diagonals.Add(UpRight);
            Diagonals.Add(DownLeft);
            Diagonals.Add(DownRight);
        }

        public static void Initialize()
        {

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
