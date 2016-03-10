using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BoulderDash.Items;

namespace BoulderDash
{
    class BoulderModel
    {
        public BoulderEntity[,] World;
        private int Width { get; set; }
        private int Height { get; set; }

        public int ViewX { get; set; }
        public int ViewY { get; set; }
        public int ViewW { get; set; }
        public int ViewH { get; set; }
        private int Dead { get; set; }
        private bool Paused { get; set; }

        public int Score { get; private set; }
        public int Diamonds { get; private set; }

        public bool Changed { get; set; } = true;
        public int DiamondGrabbed { get; set; }

        public int Lives { get; set; }

        public BoulderModel()
        {
            this.Score = 0;
            this.Diamonds = 0;
            this.Lives = 3;
        }

        /// <summary>
        /// Return the current tile in the frame
        /// </summary>
        /// <returns>world</returns>
        public int[,] GetView()
        {
            int[,] temp = new int[this.World.GetLength(0), this.World.GetLength(1)];
            for (int x = 0; x < this.World.GetLength(0); x++)
            {
                for (int y = 0; y < this.World.GetLength(1); y++)
                {
                    temp[x, y] = (int)this.World[x + ViewW, y + ViewH].Type;
                }
            }
            return temp;
        }

        /// <summary>
        /// Updates the model
        /// </summary>
        /// <param name="time"></param>
        public void Update(long time)
        {
            if (!Paused)
            {

            }
        }

        /// <summary>
        /// Generate a new BoulderEntity for all the level
        /// </summary>
        /// <param name="lev"></param>
        public void LoadLevel(BoulderLevel lev)
        {
            this.Changed = true;
            this.Width = lev.width;
            this.Height= lev.height;
            this.World = new BoulderEntity[lev.width, lev.height];
            for (int x = 0; x < lev.width; x++)
            {
                for (int y = 0; y < lev.height; y++)
                {
                    this.World[x, y] = createBoulderEntity(lev.world[x + y * lev.width], x, y);
                }
            }
        }

        /// <summary>
        /// Create a BoulderEntity
        /// </summary>
        /// <param name="Id">the id of the BoulderEntity</param>
        /// <param name="x">X position</param>
        /// <param name="y">Y position</param>
        /// <returns></returns>
        private BoulderEntity createBoulderEntity(int Id, int x, int y)
        {
            switch (Id)
            {
                case (int)BoulderItemType.Void:
                    return new BoulderVoid(x, y);

                case (int)BoulderItemType.Dirt:
                    return new BoulderDirt(x, y);

                case (int)BoulderItemType.Rock:
                    return new BoulderRock(x, y);

                case (int)BoulderItemType.Diamond:
                    return new BoulderDiamond(x, y);

                case (int)BoulderItemType.Wall:
                    return new BoulderWall(x, y);

                case (int)BoulderItemType.BorderWall:
                    return new BoulderBorderWall(x, y);

                case (int)BoulderItemType.Character:
                    return new BoulderCharacter(x, y);

                default:
                    return new BoulderVoid(x, y);
            }
        }

        /// <summary>
        /// Silence is god
        /// </summary>
        /// <returns>en of the game</returns>
        public bool IsGameOver()
        {
            if (this.Lives < 0)
                return true;
            return false;
        }

        /// <summary>
        /// Places the item at the coordonate x and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="item"></param>
        public void setItem(int x, int y, BoulderEntity item)
        {
            this.Changed = true;
            if (x < this.World.GetLength(0) && y < this.World.GetLength(1))
                this.World[x, y] = item;
        }

        /// <summary>
        /// Return an item at the x, y coordonate
        /// </summary>
        /// <param name="x">X coordonate</param>
        /// <param name="y">Y coordonate</param>
        /// <returns>the item</returns>
        public BoulderEntity getItem(int x, int y)
        {
            if (x < this.World.GetLength(0) && y < this.World.GetLength(1))
                return this.World[x, y];
            return null;
        }

        /// <summary>
        /// Puts the game in Paused or Unpaused State
        /// </summary>
        /// <param name="pause"></param>
        public void SetPause(bool pause)
        {
            this.Paused = pause;
        }
    }
}
