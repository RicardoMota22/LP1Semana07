using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
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

        //Properties
        public byte Red
        {
            get
            {
                return red;
            }
        }
        public byte Green
        {
            get
            {
                return green;
            }
        }
        public byte Blue
        {
            get
            {
                return blue;
            }
        }
        public byte Alpha
        {
            get
            {
                return alpha;
            }
        }
        public byte GetGrey
        {
            get
            {
                byte total = (byte)(red + green + blue);
                return (byte)(total/3);
            }
        }
        public override string ToString() => $"Color(Red: {red}, Green: {green}, Blue: {blue}, Alpha: {alpha})";
    }
}