using System;
using System.Collections.Generic;
using System.Linq;
namespace BenderAndURL
{
    //This handles the reference point for all fields in the program that are defaults
    static class InitialSettings
    {
        //Q-matrix
        public readonly static double Eta; //learning rate
        public readonly static double Gamma; //discount
        public readonly static double Epsilon; //random factor

        public readonly static int EpisodeLimit;
        public readonly static int StepLimit;

        public readonly static int MsDelay;

        public static readonly int XOffset;
        public static readonly int YOffset;
        public static readonly int EdgeLength;
        public static readonly int RoundingDigitRate;
        public static readonly int SizeOfBoard;

        public static readonly int CanMissingReward;
        public static readonly int CanGrabbedReward;
        public static readonly int MoveSuccessfulReward;
        public static readonly int MoveFailedReward;
        public static readonly int EnemyEncountered;

        public static readonly int URLStopsChasingChance;

        static InitialSettings()
        {
            Eta = .1F; //Epsilon; do we explore or exploit. Random factor for taking a best move or random move.
            Gamma = .9F; //Gamma; our discounted rate.
            Epsilon = .2F; //The learning rate

            //Default limit
            EpisodeLimit = 5000;
            StepLimit = 200;

            //reinforcement factors
            MsDelay = 5;

            XOffset = 50;
            YOffset = 55;
            EdgeLength = 75;
            RoundingDigitRate = 5;

            SizeOfBoard = 10;

            CanMissingReward = -1;
            CanGrabbedReward = 10;
            MoveSuccessfulReward = 0;
            MoveFailedReward = -5;
            EnemyEncountered = -20;

            URLStopsChasingChance = 5;
    }

        //initialize all static classes here
        static public void Initialize()
        {
           
           
           
            

        }
    }

}
