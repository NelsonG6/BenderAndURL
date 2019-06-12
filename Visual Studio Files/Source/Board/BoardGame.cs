using System.Collections.Generic;

namespace ReinforcementLearning
{
    //Manages a few different classes
    class BoardGame : BoardBase 
    {
        public Dictionary<UnitType, SquareBoardGame> GetUnitSquare;

        //This units on the board
        public Dictionary<UnitType, UnitBase> units;

        public BoardGame() : base()
        {
            //Initialize 10x10 grid
            int x = 0;
            int y = 0;

            //Bender location will be set in shuffle
            units = new Dictionary<UnitType, UnitBase>();
            units.Add(UnitType.Bender, new UnitBase(UnitType.Bender));
            units.Add(UnitType.Url, new UnitBase(UnitType.Url));

            foreach (var i in board_data)
            {
                y = 0;
                while (i.Count < InitialSettings.SizeOfBoard)
                {
                    i.Add(new SquareBoardGame(x, y++));
                }
                x++;
            }

            AddWalls();

            GetUnitSquare = new Dictionary<UnitType, SquareBoardGame>();
            foreach(var i in units)
            {
                GetUnitSquare.Add(i.Key, null); //Initialize the list so its easier to update later
            }

            ShuffleUnits(); //A fresh board not copied will need randomly generated data, except at program launch. We'll clear it in that case.
        }

        public bool BenderAttacked()
        {
            if (GetUnitSquare[UnitType.Bender] == GetUnitSquare[UnitType.Url])
            {
                return true;
            }
            else return false;
        }

        //Copy constructor, used each new step
        public BoardGame(BoardGame set_from) : base()
        {

            //Initialize 10x10 grid
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board_data[i].Add(new SquareBoardGame((SquareBoardGame)set_from.board_data[i][j]));
                    if (board_data[i][j].visited_state == SquareVisitedState.Last && !board_data[i][j].UnitsPresent[UnitType.Bender])
                        board_data[i][j].visited_state = SquareVisitedState.Explored;
                }
            }

            AddWalls();

            units = new Dictionary<UnitType, UnitBase>();

            foreach(var i in set_from.units)
            {
                units.Add(i.Key, new UnitBase(i.Value));
            }

            GetUnitSquare = new Dictionary<UnitType, SquareBoardGame>();

