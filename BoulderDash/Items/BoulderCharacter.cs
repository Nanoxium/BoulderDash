using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash.Items
{
    class BoulderCharacter : BoulderEntity
    {
        public BoulderCharacter(int x, int y) : base(x, y)
        {
            this.Type = BoulderItemType.Character;
        }

        public override bool Move(BoulderModel model)
        {
            return true;
        }
    }
}
