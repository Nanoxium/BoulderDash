using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulderDash {
   class BoulderLevel {
      public int     id;            // Identifiant du niveau

      public string  name;          // Nom du niveau
      public string  author;        // Auteur du niveau

      public int     time;          // Temps pour finir
      public int     diamNeeded;    // Nombre de diamant pour sortir
      public int     diamScore;     // Score par diamant
      public int     diamExtra;     // Score par diamant supplémentaire

      public bool    bonus;         // Est-ce un niveau bonus

      public int     width;         // Largeur du niveau (40)
      public int     height;        // Hauteur du niveau (22)
      public int []  world;         // Définition du niveau

      public BoulderLevel(int id, string name, string author, int time, int diamNeeded, int diamScore, int diamExtra, bool bonus, int[] world, int width = 40, int height = 22) {
         this.id = id;
         this.name = name;
         this.author = author;

         this.time = time;
         this.diamNeeded = diamNeeded;
         this.diamScore = diamScore;
         this.diamExtra = diamExtra;

         this.bonus = bonus;

         this.width = width;
         this.height = height;
         this.world = world;
      }

      public int[,] getView(int x, int y, int w, int h) {
         int[,] result = new int[h, w];

         for (int j = y; j < y + h; j++) {
            for (int i = x; i < x + w; i++) {
               result[j - y, i - x] = this.world[i + j * this.width];
            }
         }

         return result;
      }
   }
}
