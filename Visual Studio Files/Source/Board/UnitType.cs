using System.Collections.Generic;

namespace ReinforcementLearning
{
    //I think this is necessary to help enforce the baseunit type on some calls and dictionary-dereferences
    //This is a type class for each unit
    class UnitType : UnitBase
    {
        public HashSet<Move> PerceptionCauses; //A list of the moves that the unit uses to get his perception

        //Stores all our pre-defined unit moves
        public HashSet<Move> unit_move_list;

        public string type_name;

        public static readonly HashSet<UnitType> base_units; //A list of units

        public static readonly UnitType Bender;
        public static readonly UnitType Url;

        static UnitType()
        {
            base_units = new HashSet<UnitType>();
            Bender = new UnitType();
            Bender.unit_name = "Bender";
            Bender.type_name = "Bender";
            Bender.unit_move_list = new HashSet<Move>();
            Bender.unit_move_list.UnionWith(Move.HorizontalMovesAndGrab);
            Bender.PerceptionCauses = new HashSet<Move>();
            Bender.PerceptionCauses.UnionWith(Move.AllMoves); //Perception comes from any of the 9 possible moves
            base_units.Add(Bender);

            Url = new UnitType();
            Url.unit_name = "Url";
            Url.type_name = "Url";
            Url.enemy = Bender;
            Url.unit_move_list = new HashSet<Move>();
            Url.unit_move_list.UnionWith(Move.AllMoves);
            Url.PerceptionCauses = new HashSet<Move>();//perception is caused by any of the 9 possible moves
            Url.PerceptionCauses.UnionWith(Move.AllMoves); //perception is caused by any of the 9 possible moves
            base_units.Add(Url);

            Bender.enemy = Url;
        }

        public override string ToString()
        {
            return "Static " + base.ToString();

        }

        


    }
}
