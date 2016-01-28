using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoulderDash
{
    class KeyDef
    {
        public Keys KeyCode { get; set; }
        public bool Pressed { get; set; }
        public string Representation { get; set;}

        /// <summary>
        /// Create a new key definition for the game
        /// </summary>
        /// <param name="keycode">the key code</param>
        /// <param name="representation">the way it is displayed</param>
        public KeyDef(Keys keycode, string representation)
        {
            this.KeyCode = keycode;
            this.Representation = representation;
        }

        public override string ToString()
        {
            return Representation;
        }

    }
}
