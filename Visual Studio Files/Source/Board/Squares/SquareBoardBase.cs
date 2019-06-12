using System.Collections.Generic;
using System.Linq;


namespace ReinforcementLearning
{
    class SquareBoardBase
    {
        //The class for storing the data relevant for each square

        public bool beer_can_present;

        //This will only store Unit.Bender and unit.Url, no instances that are on the board
        public Dictionary<UnitBase, bool> UnitsPresent; //A list of units we contain in this square
        //Even though only one unit is possible at a time, this is necessary so we can store a presence value for either unit.

        public SquareVisitedState visited_state; //Using a string to store one of three values: last move, Unexplored, explored

        public int x;
        public int y;

        public SquareBoardBase(int set_x, int set_y)
        {
            visited_state = SquareVisitedState.Unexplored; //Deafult

            //Initialize units present
            UnitsPresent = new Dictionary<UnitBase, bool>();
            foreach(var i in UnitType.BaseUnits)
            {
                UnitsPresent.Add(i, false);
            }

            x = set_x;
            y = set_y;
        }

        public SquareBoardBase(SquareBoardBase set_from)
        {
            copy_status(set_from);
        }

        //Pretty sure this isn't necessary since a constructor can just do this
        public void copy_status(SquareBoardBase copy_from)
        {
            UnitsPresent = new Dictionary<UnitBase, bool>();
            foreach (var i in copy_from.UnitsPresent)
            {
                UnitsPresent.Add(i.Key, i.Value);
            }

            visited_state = copy_from.visited_state;
            beer_can_present = copy_from.beer_can_present;
            x = copy_from.x;
            y = copy_from.y;
        }
    }
}
