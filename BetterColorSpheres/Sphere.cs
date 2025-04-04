using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        private readonly Color color; // field
        private double radius{get;set;}
        private int thrown {get;set;}
        //Construtor
        public Sphere(Color color, double radius, int thrown)
        {
            this.color = color;
            this.radius = radius;
            this.thrown = 0;
        }
        //Metodo Pop
        public int Pop => 0;
        
        //Metodo Throw
        public int Throw //Property
        {
            get
            {
                return GetTimesThrown +1;
            }
            set
            {
            if (radius == 0)
                thrown = thrown;
            }
        }

        public int GetTimesThrown
        {
            get
            {
                return thrown++;
            }
        }
        public override string ToString() => $"Sphere({color}, Radius: {radius}, Times Thrown: {thrown})";
        
    }
}