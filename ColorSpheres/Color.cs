using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Color
    {
        //Store
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha = 255;

        //Constructor
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        //cant make it 4 parametres
        public Color()
        {
            alpha = 255;
        }
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