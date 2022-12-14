using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPG_Game
{
    class Character
    {
        public string Name;
        public int Health;
        public int DamageMaximum;

        public bool AttackBonus;

        public bool Luck()
        {
            Random random = new Random();
            bool Lucky = random.Next(2) == 0;
            return Lucky;
        }


        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(DamageMaximum);
            return damage;
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
  }    }