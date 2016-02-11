using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace BoulderDash
{
    class BoulderView : Panel
    {
        public const int SCALE = 30;
        private int[,] world;

        public BoulderView(Point loc, int w, int h, BoulderLevel defLevel)
        {
            this.DoubleBuffered = true;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Width = w;
            this.Height = h;
            this.Location = loc;
            this.Paint += Render;
            world = new int[2,2];
        }

        public new void Update(int[,] data)
        {
            this.world = data;
            this.Refresh();
        }

        private void Render(object sender, PaintEventArgs e)
        {
            for (int x = 0; x < world.GetLength(1); x++)
            {
                for (int y = 0; y < world.GetLength(0); y++)
                {
                    Image tile = (Image) Properties.Resources.ResourceManager.GetObject("item_" + world[y, x]);
                        e.Graphics.DrawImage( tile ?? Properties.Resources.player_0 , x*SCALE, y*SCALE, 30, 30);
                }
            }
        }
    }
}
