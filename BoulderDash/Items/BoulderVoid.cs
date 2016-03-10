using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Items
{
    class BoulderVoid : BoulderEntity
    {

        public BoulderVoid(int x, int y) : base(x, y)
        {
            this.Type = BoulderItemType.Void;
        }

        public override bool Move(BoulderModel model)
        {
            return false;
        }
    }
}
