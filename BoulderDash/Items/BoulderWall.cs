using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Items
{
    class BoulderWall : BoulderEntity
    {
        public BoulderWall(int x, int y) : base(x, y)
        {
            this.Type = BoulderItemType.Wall;
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
