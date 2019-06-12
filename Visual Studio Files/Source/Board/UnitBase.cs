using System.Collections.Generic;

namespace ReinforcementLearning
{

    //This class represents units on the board that can take actions.
    //This is used for individual instances of the units, for tracking in history and debugging
    class UnitBase
    {
        public PerceptionState perceptionData; //Store the percepts for this unit

        public SquareBoardGame currentLocation;
        public SquareBoardGame previousLocation;

        public bool chasing; //for url

        public string unitName;

        public UnitType enemy;

        public int ID; //Used to keep track in debugging
    
        public UnitBase(UnitBase setFrom)
        {            
            unitName = setFrom.unitName;
            perceptionData = setFrom.perceptionData;
            currentLocation = setFrom.currentLocation;
            previousLocation = setFrom.previousLocation;

            enemy = setFrom.enemy;
            ID = setFrom.ID++;
            chasing = setFrom.chasing;
        }

        public UnitBase()
        {

        }

        public PerceptionState get_perception_state()
        {
            return perceptionData;
        }

        public Percept get_percept(Move directionToCheck)
        {
            return perceptionData.get_percept(directionToCheck);
        }

        override public string ToString()
        {
            return unitName;
        }
    }
}
