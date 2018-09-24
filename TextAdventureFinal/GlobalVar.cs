using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureFinal
{
    class GlobalVar
    {
        public static LevelChange level = new LevelChange();
        public static int levelNumber = 0;
        public static string direction = "";
        public static bool coffinsOpen = false;
        public static bool hasTorch = false;
        public static bool hasCoin = false;
        public static bool gaveCoin = false;
        public static bool hasGlass = true;
        public static bool hasGem = false;
        public static int swordPieces = 0;
        public static bool bridgeBroken = false;
        public static bool hasBlade = false;
        public static bool hasSword = false;
        public static bool hasWon = false;
        public static string[] puzzle = { "hawk", "badger", "snake", "fish", "bear", "wolf", "jackal", "lion", "mouse", "horse" };
        public static int puzzlesAnswered = 0;
        public static string playerName = "";
    }
}
