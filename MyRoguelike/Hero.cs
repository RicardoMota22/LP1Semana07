using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Hero
    {
        private int xp;
        private float health {get;set;}


        public Hero(string name)
        {
            Name = name;
            xp = 0;
            Health = MaxHealth;
        }
        public string Name {get;}

        public int XP
        {
            get 
            {
                return xp;
            }
            set
            {
            
                if (xp < 0)
                {
                    xp = xp;
                }
            
            }
        }
        
        public int Level
        {
            get
            {
                return 1 + XP/1000;
            }
            
        }

        public float MaxHealth
        {
            get
            {
                return 100 + (Level -1) * 20;
            }
        }
        public float Health
        {
            get
            {
                return MaxHealth ;
            }
            set
            {
                if (health <=0)
            {
                health = 0;
            }
                else if (health >= MaxHealth)
                health = MaxHealth;
            }
            
        }

        public void TakeDamage(float damage)
        {
            Health = Health - damage;
            XP += (int)damage/20;
        }
    }
}