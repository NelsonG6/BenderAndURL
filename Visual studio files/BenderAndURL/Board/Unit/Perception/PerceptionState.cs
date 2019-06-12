using System;
using System.Collections.Generic;
using System.Linq;

namespace BenderAndURL
{
    //a state is a pairing of all possible moves (5) and their percepts
    //This is a state in the sense of, what state is bender in when he perceives his environment
    class PerceptionState : IEquatable<PerceptionState>
    {
        public SortedDictionary<Move, Percept> perceptionData;

        public string name_without_id;
        public string name_with_id;

        public int ID;

        //Dumb, but it lets you access the static and persistent perception state
        //By passing in one that you built with equal properties.

        private static int IDCount;

        //Constructor called for when we are detecteing a state in the wild, and want to start corresponding it
        //to the static type.
        public PerceptionState(UnitType useMovelist)
        {
            perceptionData = new SortedDictionary<Move, Percept>();
            foreach(var i in useMovelist.PerceptionCauses)
            {
                perceptionData.Add(i, Percept.Initialized);
            }

            ID = IDCount++;

            setName();
        }

        public bool Equals(PerceptionState toCheck)
        {
            foreach(var i in perceptionData.Keys)
            {
                if (perceptionData[i] != toCheck.perceptionData[i])
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return name_without_id.GetHashCode();
        }

        public bool does_dictionaryMatch(Dictionary<Move, Percept> toCheck)
        {
            foreach(var i in toCheck)
            {
                if (i.Value != perceptionData[i.Key])
                    return false;
            }
            return true;
        }

        public Percept getPercept(Move perceptionCause)
        {
            return perceptionData[perceptionCause];
        }

        public PerceptionState(PerceptionState copyFrom)
        {
            perceptionData = new SortedDictionary<Move, Percept>();
            foreach (var i in copyFrom.perceptionData)
            {
                perceptionData.Add(i.Key, i.Value);
            }
        }

        public void setName()
        {
            string part_one = "[ID: " + ID.ToString() + "]";

            string partTwo = "";

            foreach (var i in perceptionData.Keys.OrderBy(o => o.order))
            {
                partTwo += "[" + i.shortName + ": " + perceptionData[i].ToString() + "]";
            }

            name_with_id = part_one + partTwo;
            name_without_id = partTwo;

        }

        public void set_id(int to_set)
        {
            ID = to_set;
        }

        public override string ToString()
        {
            return name_with_id;
        }

        public int compare(PerceptionState compareTo)
        {
            int compareTotal = 0;
            foreach (var i in Move.HorizontalMovesAndGrab)
            {
                if (perceptionData[i] == compareTo.perceptionData[i])
                    compareTotal++;
            }
            return compareTotal;
        }

        public bool contains(Move move, Percept percept)
        {
            if (perceptionData[move] == percept)
                return true;
            return false;
        }
    }
}
