using System.DirectoryServices.ActiveDirectory;
using System.Runtime.InteropServices.ObjectiveC;

namespace ComputerGrarphics
{
    public partial class Form1 : Form
    {
        private ColorModelRgb _rgb = new(255, 255, 255);

        private ColorModelCmyk _cmyk = new(0, 0, 0, 0);

        private ColorModelHls _hls = new(0, 100, 0);

        private bool isEvent = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Input_blue_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var blue = input_blue.Text;

                if (int.TryParse(blue, out var result) && result >= 0 && result <= 255)
                {
                    _rgb.Blue = result;
                    isEvent = false;
                    Update(1);
                }
                else
                {
                    input_blue.Text = "";
                    input_blue.Focus();
                }
            }
        }

        private void Input_green_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var green = input_green.Text;

                if (int.TryParse(green, out var result) && result >= 0 && result <= 255)
                {
                    _rgb.Green = result;
                    isEvent = false;
                    Update(1);
                }
                else
                {
                    input_green.Text = "";
                    input_green.Focus();
                }
            }

        }

        private void Input_red_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var red = input_red.Text;

                if (int.TryParse(red, out var result) && result >= 0 && result <= 255)
                {
                    _rgb.Red = result;
                    isEvent = false;
                    Update(1);
                }
                else
                {
                    input_red.Text = "";
                    input_red.Focus();
                }
            }
        }

        private void Update(int id)
        {
            switch (id)
            {
                case 1:
                    _cmyk = ColorModelsConverter.ConvertToCmyk(_rgb);
                    _hls = ColorModelsConverter.ConvertToHls(_rgb);
                    break;
                case 2:
                    _rgb = ColorModelsConverter.ConvertToRgb(_cmyk);
                    _hls = ColorModelsConverter.ConvertToHls(_cmyk);
                    break;
                case 3:
                    _rgb = ColorModelsConverter.ConvertToRgb(_hls);
                    _cmyk = ColorModelsConverter.ConvertToCmyk(_hls);
                    break;
            }

            SetNewParametrs();
        }

        private void SetNewParametrs()
        {
            down_R.Text = _rgb.Red.ToString();
            down_G.Text = _rgb.Green.ToString();
            down_B.Text = _rgb.Blue.ToString();

            down_C.Text = _cmyk.Cyan.ToString();
            down_M.Text = _cmyk.Magenta.ToString();
            down_Y.Text = _cmyk.Yellow.ToString();
            down_K.Text = _cmyk.Key.ToString();

            down_H.Text = _hls.Hue.ToString();
            down_L.Text = _hls.Lightness.ToString();
            down_S.Text = _hls.Saturation.ToString();

            currentColor.BackColor = Color.FromArgb(_rgb.Red, _rgb.Green, _rgb.Blue);

            if (!isEvent)
            {
                input_red.Text = _rgb.Red.ToString();
                input_green.Text = _rgb.Green.ToString();
                input_blue.Text = _rgb.Blue.ToString();

                RGB_red.Value = _rgb.Red;
                RGB_blue.Value = _rgb.Blue;
                RGB_green.Value = _rgb.Green;

                input_cyan.Text = _cmyk.Cyan.ToString();
                input_magenta.Text = _cmyk.Magenta.ToString();
                input_yellow.Text = _cmyk.Yellow.ToString();
                input_key.Text = _cmyk.Key.ToString();

                CMYK_cyan.Value = _cmyk.Cyan;
                CMYK_magenta.Value = _cmyk.Magenta;
                CMYK_yellow.Value = _cmyk.Yellow;
                CMYK_key.Value = _cmyk.Key;

                input_hue.Text = _hls.Hue.ToString();
                input_lightness.Text = _hls.Lightness.ToString();
                input_saturation.Text = _hls.Saturation.ToString();

                HLS_hue.Value = _hls.Hue;
                HLS_lightness.Value = _hls.Lightness;
                HLS_saturation.Value = _hls.Saturation;

                isEvent = true;
            }
        }

        private void RGB_red_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _rgb.Red = RGB_red.Value;
                isEvent = false;
                Update(1);
            }
        }

        private void RGB_green_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _rgb.Green = RGB_green.Value;
                isEvent = false;
                Update(1);

            }
        }

        private void RGB_blue_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _rgb.Blue = RGB_blue.Value;
                isEvent = false;
                Update(1);
            }
        }

        private void Input_cyan_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var cyan = input_cyan.Text;

                if (int.TryParse(cyan, out var result) && result >= 0 && result <= 100)
                {
                    _cmyk.Cyan = result;
                    isEvent = false;
                    Update(2);
                }
                else
                {
                    input_cyan.Text = string.Empty;
                    input_cyan.Focus();
                }
            }

        }

        private void Input_magenta_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var magenta = input_magenta.Text;

                if (int.TryParse(magenta, out var result) && result >= 0 && result <= 100)
                {
                    _cmyk.Magenta = result;
                    isEvent = false;
                    Update(2);
                }
                else
                {
                    input_magenta.Text = string.Empty;
                    input_magenta.Focus();
                }
            }

        }

        private void Input_yellow_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var yellow = input_yellow.Text;

                if (int.TryParse(yellow, out var result) && result >= 0 && result <= 100)
                {
                    _cmyk.Yellow = result;
                    isEvent = false;
                    Update(2);
                }
                else
                {
                    input_yellow.Text = string.Empty;
                    input_yellow.Focus();
                }
            }
        }

        private void Input_key_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var key = input_key.Text;

                if (int.TryParse(key, out var result) && result >= 0 && result <= 100)
                {
                    _cmyk.Key = result;
                    isEvent = false;
                    Update(2);
                }
                else
                {
                    input_key.Text = string.Empty;
                    input_key.Focus();
                }
            }
        }

        private void CMYK_cyan_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _cmyk.Cyan = CMYK_cyan.Value;
                isEvent = false;
                Update(2);
            }
        }

        private void CMYK_magenta_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _cmyk.Magenta = CMYK_magenta.Value;
                isEvent = false;
                Update(2);
            }
        }

        private void CMYK_yellow_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _cmyk.Yellow = CMYK_yellow.Value;
                isEvent = false;
                Update(2);
            }
        }

        private void CMYK_key_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _cmyk.Key = CMYK_key.Value;
                isEvent = false;
                Update(2);
            }
        }

        private void Input_hue_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var hue = input_hue.Text;

                if (int.TryParse(hue, out var result) && result >= 0 && result <= 360)
                {
                    _hls.Hue = result;
                    isEvent = false;
                    Update(3);
                }
                else
                {
                    input_hue.Text = string.Empty;
                    input_hue.Focus();
                }
            }
        }

        private void Input_lightness_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var lightness = input_lightness.Text;

                if (int.TryParse(lightness, out var result) && result >= 0 && result <= 100)
                {
                    _hls.Lightness = result;
                    isEvent = false;
                    Update(3);
                }
                else
                {
                    input_lightness.Text = string.Empty;
                    input_lightness.Focus();
                }
            }
        }

        private void Input_saturation_Leave(object sender, EventArgs e)
        {
            if (isEvent)
            {
                var saturation = input_saturation.Text;

                if (int.TryParse(saturation, out var result) && result >= 0 && result <= 100)
                {
                    _hls.Saturation = result;
                    isEvent = false;
                    Update(3);
                }
                else
                {
                    input_saturation.Text = string.Empty;
                    input_saturation.Focus();
                }
            }
        }

        private void HLS_hue_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _hls.Hue = HLS_hue.Value;
                isEvent = false;
                Update(3);
            }
        }

        private void HLS_lightness_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _hls.Lightness = HLS_lightness.Value;
                isEvent = false;
                Update(3);
            }

        }

        private void HLS_saturation_Scroll(object sender, EventArgs e)
        {
            if (isEvent)
            {
                _hls.Saturation = HLS_saturation.Value;
                isEvent = false;
                Update(3);
            }

        }



        private void Selector_MouseLeave(object sender, EventArgs e)
        {
            currentColor.BackColor = Color.FromArgb(_rgb.Red, _rgb.Green, _rgb.Blue);
        }

        private void Selector_MouseMove(object sender, MouseEventArgs e)
        {
            var bitmap = new Bitmap(selector.Image);
            currentColor.BackColor = bitmap.GetPixel(e.X, e.Y);
        }

        private void Selector_MouseClick(object sender, MouseEventArgs e)
        {
            var bitmap = new Bitmap(selector.Image);
            var color = bitmap.GetPixel(e.X, e.Y);
            _rgb.Red = color.R;
            _rgb.Green = color.G;
            _rgb.Blue = color.B;
            isEvent = false;
            Update(1);
        }
    }
}