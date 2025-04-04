using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color red = new Color(255, 0, 0,255);
            Color blue = new Color(0, 0, 255,255);
            

            Sphere s1 = new Sphere(red, 10,1);
            Sphere s2 = new Sphere(blue, 15,2);
            

            
            
            

            Console.WriteLine(s1);
            Console.WriteLine(s1.Throw);
            Console.WriteLine(s1.Throw);
            Console.WriteLine(s2);
            Console.WriteLine(s1);
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Throw);
            Console.WriteLine(s1);
            
            
        }
    }
}
