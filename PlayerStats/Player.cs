using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        public float highScore {get; private set;}
        public int playedGames {get; private set;}

        public int wonGames {get; private set;}

        

        public Player(string name)
        {
            Name = name;
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }
        


        public float HighScore
        {
            get
            { 
                return highScore; 
            }
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }

        public string Name {get;}

        public float WinRate
        {
            get 
            {
                return (float) wonGames / playedGames; 
            }
            set
            {
                if (playedGames == 0)
                WinRate = 0;
            }
        }

        public void PlayGame(bool win)
        {
            playedGames++;
            if(win)
            {
                wonGames++;
            }
        }


        


    }
}