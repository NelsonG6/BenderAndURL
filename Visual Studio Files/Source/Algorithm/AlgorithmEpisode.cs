using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforcementLearning
{
    class AlgorithmEpisode
    {
        public List<AlgorithmState> stateHistoryData;

        public int episodeNumber;

        public AlgorithmEpisode(int setEpisode)
        {
            stateHistoryData = new List<AlgorithmState>();
            episodeNumber = setEpisode;
        }

        override public string ToString()
        {
            return "[Episode #" + episodeNumber.ToString() + "]";
        }

        //Should allow indexing
        public AlgorithmState this[int i]
        {
            get { return stateHistoryData[i]; }
            set { stateHistoryData[i] = value; }
        }

        public int Count()
        {
            return stateHistoryData.Count;
        }

        public void Add(AlgorithmState to_add)
        {
            stateHistoryData.Add(to_add);
        }

        public AlgorithmState[] ToArray()
        {
            return stateHistoryData.ToArray();
        }
    }
}
