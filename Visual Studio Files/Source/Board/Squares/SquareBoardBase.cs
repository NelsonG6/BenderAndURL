using System.Collections.Generic;
using System.Linq;


namespace ReinforcementLearning
{
    class SquareBoardBase
    {
        //The class for storing the data relevant for each square

        public bool beer_can_present;

        //This will only store Unit.bender() and unit.url(), no instances that are on the board
        public Dictionary<Unit, bool> units_present; //A list of units we contain in this square
        //Even though only one unit is possible at a time, this is necessary so we can store a presence value for either unit.

        public SquareVisitedState visited_state; //Using a string to store one of three values: last move, unexplored, explored

        public SquareBoardBase()
        {
            visited_state = SquareVisitedState.unexplored(); //Deafult
            units_present = new Dictionary<Unit, bool>();
            foreach(var i in Unit.base_units)
            {
                units_present.Add(i, false);
            }
    }

        public SquareBoardBase(SquareBoardBase set_from)
        {
            copy_status(set_from);
        }

        //Pretty sure this isn't necessary since a constructor can just do this
        public void copy_status(SquareBoardBase copy_from)
        {
            units_present = new Dictionary<Unit, bool>();
            foreach (var i in copy_from.units_present)
            {
                units_present.Add(i.Key, i.Value);
            }

            visited_state = copy_from.visited_state;
            beer_can_present = copy_from.beer_can_present;
        }
    }
}
