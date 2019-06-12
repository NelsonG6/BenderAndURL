using System.Windows.Forms;
using System.Collections.Generic;

namespace ReinforcementLearning
{
    class SquareBoardDisplay : SquareBoardBase
    {
        public PictureBox pictureData;

        public SquareBoardDisplay(int x, int y) : base(x, y)
        {
            pictureData = null;
        }

        public void SetPicture()
        {
            //Set can and/or bender
            if (beer_can_present && UnitsPresent[UnitType.Bender])
                pictureData.Image = Properties.Resources.bender_and_beer;
            else if (beer_can_present && UnitsPresent[UnitType.Url])
                pictureData.Image = Properties.Resources.url_and_beer;
            else if (UnitsPresent[UnitType.Url])
                pictureData.Image = Properties.Resources.URL;
            else if (beer_can_present)
                pictureData.Image = Properties.Resources.beer;
            else if (UnitsPresent[UnitType.Bender])
                pictureData.Image = Properties.Resources.bender;
            
            else
                pictureData.Image = null;

            //Set background
            pictureData.BackgroundImage = Backgrounds.dictionary[visited_state]; //Visisted state belongs to the base class, and is Unexplored by default
        }


        public void CopyStatus(SquareBoardBase copy_from)
        {
            UnitsPresent = new Dictionary<UnitBase, bool>();
            foreach(var i in copy_from.UnitsPresent)
            {
                UnitsPresent.Add(i.Key, i.Value);
            }

            beer_can_present = copy_from.beer_can_present;
            visited_state = copy_from.visited_state;
            x = copy_from.x;
            y = copy_from.y;
        }

        public static void set_backgrounds() //For constructor?
        {
        }
    }
}