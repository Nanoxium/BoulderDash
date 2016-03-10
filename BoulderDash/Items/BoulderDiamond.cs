using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Items
{
    class BoulderDiamond : BoulderEntity
    {

        public BoulderDiamond(int x, int y) : base(x, y)
        {
            this.Type = BoulderItemType.Diamond;
        }

        public override bool Move(BoulderModel model)
        {
            return false;
        }
    }
}
