using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforcementLearning
{
    //This class is used by the FormsHandler, and there should only ever be one instance.
    //It stores PictureSquares, instead of BoardSquares
    class BoardDisplay : BoardBase
    {
        public BoardDisplay() : base()
        {
            SquareBoardDisplay.set_backgrounds(); //This initializes a dictionary of "boardVisistedState" - background image pairs.

            //Initialize 10x10 grid
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board_data[i].Add(new SquareBoardDisplay());
                }
            }
        }

        public void ClonePosition(BoardBase set_from)
        {
            for (int i = 0; i < set_from.board_data.Count; i++)
            {
                for (int j = 0; j < set_from.board_data[i].Count; j++)
                {
                    GetBoardData(i, j).CopyStatus(set_from.GetBoardData(i, j));
                }
            }

            units = new Dictionary<UnitBase, Unit>();
            foreach(var i in set_from.units)
            {
                units.Add(i.Key, i.Value);
            }
        }

        public new SquareBoardDisplay GetBoardData(int x, int y)
        {
            return (SquareBoardDisplay)board_data[x][y];
        }
    }
}
