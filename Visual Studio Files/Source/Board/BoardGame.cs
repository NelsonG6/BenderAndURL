using System.Collections.Generic;

namespace ReinforcementLearning
{
    //Manages a few different classes
    class BoardGame : BoardBase 
    {
        public Dictionary<UnitBase, SquareBoardGame> GetUnitSquare;

        public BoardGame() : base()
        {
            //Initialize 10x10 grid
            foreach (var i in board_data)
            {
                while(i.Count < InitialSettings.SizeOfBoard())
                {
                    i.Add(new SquareBoardGame());
                }
            }

            AddWalls();

            GetUnitSquare = new Dictionary<UnitBase, SquareBoardGame>();
            foreach(var i in units)
            {
                GetUnitSquare.Add(i.Key, null); //Initialize the list so its easier to update later
            }

            ShuffleUnits(); //A fresh board not copied will need randomly generated data, except at program launch. We'll clear it in that case.
        }

        //Copy constructor
        public BoardGame(BoardGame set_from) : base()
        {

            //Initialize 10x10 grid
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board_data[i].Add(new SquareBoardGame((SquareBoardGame)set_from.board_data[i][j]));
                    if (board_data[i][j].visited_state == SquareVisitedState.last() && !board_data[i][j].units_present[Unit.Bender()])
                        board_data[i][j].visited_state = SquareVisitedState.explored();
                }
            }

            AddWalls();

            units = new Dictionary<UnitBase, Unit>();

            foreach(var i in set_from.units)
            {
                units.Add(i.Key, new Unit(i.Value));
            }

