using System.Windows.Forms;
using System.Collections.Generic;

namespace ReinforcementLearning
{
    class SquareBoardDisplay : SquareBoardBase
    {
        public PictureBox pictureData;

        public SquareBoardDisplay() : base()
        {
            pictureData = null;
        }

        public void SetPicture()
        {
            //Set can and/or bender
            if (beer_can_present && units_present[Unit.Bender()])
                pictureData.Image = Properties.Resources.bender_and_beer;
            else if (beer_can_present)
                pictureData.Image = Properties.Resources.beer;
            else if (units_present[Unit.Bender()])
                pictureData.Image = Properties.Resources.bender;
            else
                pictureData.Image = null;

            //Set background
            pictureData.BackgroundImage = Backgrounds.dictionary[visited_state]; //Visisted state belongs to the base class, and is unexplored by default
        }


        public void CopyStatus(SquareBoardBase copy_from)
        {
            beer_can_present = copy_from.beer_can_present;
            units_present = new Dictionary<Unit, bool>();
            foreach(var i in copy_from.units_present)
            {
                units_present.Add(i.Key, i.Value);
            }

            visited_state = copy_from.visited_state;
        }

        public static void set_backgrounds()
        {

        }
    }
}