using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGrarphics
{
    static class ColorModelsConverter
    {
        public static ColorModelRgb ConvertToRgb(ColorModelCmyk modelCmyk)
        {
            var red = (int)Math.Round((decimal)((1 - modelCmyk.Cyan / 100.0)*(1 - modelCmyk.Key / 100.0) * 255));
            var green = (int)Math.Round((decimal)((1 - modelCmyk.Magenta / 100.0) * (1 - modelCmyk.Key / 100.0) * 255));
            var blue = (int)Math.Round((decimal)((1 - modelCmyk.Yellow / 100.0) * (1 - modelCmyk.Key / 100.0) * 255));

            return new ColorModelRgb(red, green ,blue);
        }

        public static ColorModelRgb ConvertToRgb(ColorModelHls modelHls)
        {
            double h = modelHls.Hue / 360.0;
            double s = modelHls.Saturation / 100.0;
            double l = modelHls.Lightness / 100.0;

            if (s == 0)                 /* раз насыщенность равна нулю, то цвет - серый */
            {
                var grey = (int)Math.Round(l * 255);
                return new ColorModelRgb(grey, grey, grey);
            }
            else
            {
                double temp1, temp2;
                if (l < 0.5)
                {
                    temp2 = l * (1 + s);
                }
                else
                {
                    temp2 = l + s - (l * s);
                }
                temp1 = 2 * l - temp2;

                double hueRgb = h + 1.0 / 3.0;

                var red = HueToRgb(temp1, temp2, hueRgb);
                hueRgb = h;
                var green = HueToRgb(temp1, temp2, hueRgb);
                hueRgb = h - 1.0 / 3.0;
                var blue = HueToRgb(temp1, temp2, hueRgb);

                return new ColorModelRgb((int)Math.Round(red * 255), (int)Math.Round(green * 255), (int)Math.Round(blue * 255));
            }
        }

        public static ColorModelCmyk ConvertToCmyk(ColorModelRgb modelRgb)
        {
            var key = Math.Min(Math.Min(1 - modelRgb.Red / 255.0, 1 - modelRgb.Green / 255.0), 1 - modelRgb.Blue / 255.0);

            if (key == 1)       /* раз минимум равен, то цвет чёрный */
            {
                return new ColorModelCmyk(0, 0, 0, 0);
            }

            var cyan = (1 - modelRgb.Red / 255.0 - key) / (1 - key);

            var magenta = (1 - modelRgb.Green / 255.0 - key) / (1 - key);

            var yellow = (1 - modelRgb.Blue / 255.0 - key) / (1 - key);

            return new ColorModelCmyk((int)Math.Round(cyan * 100), (int)Math.Round(magenta * 100), (int)Math.Round(yellow * 100), (int)Math.Round(key * 100));
        }

        public static ColorModelCmyk ConvertToCmyk(ColorModelHls modelHls)
        {
            var saturation = modelHls.Saturation / 100.0;
            var lightness = modelHls.Lightness / 100.0;

            double cyan, magenta, yellow, key;

            double max = Math.Max(lightness, Math.Max(saturation, 1 - lightness));
            key = 1 - max;

            if (key == 1)                 /* раз k = 1, то цвет - черный */
            {
                cyan = magenta = yellow = 0;
            }
            else
            {
                cyan = (1 - lightness - key) / (1 - key);
                magenta = (1 - saturation - key) / (1 - key);
                yellow = (1 - Math.Max(lightness, saturation) - key) / (1 - key);
            }

            return new ColorModelCmyk((int)Math.Round(cyan * 100), (int)Math.Round(magenta * 100), (int)Math.Round(yellow * 100), (int)Math.Round(key * 100));
        }

        public static ColorModelHls ConvertToHls(ColorModelCmyk modelCmyk)
        {
            return ConvertToHls(ConvertToRgb(modelCmyk));
        }

        public static ColorModelHls ConvertToHls(ColorModelRgb modelRgb)
        {
            double r = modelRgb.Red / 255.0;
            double g = modelRgb.Green / 255.0;
            double b = modelRgb.Blue / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;

            double hue, saturation, lightness;

            if (delta == 0)
            {
                hue = 0;
            }
            else if (max == r)
            {
                hue = ((g - b) / delta) % 6;
            }
            else if (max == g)
            {
                hue = ((b - r) / delta) + 2;
            }
            else
            {
                hue = ((r - g) / delta) + 4;
            }

            hue *= 60;

            if (hue < 0)
            {
                hue += 360;
            }

            lightness = (max + min) / 2;

            if (delta == 0)
            {
                saturation = 0;
            }
            else
            {
                saturation = delta / (1 - Math.Abs(2 * lightness - 1));
            }

            return new ColorModelHls((int)Math.Round(hue), (int)Math.Round(saturation * 100), (int)Math.Round(lightness * 100));
        }

        private static double HueToRgb(double temp1, double temp2, double hue)
        {
            if (hue < 0)
            {
                hue += 1;
            }
            if (hue > 1)
            {
                hue -= 1;
            }
            if (6 * hue < 1)
            {
                return temp1 + (temp2 - temp1) * 6 * hue;
            }
            if (2 * hue < 1)
            {
                return temp2;
            }
            if (3 * hue < 2)
            {
                return temp1 + (temp2 - temp1) * ((2.0 / 3) - hue) * 6;
            }
            return temp1;
        }
    }
}
