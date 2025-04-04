using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health;

        public string Name;
        
        public int Level
        {
            set
            {
                return 1 + XP/1000;
            }
            
        }
        public int Health
        {
            get
            {
                if (health <=0)
            {
                health = 0;
            }
                else if (health >= MaxHealth)
                health = MaxHealth;
            }
            
        }
    }
}