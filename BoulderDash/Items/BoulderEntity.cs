using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoulderDash
{
    public enum  BoulderItemType
    {
        Void = 0,
        Dirt = 1,
        Rock = 2,
        Diamond = 3,
        Wall = 5,
        BorderWall = 6,
        Character = 0xf
    }

    abstract class BoulderEntity
    {
        public BoulderItemType Type { get; protected set; }
        public int X { get; set; }
        public int Y { get; set; }

        public BoulderEntity(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public abstract bool Move(BoulderModel model);

        public virtual bool Replace(BoulderModel model, BoulderEntity entity)
        {
            model.setItem(this.X, this.Y, entity);
            return true;
        }
    }
}