            GetUnitSquare = new Dictionary<UnitBase, SquareBoardGame>();
            foreach(var i in set_from.GetUnitSquare)
            {
                GetUnitSquare.Add(i.Key, i.Value);
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
                    ((SquareBoardGame)j).visited_state = SquareVisitedState.unexplored();
                }
            }

            ShuffleUnits(); //Place bender randomly somewhere
            //get_square_unit_is_on().visited_state = SquareVisitedState.last();
        }


        //This is called each time we generate a new episode for our algorithm.
        //This is also called at the start of the program launch, disconnected from shuffling the whole board, just once.
        public void ShuffleUnits()
        {
            //If Bender is already somewhere on the board, make sure we remove him from that location.
            int bender_x = units[Unit.Bender()].x_coordinate; 
            int bender_y = units[Unit.Bender()].y_coordinate; 

            //Remove bender
            if (bender_x != -1)
                board_data[bender_x][bender_y].units_present[Unit.Bender()] = false;

            //Get bender's new location.
            bender_x = MyRandom.Next(0, 10);
            bender_y = MyRandom.Next(0, 10);

            //Get url coordinates
            int url_x = units[Unit.Url()].x_coordinate;
            int url_y = units[Unit.Url()].y_coordinate;

            //Remove url
            if (url_y != -1)
                board_data[url_x][url_y].units_present[Unit.Url()] = false;

            //Prevent them from being on the same square
            do
            {
                //Url too
                url_x = MyRandom.Next(0, 10); //0-9 inclusive
                url_y = MyRandom.Next(0, 10); //0-9 inclusive
            } while (url_x == bender_x && bender_y == url_y);



            //Set the unit-to-board translator data locater
            GetUnitSquare[Unit.Bender()] = (SquareBoardGame)(board_data[bender_x][bender_y]);
            GetUnitSquare[Unit.Url()] = (SquareBoardGame)board_data[bender_x][bender_y];

            //Set bender

            //Set bender's local position
            units[Unit.Bender()].x_coordinate = bender_x;
            units[Unit.Bender()].y_coordinate = bender_y;

            //Set url's local coordinates
            units[Unit.Url()].x_coordinate = url_x;
            units[Unit.Url()].y_coordinate = url_y;

            //Set the square's unit booleans
            (GetUnitSquare[Unit.Bender()]).units_present[Unit.Bender()] = true; //Set the square's unit booleans
            (GetUnitSquare[Unit.Url()]).units_present[Unit.Url()] = true; 

            //Assign visited state based on bender
            (GetUnitSquare[Unit.Bender()]).visited_state = SquareVisitedState.last();

            //Have the units look at their surroundings
            UnitPercieves(Unit.Bender());
            //UnitPercieves(Unit.Url());
        }

        //This function will give bender perception data from the board
        public void UnitPercieves(UnitBase to_find)
        {
            PerceptionState find_perception = new PerceptionState();
            foreach (var i in to_find.unit_move_list)
            {
                find_perception.perception_data[i] = PercieveMove(i, to_find);
            }
            //Translated: for each move, percieve with this move, and update the perception for this move.

            find_perception.set_name();
            units[Unit.Bender()].perception_data = PerceptionState.GetPerceptionFromList(find_perception);
        }

        public PerceptionState GetUnitPerception()
        {
            PerceptionState find_perception = new PerceptionState();
            foreach (var i in Move.HorizontalMovesAndGrab)
            {
                find_perception.perception_data[i] = PercieveMove(i);
            }
            //Translated: for each move, percieve with this move, and update the perception for this move.

            find_perception.set_name();
            return PerceptionState.GetPerceptionFromList(find_perception);
        }

        //Used when the robot moves *only*, otherwise, the perception will be checked from the state of the unit.
        //Generates percepts, and not MoveResults.
        public Percept PercieveMove(Move move_to_check, UnitBase unit_to_check)
        {
            int x = units[Unit.Bender()].x_coordinate;
            int y = units[Unit.Bender()].y_coordinate;

            SquareBoardBase bender_location = board_data[x][y];

            if (move_to_check != Move.Grab() && ((SquareBoardGame)bender_location).CheckIfWallsPreventMove(move_to_check))
            {
                return Percept.wall(); //Wall percieved 
            }
            else
            {
                int percieve_x = x + move_to_check.grid_adjustment[0];
                int percieve_y = y + move_to_check.grid_adjustment[1];

                SquareBoardBase percieve_location = board_data[percieve_x][percieve_y];
                if (percieve_location.beer_can_present)
                    return Percept.can();
                else
                    return Percept.empty();
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
                    if (j.units_present[Unit.Bender()]) j.visited_state = SquareVisitedState.last();
                    else
                        j.visited_state = SquareVisitedState.unexplored();
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
            

            return (GetUnitSquare[Unit.Bender()]).beer_can_present;
        }



        public MoveResult ApplyMove(UnitBase unit_to_move, Move move_to_apply)
        {
            GetUnitSquare[unit_to_move].visited_state = SquareVisitedState.last();

            //Get the move result based on the current condition
            if (GetUnitSquare[unit_to_move].CheckIfWallsPreventMove(move_to_apply))
                return MoveResult.move_hit_wall(); //Walls prevent move

            if(move_to_apply == Move.Grab())
            {
                

                if (GetUnitSquare[unit_to_move].beer_can_present)
                {
                    BenderCollectsCan();
                    return MoveResult.can_collected();
                }
                    
                else
                    return MoveResult.can_missing();
            }
            //Didn't try to grab a can, and didn't hit a wall. We moved successfully.

            MoveUnit(unit_to_move, move_to_apply);
            return MoveResult.move_successful();
        }

        public void MoveUnit(UnitBase unit_to_move, Move move_to_make)
        {
            (GetUnitSquare[Unit.Bender()]).units_present[Unit.Bender()] = false;

            units[Unit.Bender()].x_coordinate += move_to_make.grid_adjustment[0];
            units[Unit.Bender()].y_coordinate += move_to_make.grid_adjustment[1];
            GetUnitSquare[Unit.Bender()].units_present[Unit.Bender()] = true;
            GetUnitSquare[Unit.Bender()].visited_state = SquareVisitedState.last();
            UnitPercieves(unit_to_move);
        }

        public void BenderCollectsCan()
        {   
            (GetUnitSquare[Unit.Bender()]).beer_can_present = false;
            UnitPercieves(Unit.Bender());
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

        //Search for baseunit
        public void RemoveUnit(UnitBase to_remove)
        {
            int x = units[to_remove].x_coordinate;
            int y = units[to_remove].y_coordinate;

            board_data[x][y].units_present[to_remove] = false;
            units[to_remove] = null; //I think this removes bender
            
        }

        //Does this need to add a baseunit?
        public void AddUnit(Unit to_add)
        {
            units[Unit.Bender()] = to_add; //I think this removes bender
            (GetUnitSquare[Unit.Bender()]).units_present[Unit.Bender()] = true;
            //bender added
        }

        public void AddWalls()
        {
            //Set all walls to empty first

            foreach(var i in board_data)
            {
                foreach(var j in i)
                {
                    ((SquareBoardGame)j).walls = Walls.empty_wall();
                }
            }
            
            //Add walls, which will replace some of the empty walls.
            //left wall
            for (int i = 1; i <= 8; i++) { ((SquareBoardGame)board_data[0][i]).walls = Walls.left_wall(); }
            //right wall
            for (int i = 1; i <= 8; i++) { ((SquareBoardGame)board_data[9][i]).walls = Walls.right_wall(); }
            //bottom wall
            for (int i = 1; i <= 8; i++) { ((SquareBoardGame)board_data[i][0]).walls = Walls.bottom_wall(); }
            //above wall
            for (int i = 1; i <= 8; i++) { ((SquareBoardGame)board_data[i][9]).walls = Walls.top_wall(); }

            ((SquareBoardGame)board_data[0][0]).walls = Walls.bottom_left_wall();
            ((SquareBoardGame)board_data[9][9]).walls = Walls.top_right_wall();
            ((SquareBoardGame)board_data[0][9]).walls = Walls.top_left_wall();
            ((SquareBoardGame)board_data[9][0]).walls = Walls.bottom_right_wall();
        }

        public new SquareBoardGame GetBoardData(int x, int y)
        {
            return (SquareBoardGame)board_data[x][y];
        }


    }
}
