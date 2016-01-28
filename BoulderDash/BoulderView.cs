using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace BoulderDash
{
    class BoulderView : Panel
    {
        public BoulderView()
        {
            this.DoubleBuffered = true;
            this.Width = 600;
            this.Height = 360;
        }
    }
}
