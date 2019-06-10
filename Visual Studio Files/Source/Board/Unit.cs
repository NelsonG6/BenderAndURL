using System.Collections.Generic;

namespace ReinforcementLearning
{
    //This class represents units on the board that can take actions.
    class Unit
    {
        public string unit_name;
        public PerceptionState perception_data; //Store the percepts for this unit

        public int x_coordinate;
        public int y_coordinate;

        public SquareBoardGame current_location;
        public SquareBoardGame previous_location;

        //Stores our pre-defined unit types

        public HashSet<Move> unit_move_list;

        public static UnitBase bender_data; //base bender
        public static UnitBase url_data; //base url

        public int ID; //Used to keep track in debugging

        public static int next_ID;

        public static HashSet<UnitBase> base_units;
        
        static Unit()
        {
            base_units = new HashSet<UnitBase>();

            bender_data = new UnitBase();
            bender_data.unit_name = "Bender";
            bender_data.unit_move_list = new HashSet<Move>();
            bender_data.unit_move_list.UnionWith(Move.HorizontalMovesAndGrab);
            base_units.Add(bender_data);

            url_data = new UnitBase();
            url_data.unit_name = "Url";
            url_data.unit_move_list = new HashSet<Move>();
            url_data.unit_move_list.UnionWith(Move.AllMoves);
            base_units.Add(url_data);

            next_ID = 0;
        }

        public Unit()
        {
            perception_data = new PerceptionState();
            unit_name = null;

            x_coordinate = -1;
            y_coordinate = -1; //Not placed yet

            current_location = null;
            previous_location = null;

            ID = next_ID++;
        }

        public Unit(Unit set_from)
        {
            x_coordinate = set_from.x_coordinate;
            y_coordinate = set_from.y_coordinate;
            unit_name = set_from.unit_name;
            perception_data = set_from.perception_data;
            current_location = set_from.current_location;
            previous_location = set_from.previous_location;
            unit_move_list = new HashSet<Move>();
            unit_move_list.UnionWith(set_from.unit_move_list);

            ID = next_ID++;
        }

        public PerceptionState get_perception_state()
        {
            return perception_data;
        }

        public Percept get_percept(Move direction_to_check)
        {
            return perception_data.get_percept(direction_to_check);
        }

        static public UnitBase Bender()
        {
            return bender_data;
        }

        static public UnitBase Url()
        {
            return url_data;
        }
    }
}
