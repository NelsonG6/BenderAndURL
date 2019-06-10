using System.Collections.Generic;

namespace ReinforcementLearning
{

    //This class represents units on the board that can take actions.
    //This is used for individual instances of the units, for tracking in history and debugging
    class UnitBase
    {
        public PerceptionState perception_data; //Store the percepts for this unit

        public SquareBoardGame current_location;
        public SquareBoardGame previous_location;

        public bool chasing; //for url

        public string unit_name;

        public UnitType enemy;

        public int ID; //Used to keep track in debugging
    
        public UnitBase(UnitBase set_from)
        {            
            unit_name = set_from.unit_name;
            perception_data = set_from.perception_data;
            current_location = set_from.current_location;
            previous_location = set_from.previous_location;

            enemy = set_from.enemy;
            ID = set_from.ID++;
            chasing = set_from.chasing;
        }

        public UnitBase()
        {

        }

        public PerceptionState get_perception_state()
        {
            return perception_data;
        }

        public Percept get_percept(Move direction_to_check)
        {
            return perception_data.get_percept(direction_to_check);
        }

        override public string ToString()
        {
            return unit_name;
        }
    }
}
