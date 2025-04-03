using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color color;
        private double radius;
        private int thrown;
        //Construtor
        public Sphere(Color color, double radius, int thrown)
        {
            this.color = color;
            this.radius = radius;
            this.thrown = 0;
        }
        //Metodo Pop
        public void Pop() => radius = 0;
        
        //Metodo Throw
        public void Throw()
        {
        if (radius > 0)
            thrown++;
        }

        public int GetTimesThrown()
        {
            return thrown++;
        }
        public override string ToString() => $"Sphere({color}, Radius: {radius}, Times Thrown: {thrown})";
        
    }
}