            int x = 0;
            int y = 0;
            foreach (var i in set_from.GetUnitSquare)
            {
                x = i.Value.x;
                y = i.Value.y;

                GetUnitSquare.Add(i.Key, (SquareBoardGame)board_data[x][y]);
            }

        }

        //Only called when we start a new episode
        //We need to reset the visited state as well
        public void ShuffleCansAndUnits()
        {
            //Activate the 50/50 chance for each tile to have beer in it.
            foreach (var i in board_data)
            {
                foreach (var j in i)
                {
                    ((SquareBoardGame)j).randomize_beer_presence();
                    ((SquareBoardGame)j).visited_state = SquareVisitedState.Unexplored;
                }
            }

            ShuffleUnits(); //Place bender randomly somewhere
            //get_square_unit_is_on().visited_state = SquareVisitedState.Last;
        }


        //This is called each time we generate a new episode for our algorithm.
        //This is also called at the start of the program launch, disconnected from shuffling the whole board, just once.
        public void ShuffleUnits()
        {
            //The function can be the starting place of inserting units.

            int bender_x;
            int bender_y;
            int url_x;
            int url_y; 

            //If Bender is already somewhere on the board, make sure we remove him from that location.
            if (GetUnitSquare[UnitType.Bender] != null)
            {
                bender_x = GetUnitSquare[UnitType.Bender].x;
                bender_y = GetUnitSquare[UnitType.Bender].x;

                //Remove bender
                if (bender_x != -1)
                    GetUnitSquare[UnitType.Bender].UnitsPresent[UnitType.Bender] = false;
            }

            //Get bender's new location.
            bender_x = MyRandom.Next(0, 10);
            bender_y = MyRandom.Next(0, 10);


            //Get url coordinates
            if(GetUnitSquare[UnitType.Url] != null)
            { //remove url
                url_x = GetUnitSquare[UnitType.Url].x;
                url_y = GetUnitSquare[UnitType.Url].y;

                GetUnitSquare[UnitType.Url].UnitsPresent[UnitType.Url] = false;
            }
            
            //Prevent them from being on the same square
            do
            {
                //Url too
                url_x = MyRandom.Next(0, 10); //0-9 inclusive
                url_y = MyRandom.Next(0, 10); //0-9 inclusive
            } while (url_x == bender_x && bender_y == url_y);



            //Set the unit-to-board translator data locater
            GetUnitSquare[UnitType.Bender] = (SquareBoardGame)(board_data[bender_x][bender_y]);
            GetUnitSquare[UnitType.Url] = (SquareBoardGame)board_data[url_x][url_y];

            //Set the square's unit booleans
            (GetUnitSquare[UnitType.Bender]).UnitsPresent[UnitType.Bender] = true; //Set the square's unit booleans
            (GetUnitSquare[UnitType.Url]).UnitsPresent[UnitType.Url] = true; 

            //Assign visited state based on bender
            (GetUnitSquare[UnitType.Bender]).visited_state = SquareVisitedState.Last;

            //Have the units look at their surroundings
            UnitPercieves(UnitType.Bender);
            UnitPercieves(UnitType.Url);

            units[UnitType.Url].chasing = false;
        }

        //This function will give bender perception data from the board
        public void UnitPercieves(UnitType to_find)
        {
            PerceptionState find_perception = new PerceptionState(to_find);
            foreach (var i in to_find.PerceptionCauses)
            {
                find_perception.perception_data[i] = PercieveMove(i, to_find);
            }
            //Translated: for each move, percieve with this move, and update the perception for this move.

            find_perception.set_name();
            units[to_find].perceptionData = find_perception;
        }

        //Used when the robot moves *only*, otherwise, the perception will be checked from the state of the unit.
        //Generates percepts, and not MoveResults.
        public Percept PercieveMove(Move move_to_check, UnitType unit_to_check)
        {
            SquareBoardGame unit_location = GetUnitSquare[unit_to_check];            

            if (move_to_check != Move.Grab && unit_location.CheckIfWallsPreventMove(move_to_check))
                return Percept.Wall; //Wall percieved 
            else
            {
                int percieve_x = GetUnitSquare[unit_to_check].x + move_to_check.grid_adjustment[0];
                int percieve_y = GetUnitSquare[unit_to_check].y + move_to_check.grid_adjustment[1];

                SquareBoardBase percieve_location = board_data[percieve_x][percieve_y];
                if (percieve_location.UnitsPresent[unit_to_check.enemy] == true)
                    return Percept.Enemy;
                if (percieve_location.beer_can_present)
                    return Percept.Can;
                else
                    return Percept.Empty;
            }
        }

        //This is called when the algorithm has been reset
        public void ClearCans()
        {
            //Clear all cans
            foreach (var i in board_data)
            {
                foreach (var j in i)
                {
                    j.beer_can_present = false;
                    if (j.UnitsPresent[UnitType.Bender]) j.visited_state = SquareVisitedState.Last;
                    else
                        j.visited_state = SquareVisitedState.Unexplored;
                }
            }
        }

        /*
        public void ClonePosition(BoardGame clone_from)
        {
            for(int i = 0; i < board_size; i++)
            {
                for(int j = 0; j < board_size; j++)
                {
                    GetBoardData(i, j).copy_status(clone_from.GetBoardData(i, j));
                }
            }
        }
        */

        public bool IsBenderOnCan()
        {
            

            return (GetUnitSquare[UnitType.Bender]).beer_can_present;
        }



        public MoveResult ApplyMove(UnitType unit_to_move, Move move_to_apply)
        {
            GetUnitSquare[unit_to_move].visited_state = SquareVisitedState.Last;

            //Get the move result based on the current condition
            if (GetUnitSquare[unit_to_move].CheckIfWallsPreventMove(move_to_apply))
                return MoveResult.TravelFailed; //Walls prevent move

            if(move_to_apply == Move.Grab)
            {
                

                if (GetUnitSquare[unit_to_move].beer_can_present)
                {
                    BenderCollectsCan();
                    return MoveResult.CanCollected;
                }
                    
                else
                    return MoveResult.CanMissing;
            }
            //Didn't try to grab a can, and didn't hit a wall. We moved successfully.

            MoveUnit(unit_to_move, move_to_apply);
            return MoveResult.TravelSucceeded;
        }

        public void MoveUnit(UnitType unit_to_move, Move move_to_make)
        {
            //We're going to move the unit. Remove him from the previous location.
            (GetUnitSquare[unit_to_move]).UnitsPresent[unit_to_move] = false;

            //Get the new coordinates.
            int x = GetUnitSquare[unit_to_move].x + move_to_make.grid_adjustment[0];
            int y = GetUnitSquare[unit_to_move].y + move_to_make.grid_adjustment[1];            

            GetUnitSquare[unit_to_move] = (SquareBoardGame)board_data[x][y];

            GetUnitSquare[unit_to_move].UnitsPresent[unit_to_move] = true;
            GetUnitSquare[unit_to_move].visited_state = SquareVisitedState.Last;
             
            UnitPercieves(unit_to_move); //take in new surroundings
        }

        public void BenderCollectsCan()
        {   
            (GetUnitSquare[UnitType.Bender]).beer_can_present = false;
            UnitPercieves(UnitType.Bender);
        }

        public int GetCansRemaining()
        {
            int total = 0;
            foreach (var i in board_data)
            {
                foreach(var j in i)
                {
                    if (j.beer_can_present)
                        ++total;
                }
            }
            return total;
        }

        //Does this need to add a baseunit?
        public void AddUnit(UnitBase to_add)
        {
            units[UnitType.Bender] = to_add; //I think this removes bender
            GetUnitSquare[UnitType.Bender].UnitsPresent[UnitType.Bender] = true;
            //bender added
        }

        public void AddWalls()
        {
            //Set all walls to empty first

            foreach(var i in board_data)
            {
                foreach(var j in i)
                {
                    ((SquareBoardGame)j).walls = Walls.EmptyWallData;
                }
            }

            //Add walls, which will replace some of the empty walls.
            //left wall
            for (int i = 1; i <= 8; i++) { ((SquareBoardGame)board_data[0][i]).walls = Walls.Left; }
            //right wall
            for (int i = 1; i <= 8; i++) { ((SquareBoardGame)board_data[9][i]).walls = Walls.Right; }
            //bottom wall
            for (int i = 1; i <= 8; i++) { ((SquareBoardGame)board_data[i][0]).walls = Walls.Bottom; }
            //above wall
            for (int i = 1; i <= 8; i++) { ((SquareBoardGame)board_data[i][9]).walls = Walls.Top; }

            ((SquareBoardGame)board_data[0][0]).walls = Walls.BottomLeft;
            ((SquareBoardGame)board_data[9][9]).walls = Walls.TopRight;
            ((SquareBoardGame)board_data[0][9]).walls = Walls.TopLeft;
            ((SquareBoardGame)board_data[9][0]).walls = Walls.BottomRight;
        }

        public new SquareBoardGame GetBoardData(int x, int y)
        {
            return (SquareBoardGame)board_data[x][y];
        }


    }
}
