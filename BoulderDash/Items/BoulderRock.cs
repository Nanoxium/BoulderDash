using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoulderDash.Items
{
    class BoulderRock : BoulderEntity
    {
        private bool SkipSides = false;

        public BoulderRock(int x, int y) : base(x, y)
        {
            this.Type = BoulderItemType.Rock;
        }

    //TODO: Finilize move method for rock
        public override bool Move(BoulderModel model)
        {

            if (MoveLeft(model))
            {
                this.X--;
                return true;
            }
            if (MoveRight(model))
            {
                this.X++;
                return true;
            }
            return false;
        }

        private bool MoveRight(BoulderModel model)
        {
            if (model.getItem(this.X + 1, this.Y).Type == BoulderItemType.Void)
                return true;

            return false;
        }

        private bool MoveLeft(BoulderModel model)
        {
            if (model.getItem(this.X + 1, this.Y).Type == BoulderItemType.Void)
                return true;

            return false;
        }

        private bool MoveDown(BoulderModel model)
        {
            if (model.getItem(this.X, this.Y + 1).Type == BoulderItemType.Void)
                return true;

            return false;
        }
    }
}
