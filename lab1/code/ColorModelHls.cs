using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGrarphics
{
    internal class ColorModelHls
    {
        public int Hue { get; set; }            /* [0, 360] */
        public int Saturation { get; set; }     /* [0, 100] */
        public int Lightness { get; set; }      /* [0, 100] */

        public ColorModelHls(int hue, int saturation, int lightness)
        {
            Hue = hue;
            Saturation = saturation;
            Lightness = lightness;
        }

    }
}
