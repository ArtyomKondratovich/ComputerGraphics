using System.DirectoryServices.ActiveDirectory;
using System.Runtime.InteropServices.ObjectiveC;

namespace ComputerGrarphics
{
    public partial class Form1 : Form
    {
        private readonly ColorModelRgb _rgb = new(255, 255, 255);

        private readonly ColorModelCmyk _cmyk = new(0, 0, 0, 0);

        private readonly ColorModelHls _hls = new(0, 100, 0);

        public Form1()
        {
            InitializeComponent();
            UpdateRGB();
            UpdateCMYK();
            UpdateHLS();
        }

        private void RGB_red_ValueChanged(object sender, EventArgs e)
        {
            _rgb.Red = RGB_red.Value;
            UpdateRGB();
            UpdateColor(1);
        }

        private void RGB_green_ValueChanged(object sender, EventArgs e)
        {
            _rgb.Green = RGB_green.Value;
            UpdateRGB();
            UpdateColor(1);
        }

        private void RGB_blue_ValueChanged(object sender, EventArgs e)
        {
            _rgb.Blue = RGB_blue.Value;
            UpdateRGB();
            UpdateColor(1);
        }

        private void Input_Red_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_red.Text, out var result) && result >= 0 && result <= 255)
            {
                _rgb.Red = result;
                UpdateRGB();
                UpdateColor(1);
            }
            else
            {
                input_red.Text = "";
                input_red.Focus();
            }
        }

        private void Input_Green_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_green.Text, out var result) && result >= 0 && result <= 255)
            {
                _rgb.Green = result;
                UpdateRGB();
                UpdateColor(1);
            }
            else
            {
                input_green.Text = "";
                input_green.Focus();
            }
        }

        private void Input_Blue_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_blue.Text, out var result) && result >= 0 && result <= 255)
            {
                _rgb.Blue = result;
                UpdateRGB();
                UpdateColor(1);
            }
            else
            {
                input_blue.Text = "";
                input_blue.Focus();
            }
        }

        private void CMYK_cyan_Scroll(object sender, EventArgs e)
        {
            _cmyk.Cyan = CMYK_cyan.Value;
            UpdateCMYK();
            UpdateColor(2);
        }

        private void CMYK_magenta_Scroll(object sender, EventArgs e)
        {
            _cmyk.Magenta = CMYK_magenta.Value;
            UpdateCMYK();
            UpdateColor(2);
        }

        private void CMYK_yellow_Scroll(object sender, EventArgs e)
        {
            _cmyk.Yellow = CMYK_yellow.Value;
            UpdateCMYK();
            UpdateColor(2);
        }

        private void CMYK_key_Scroll(object sender, EventArgs e)
        {
            _cmyk.Key = CMYK_key.Value;
            UpdateCMYK();
            UpdateColor(2);
        }

        private void Input_Cyan_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_cyan.Text, out var result) && result >= 0 && result <= 100)
            {
                _cmyk.Cyan = result;
                UpdateCMYK();
                UpdateColor(2);
            }
            else
            {
                input_cyan.Text = "";
                input_cyan.Focus();
            }
        }

        private void Input_Magenta_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_magenta.Text, out var result) && result >= 0 && result <= 100)
            {
                _cmyk.Magenta = result;
                UpdateCMYK();
                UpdateColor(2);
            }
            else
            {
                input_magenta.Text = "";
                input_magenta.Focus();
            }
        }

        private void Input_Yellow_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_yellow.Text, out var result) && result >= 0 && result <= 100)
            {
                _cmyk.Yellow = result;
                UpdateCMYK();
                UpdateColor(2);
            }
            else
            {
                input_yellow.Text = "";
                input_yellow.Focus();
            }
        }

        private void Input_Key_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_key.Text, out var result) && result >= 0 && result <= 100)
            {
                _cmyk.Key = result;
                UpdateCMYK();
                UpdateColor(2);
            }
            else
            {
                input_key.Text = "";
                input_key.Focus();
            }
        }

        private void HLS_hue_Scroll(object sender, EventArgs e)
        {
            _hls.Hue = HLS_hue.Value;
            UpdateHLS();
            UpdateColor(3);
        }

        private void HLS_lightness_Scroll(object sender, EventArgs e)
        {
            _hls.Lightness = HLS_lightness.Value;
            UpdateHLS();
            UpdateColor(3);
        }

        private void HLS_saturation_Scroll(object sender, EventArgs e)
        {
            _hls.Saturation = HLS_saturation.Value;
            UpdateHLS();
            UpdateColor(3);
        }

        private void Input_hue_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_hue.Text, out var result) && result >= 0 && result <= 360)
            {
                _hls.Hue = result;
                UpdateHLS();
                UpdateColor(3);
            }
            else
            {
                input_hue.Text = "";
                input_hue.Focus();
            }
        }

        private void Input_lightness_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_lightness.Text, out var result) && result >= 0 && result <= 100)
            {
                _hls.Lightness = result;
                UpdateHLS();
                UpdateColor(3);
            }
            else
            {
                input_lightness.Text = "";
                input_lightness.Focus();
            }
        }

        private void Input_saturation_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(input_saturation.Text, out var result) && result >= 0 && result <= 100)
            {
                _hls.Saturation = result;
                UpdateHLS();
                UpdateColor(3);
            }
            else
            {
                input_saturation.Text = "";
                input_saturation.Focus();
            }
        }

        private void UpdateColor(int n)
        {
            switch (n)
            {
                case 1:
                    var rc = ColorModelsConverter.ConvertToCmyk(_rgb);
                    var rh = ColorModelsConverter.ConvertToHls(_rgb);

                    _cmyk.Cyan = rc.Cyan;
                    _cmyk.Magenta = rc.Magenta;
                    _cmyk.Yellow = rc.Yellow;
                    _cmyk.Key = rc.Key;

                    _hls.Hue = rh.Hue;
                    _hls.Saturation = rh.Saturation;
                    _hls.Lightness = rh.Lightness;
                    UpdateCMYK();
                    UpdateHLS();

                    break;
                case 2:
                    var cr = ColorModelsConverter.ConvertToRgb(_cmyk);
                    var ch = ColorModelsConverter.ConvertToHls(_cmyk);

                    _rgb.Red = cr.Red;
                    _rgb.Green = cr.Green;
                    _rgb.Blue = cr.Blue;

                    _hls.Hue = ch.Hue;
                    _hls.Saturation = ch.Saturation;
                    _hls.Lightness = ch.Lightness;
                    UpdateRGB();
                    UpdateHLS();

                    break;
                case 3:
                    var hr = ColorModelsConverter.ConvertToRgb(_hls);
                    var hc = ColorModelsConverter.ConvertToCmyk(_hls);

                    _rgb.Red = hr.Red;
                    _rgb.Green = hr.Green;
                    _rgb.Blue = hr.Blue;

                    _cmyk.Cyan = hc.Cyan;
                    _cmyk.Magenta = hc.Magenta;
                    _cmyk.Yellow = hc.Yellow;
                    _cmyk.Key = hc.Key;
                    UpdateRGB();
                    UpdateCMYK();

                    break;
            }

            currentColor.BackColor = Color.FromArgb(_rgb.Red, _rgb.Green, _rgb.Blue);
        }

        private void UpdateRGB()
        {
            input_red.Text = _rgb.Red.ToString();
            input_green.Text = _rgb.Green.ToString();
            input_blue.Text = _rgb.Blue.ToString();

            RGB_red.Value = _rgb.Red;
            RGB_green.Value = _rgb.Green;
            RGB_blue.Value = _rgb.Blue;

            down_R.Text = $"R: {_rgb.Red}";
            down_G.Text = $"G: {_rgb.Green}";
            down_B.Text = $"B: {_rgb.Blue}";
        }

        private void UpdateCMYK()
        {
            input_cyan.Text = _cmyk.Cyan.ToString();
            input_magenta.Text = _cmyk.Magenta.ToString();
            input_yellow.Text = _cmyk.Yellow.ToString();
            input_key.Text = _cmyk.Key.ToString();

            CMYK_cyan.Value = _cmyk.Cyan;
            CMYK_magenta.Value = _cmyk.Magenta;
            CMYK_yellow.Value = _cmyk.Yellow;
            CMYK_key.Value = _cmyk.Key;

            down_C.Text = $"C: {_cmyk.Cyan}";
            down_M.Text = $"M: {_cmyk.Magenta}";
            down_Y.Text = $"Y: {_cmyk.Yellow}";
            down_K.Text = $"K: {_cmyk.Key}";
        }

        private void UpdateHLS()
        {
            input_hue.Text = _hls.Hue.ToString();
            input_lightness.Text = _hls.Lightness.ToString();
            input_saturation.Text = _hls.Saturation.ToString();

            HLS_hue.Value = _hls.Hue;
            HLS_lightness.Value = _hls.Lightness;
            HLS_saturation.Value = _hls.Saturation;

            down_H.Text = $"H: {_hls.Hue}";
            down_L.Text = $"L: {_hls.Lightness}";
            down_S.Text = $"S: {_hls.Saturation}";
        }

        private void Selector_MouseMove(object sender, MouseEventArgs e)
        {
            var bitmap = (Bitmap)selector.Image;

            Color color = bitmap.GetPixel(e.X, e.Y);

            currentColor.BackColor = color;
        }

        private void Selector_MouseDown(object sender, MouseEventArgs e)
        {
            var bitmap = (Bitmap)selector.Image;

            Color color = bitmap.GetPixel(e.X, e.Y);

            _rgb.Red = color.R;
            _rgb.Green = color.G;
            _rgb.Blue = color.B;

            UpdateRGB();
            UpdateColor(1);
        }

        private void convert_Click(object sender, EventArgs e)
        {
            int n;
            if (rgb.Checked)
                n = 1;
            else if (cmyk.Checked)
                n = 2;
            else
                n = 3;

            UpdateColor(n);
        }

        private void rgb_CheckedChanged(object sender, EventArgs e)
        {
            if (rgb.Checked)
            {
                cmyk.Checked = false;
                hls.Checked = false;
            }
        }

        private void cmyk_CheckedChanged(object sender, EventArgs e)
        {
            if (cmyk.Checked)
            {
                rgb.Checked = false;
                hls.Checked = false;
            }
        }

        private void hls_CheckedChanged(object sender, EventArgs e)
        {
            if (hls.Checked)
            {
                rgb.Checked = false;
                cmyk.Checked = false;
            }
        }
    }
}