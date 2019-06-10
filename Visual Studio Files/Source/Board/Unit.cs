using System.Collections.Generic;

namespace ReinforcementLearning
{
    /*
     
     *      If I need to give each unit their own perception list later:
     *      
     *      bender_data.percept_list = new HashSet<Percept>();
            bender_data.percept_list.Add(Percept.Enemey());
            bender_data.percept_list.Add(Percept.Wall());
            bender_data.percept_list.Add(Percept.Can());
            bender_data.percept_list.Add(Percept.Empty());

            url_data.percept_list = new HashSet<Percept>();
            url_data.percept_list.Add(Percept.Enemey());
            url_data.percept_list.Add(Percept.Wall());
            url_data.percept_list.Add(Percept.Can());
            url_data.percept_list.Add(Percept.Empty());
    */

    //This class represents units on the board that can take actions.
    class Unit
    {
        public string unit_name;
        public PerceptionState perception_data; //Store the percepts for this unit

        public SquareBoardGame current_location;
        public SquareBoardGame previous_location;

        //Stores our pre-defined unit types
        public HashSet<Move> unit_move_list;

        public int ID; //Used to keep track in debugging

        public static int next_ID;

        public static readonly HashSet<UnitBase> base_units; //A list of units

        public static readonly UnitBase Bender;
        public static readonly UnitBase Url;

        public HashSet<Move> PerceptionCauses; //A list of the moves that the unit uses to get his perception

        public static bool Initialize()
        {
            return true;
        }

        static Unit()
        {
            base_units = new HashSet<UnitBase>();
            Bender = new UnitBase();
            Bender.unit_name = "Bender";
            Bender.unit_move_list = new HashSet<Move>();
            Bender.unit_move_list.UnionWith(Move.HorizontalMovesAndGrab);
            Bender.PerceptionCauses = new HashSet<Move>();
            Bender.PerceptionCauses.UnionWith(Move.AllMoves); //Perception comes from any of the 9 possible moves
            base_units.Add(Bender);

            Url = new UnitBase();
            Url.unit_name = "Url";
            Url.unit_move_list = new HashSet<Move>();
            Url.unit_move_list.UnionWith(Move.AllMoves);
            Url.PerceptionCauses = new HashSet<Move>();//perception is caused by any of the 9 possible moves
            Url.PerceptionCauses.UnionWith(Move.AllMoves); //perception is caused by any of the 9 possible moves
            base_units.Add(Url);

            next_ID = 0;


        }


        public Unit()
        {
            perception_data = null;
            unit_name = null;            

            current_location = null;
            previous_location = null;

            ID = next_ID++;
        }

        public Unit(Unit set_from)
        {            
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

        override public string ToString()
        {
            return unit_name;
        }
    }
}
