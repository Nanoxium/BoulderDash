using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoulderDash
{
    public partial class BDController : Form
    {
        #region Variables
        private BDAbout aboutbox;
        private List<KeyDef> keys;
        #endregion

        #region Constructor
        public BDController()
        {
            InitializeComponent();     
            aboutbox = new BDAbout();

            //Adding the key to listen to
            keys = new List<KeyDef>();
            keys.Add(new KeyDef(Keys.Up, "↑"));
            keys.Add(new KeyDef(Keys.Down, "↓"));
            keys.Add(new KeyDef(Keys.Left, "←"));
            keys.Add(new KeyDef(Keys.Right, "→"));
            keys.Add(new KeyDef(Keys.Space, "🔫"));

            //Positionning of the panel
            BoulderView view = new BoulderView();
            view.BackColor = Color.Aqua;
            this.Controls.Add(view);
            view.Location = this.pnlPositionning.Location;
        }
        #endregion

        #region Methods

        #region App Stuff
        private void tsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ask if the user wants to exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDController_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO : Remove when the game is done
            //if(MessageBox.Show("Do you really want to exit the game ?", "Exit", MessageBoxButtons.YesNo) == DialogResult.No)
            //    e.Cancel = true;
        }

        /// <summary>
        /// Show the about dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutbox.ShowDialog();
        }
        #endregion

        #region Game
        /// <summary>
        /// the main game loop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrGameLoop_Tick(object sender, EventArgs e)
        {
            
        }

        #region Key
        /// <summary>
        /// Key up handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDController_KeyUp(object sender, KeyEventArgs e)
        {
            //select the key if it exist in the list
            var key = keys.Where(elem => elem.KeyCode == e.KeyCode).FirstOrDefault();

            //If a key was found then updates its state
            if (key != null)
            {
                key.Pressed = false;
                UpdateKeyPressed();
            }
        }

        /// <summary>
        /// Update the form with the key pressed
        /// </summary>
        private void UpdateKeyPressed()
        {
            string show = "Key pressed : ";
            //Get the key pressed and gets their representation
            keys.Where(key => key.Pressed == true).ToList().ForEach(x => { show += x.ToString() + ""; });
            this.sslKeyPressed.Text = show;
        }

        /// <summary>
        /// Key down handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BDController_KeyDown(object sender, KeyEventArgs e)
        {
            //select the key if it exist in the list
            var key = keys.Where(elem => elem.KeyCode == e.KeyCode).FirstOrDefault();

            //If a key was found then updates its state
            if (key != null)
            {
                key.Pressed = true;
                UpdateKeyPressed();
            }
        }
        #endregion
        #endregion

        #endregion
    }
}