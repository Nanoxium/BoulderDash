using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Items
{
    class BoulderDirt : BoulderEntity
    {
        public BoulderDirt(int x, int y) : base(x, y)
        {
            this.Type = BoulderItemType.Dirt;
        }

        public override bool Move(BoulderModel model)
        {
            return false;
        }

        public override bool Replace(BoulderModel model, BoulderEntity entity)
        {
            if (entity.Type == BoulderItemType.Character)
            {
                model.setItem(this.X, this.Y, entity);
                return true;
            }
            return false;
        }
    }
}
