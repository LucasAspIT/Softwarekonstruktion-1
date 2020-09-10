using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rode_Kode {
    class Hero {
        public int health;
        public int strength;
        public int magic;
        public int armor;
        public int healthPotions;
        public int itemKey;
        public int gold;
        public int heroLevel;

        public void UPDATEHERO() {

            magic = 15 + heroLevel;
            health = 190 + heroLevel * 10;
            strength = 19 + heroLevel;

            // temp
            strength = 99 + heroLevel;

        }

        public Hero() {

            UPDATEHERO();

            armor = 5;
            healthPotions = 1;
            gold = 10;

        }
    }
}