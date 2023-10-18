using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGrarphics
{
    internal class ColorModelCmyk
    {
        public int Cyan { get; set; }       /* [0, 100] */
        public int Magenta { get; set; }    /* [0, 100] */
        public int Yellow { get; set; }     /* [0, 100] */
        public int Key { get; set; }        /* [0, 100] */

        public ColorModelCmyk(int cyan, int magenta, int yellow, int key) 
        {
            Cyan = cyan;
            Magenta = magenta;
            Yellow = yellow;
            Key = key;
        }

    }
}
