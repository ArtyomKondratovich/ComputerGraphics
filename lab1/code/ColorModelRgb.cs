using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGrarphics
{
    internal class ColorModelRgb
    {
        public int Red { get; set; }      /* [0, 255] */
        public int Green { get; set; }    /* [0, 255] */
        public int Blue { get; set; }     /* [0, 255] */

        public ColorModelRgb(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }


    }
}
