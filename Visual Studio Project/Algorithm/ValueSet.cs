using System.Collections.Generic;

namespace BenderAndURL
{
    //This class is useful for simplifying the q-matrix
    //This class will manage the list of q moves that are associated with each state in the q-matrix.
    //A valueset is a row of the q matrix.
    class ValueSet
    {
        //5 moves with q-matrix double values associated for each one
        public Dictionary<Move, double> MoveList;

        public ValueSet()
        {
            MoveList = new Dictionary<Move, double>();

            //Build a dictionary with 5 moves, by default
            foreach(var i in Move.HorizontalMovesAndGrab)
            {
                MoveList.Add(i, 0f);
            }
        }

        public ValueSet(ValueSet setFrom)
        {
            MoveList = new Dictionary<Move, double>();
            foreach (var i in setFrom.MoveList)
            {
                MoveList.Add(i.Key, i.Value);
            }
        }

        public double GetBestValue()
        {
            double toReturn = 0;
            foreach (var i in MoveList.Values)
            {
                if (i > toReturn)
                    toReturn = i;
            }
            return toReturn;
        }

        public double this[Move key]
        {
            get
            {
                return GetValue(key);
            }
            set
            {
                SetValue(key, value);
            }

        }

        public double GetValue(Move index)
        {
            return MoveList[index];
        }

        public void SetValue(Move index, double value)
        {
            MoveList[index] = value;
        }
    }
}
