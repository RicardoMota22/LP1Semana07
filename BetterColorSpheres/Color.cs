using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Color
    {
        //Store
        private  byte red {get;}
        private  byte green{get;}
        private  byte blue{get;}
        private  byte alpha = 255;

        //Constructor
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            
        }

        //cant make it 4 parametres

        //Properties
        public byte Red {get;}
        /*{
            get
            {
                return red;
            }
        }*/
        public byte Green {get;}
        
        public byte Blue {get;}
        
        public byte Alpha {get;}
        
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