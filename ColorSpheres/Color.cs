using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        //Store
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;
        private const byte alpha = 255;

        //Constructor
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            
        }

        //cant make it 4 parametres

        //Get methods
        public byte GetRed()
        {
            return red;
        }
        public byte GetGreen()
        {
            return green;
        }
        public byte GetBlue()
        {
            return blue;
        }
        public byte GetAlpha()
        {
            return alpha;
        }
        public byte GetGrey()
        {
            byte total = (byte)(red + green + blue);
            return (byte)(total/3);
        }
        public override string ToString() => $"Color(Red: {red}, Green: {green}, Blue: {blue}, Alpha: {alpha})";
    }
}