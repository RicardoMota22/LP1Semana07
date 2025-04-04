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
        public double Pop() => radius = 0;


        public int GetTimesThrown
        {
            get
            {
                return thrown++;
            }
        }
        
        //Metodo Throw
        public int Throw //Property
        {
            get
            {
                return thrown++;
            }
            set
            {
            if (radius >= 0)
                thrown++;
            }
        }

        
        public override string ToString() => $"Sphere({color}, Radius: {radius}, Times Thrown: {thrown})";
        
    }
}