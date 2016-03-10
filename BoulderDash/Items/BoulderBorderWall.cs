using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Items
{
    class BoulderBorderWall : BoulderEntity
    {
        public BoulderBorderWall(int x, int y) : base(x, y)
        {
            this.Type = BoulderItemType.BorderWall;
        }

        public override bool Move(BoulderModel model)
        {
            return false;
        }

        public override bool Replace(BoulderModel model, BoulderEntity entity)
        {
            return false;
        }
    }
}
