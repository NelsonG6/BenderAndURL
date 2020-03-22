using System;
using System.Collections.Generic;
using System.Linq;

namespace BenderAndURL
{
    //a state is a pairing of all possible moves (5) and their percepts
    //This is a state in the sense of, what state is bender in when he perceives his environment
    class PerceptionState : IEquatable<PerceptionState>
    {
        public SortedDictionary<Move, Percept> PerceptionData;

        public string name_without_id;
        public string nameWithId;

        public int ID;

        //Dumb, but it lets you access the static and persistent perception state
        //By passing in one that you built with equal properties.

        private static int IDCount;

        //Constructor called for when we are detecteing a state in the wild, and want to start corresponding it
        //to the static type.
        public PerceptionState(UnitType useMovelist)
        {
            PerceptionData = new SortedDictionary<Move, Percept>();
            foreach(var i in useMovelist.PerceptionCauses)
            {
                PerceptionData.Add(i, Percept.Initialized);
            }

            ID = IDCount++;

            SetName();
        }

        public bool Equals(PerceptionState toCheck)
        {
            foreach(var i in PerceptionData.Keys)
            {
                if (PerceptionData[i] != toCheck.PerceptionData[i])
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return name_without_id.GetHashCode();
        }

        public bool DoesDictionaryMatch(Dictionary<Move, Percept> toCheck)
        {
            foreach(var i in toCheck)
            {
                if (i.Value != PerceptionData[i.Key])
                    return false;
            }
            return true;
        }

        public Percept GetPercept(Move perceptionCause)
        {
            return PerceptionData[perceptionCause];
        }

        public PerceptionState(PerceptionState copyFrom)
        {
            PerceptionData = new SortedDictionary<Move, Percept>();
            foreach (var i in copyFrom.PerceptionData)
            {
                PerceptionData.Add(i.Key, i.Value);
            }
        }

        public void SetName()
        {
            string part_one = "[ID: " + ID.ToString() + "]";

            string partTwo = "";

            foreach (var i in PerceptionData.Keys.OrderBy(o => o.order))
            {
                partTwo += "[" + i.shortName + ": " + PerceptionData[i].ToString() + "]";
            }

            nameWithId = part_one + partTwo;
            name_without_id = partTwo;

        }

        public void SetId(int to_set)
        {
            ID = to_set;
        }

        public override string ToString()
        {
            return nameWithId;
        }

        public int Compare(PerceptionState compareTo)
        {
            int compareTotal = 0;
            foreach (var i in Move.HorizontalMovesAndGrab)
            {
                if (PerceptionData[i] == compareTo.PerceptionData[i])
                    compareTotal++;
            }
            return compareTotal;
        }

        public bool Contains(Move move, Percept percept)
        {
            if (PerceptionData[move] == percept)
                return true;
            return false;
        }
    }
}
