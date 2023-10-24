namespace ComputerGrarphics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Red = new TextBox();
            selector = new PictureBox();
            colorSelector = new Label();
            input_red = new TextBox();
            input_green = new TextBox();
            input_blue = new TextBox();
            input_yellow = new TextBox();
            input_magenta = new TextBox();
            input_cyan = new TextBox();
            input_key = new TextBox();
            input_saturation = new TextBox();
            input_lightness = new TextBox();
            input_hue = new TextBox();
            currentColor = new PictureBox();
            label4 = new Label();
            RGB_red = new TrackBar();
            RGB_green = new TrackBar();
            RGB_blue = new TrackBar();
            CMYK_yellow = new TrackBar();
            CMYK_magenta = new TrackBar();
            CMYK_cyan = new TrackBar();
            CMYK_key = new TrackBar();
            HLS_saturation = new TrackBar();
            HLS_lightness = new TrackBar();
            HLS_hue = new TrackBar();
            down_R = new Label();
            down_B = new Label();
            down_G = new Label();
            groupRGB = new GroupBox();
            groupCMYK = new GroupBox();
            down_K = new Label();
            down_Y = new Label();
            down_M = new Label();
            down_C = new Label();
            groupHLS = new GroupBox();
            down_S = new Label();
            down_L = new Label();
            down_H = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)selector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RGB_red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RGB_green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RGB_blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CMYK_yellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CMYK_magenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CMYK_cyan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CMYK_key).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HLS_saturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HLS_lightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HLS_hue).BeginInit();
            groupRGB.SuspendLayout();
            groupCMYK.SuspendLayout();
            groupHLS.SuspendLayout();
            SuspendLayout();
            // 
            // Red
            // 
            Red.Location = new Point(1192, 46);
            Red.Margin = new Padding(4);
            Red.Name = "Red";
            Red.Size = new Size(174, 27);
            Red.TabIndex = 0;
            // 
            // selector
            // 
            selector.Image = (Image)resources.GetObject("selector.Image");
            selector.Location = new Point(12, 35);
            selector.Name = "selector";
            selector.Size = new Size(226, 156);
            selector.SizeMode = PictureBoxSizeMode.AutoSize;
            selector.TabIndex = 1;
            selector.TabStop = false;
            selector.MouseClick += Selector_MouseClick;
            selector.MouseLeave += Selector_MouseLeave;
            selector.MouseMove += Selector_MouseMove;
            // 
            // colorSelector
            // 
            colorSelector.AutoSize = true;
            colorSelector.Location = new Point(12, 11);
            colorSelector.Name = "colorSelector";
            colorSelector.Size = new Size(108, 19);
            colorSelector.TabIndex = 2;
            colorSelector.Text = "Color selector";
            // 
            // input_red
            // 
            input_red.Location = new Point(439, 33);
            input_red.Name = "input_red";
            input_red.PlaceholderText = "red";
            input_red.Size = new Size(125, 27);
            input_red.TabIndex = 4;
            input_red.Text = "255";
            input_red.Leave += Input_red_Leave;
            // 
            // input_green
            // 
            input_green.Location = new Point(439, 66);
            input_green.Name = "input_green";
            input_green.PlaceholderText = "green";
            input_green.Size = new Size(125, 27);
            input_green.TabIndex = 5;
            input_green.Text = "255";
            input_green.Leave += Input_green_Leave;
            // 
            // input_blue
            // 
            input_blue.Location = new Point(439, 99);
            input_blue.Name = "input_blue";
            input_blue.PlaceholderText = "blue";
            input_blue.Size = new Size(125, 27);
            input_blue.TabIndex = 6;
            input_blue.Text = "255";
            input_blue.Leave += Input_blue_Leave;
            // 
            // input_yellow
            // 
            input_yellow.Location = new Point(593, 101);
            input_yellow.Name = "input_yellow";
            input_yellow.Size = new Size(125, 27);
            input_yellow.TabIndex = 10;
            input_yellow.Text = "0";
            input_yellow.Leave += Input_yellow_Leave;
            // 
            // input_magenta
            // 
            input_magenta.Location = new Point(593, 68);
            input_magenta.Name = "input_magenta";
            input_magenta.Size = new Size(125, 27);
            input_magenta.TabIndex = 9;
            input_magenta.Text = "0";
            input_magenta.Leave += Input_magenta_Leave;
            // 
            // input_cyan
            // 
            input_cyan.Location = new Point(593, 35);
            input_cyan.Name = "input_cyan";
            input_cyan.Size = new Size(125, 27);
            input_cyan.TabIndex = 8;
            input_cyan.Text = "0";
            input_cyan.Leave += Input_cyan_Leave;
            // 
            // input_key
            // 
            input_key.Location = new Point(593, 134);
            input_key.Name = "input_key";
            input_key.Size = new Size(125, 27);
            input_key.TabIndex = 11;
            input_key.Text = "0";
            input_key.Leave += Input_key_Leave;
            // 
            // input_saturation
            // 
            input_saturation.Location = new Point(754, 101);
            input_saturation.Name = "input_saturation";
            input_saturation.Size = new Size(125, 27);
            input_saturation.TabIndex = 15;
            input_saturation.Text = "0";
            input_saturation.Leave += Input_saturation_Leave;
            // 
            // input_lightness
            // 
            input_lightness.Location = new Point(754, 68);
            input_lightness.Name = "input_lightness";
            input_lightness.Size = new Size(125, 27);
            input_lightness.TabIndex = 14;
            input_lightness.Text = "100";
            input_lightness.Leave += Input_lightness_Leave;
            // 
            // input_hue
            // 
            input_hue.Location = new Point(754, 35);
            input_hue.Name = "input_hue";
            input_hue.Size = new Size(125, 27);
            input_hue.TabIndex = 13;
            input_hue.Text = "0";
            input_hue.Leave += Input_hue_Leave;
            // 
            // currentColor
            // 
            currentColor.Location = new Point(261, 35);
            currentColor.Name = "currentColor";
            currentColor.Size = new Size(60, 60);
            currentColor.TabIndex = 16;
            currentColor.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 11);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 17;
            label4.Text = "current";
            // 
            // RGB_red
            // 
            RGB_red.AllowDrop = true;
            RGB_red.Location = new Point(439, 187);
            RGB_red.Maximum = 255;
            RGB_red.Name = "RGB_red";
            RGB_red.Size = new Size(125, 56);
            RGB_red.TabIndex = 18;
            RGB_red.Tag = "";
            RGB_red.Value = 255;
            RGB_red.Scroll += RGB_red_Scroll;
            // 
            // RGB_green
            // 
            RGB_green.Location = new Point(439, 249);
            RGB_green.Maximum = 255;
            RGB_green.Name = "RGB_green";
            RGB_green.Size = new Size(125, 56);
            RGB_green.TabIndex = 19;
            RGB_green.Tag = "int";
            RGB_green.Value = 255;
            RGB_green.Scroll += RGB_green_Scroll;
            // 
            // RGB_blue
            // 
            RGB_blue.Location = new Point(439, 311);
            RGB_blue.Maximum = 255;
            RGB_blue.Name = "RGB_blue";
            RGB_blue.Size = new Size(125, 56);
            RGB_blue.TabIndex = 20;
            RGB_blue.Tag = "int";
            RGB_blue.Value = 255;
            RGB_blue.Scroll += RGB_blue_Scroll;
            // 
            // CMYK_yellow
            // 
            CMYK_yellow.Location = new Point(593, 311);
            CMYK_yellow.Maximum = 100;
            CMYK_yellow.Name = "CMYK_yellow";
            CMYK_yellow.Size = new Size(125, 56);
            CMYK_yellow.TabIndex = 23;
            CMYK_yellow.Tag = "int";
            CMYK_yellow.Scroll += CMYK_yellow_Scroll;
            // 
            // CMYK_magenta
            // 
            CMYK_magenta.Location = new Point(593, 249);
            CMYK_magenta.Maximum = 100;
            CMYK_magenta.Name = "CMYK_magenta";
            CMYK_magenta.Size = new Size(125, 56);
            CMYK_magenta.TabIndex = 22;
            CMYK_magenta.Tag = "int";
            CMYK_magenta.Scroll += CMYK_magenta_Scroll;
            // 
            // CMYK_cyan
            // 
            CMYK_cyan.Location = new Point(593, 187);
            CMYK_cyan.Maximum = 100;
            CMYK_cyan.Name = "CMYK_cyan";
            CMYK_cyan.Size = new Size(125, 56);
            CMYK_cyan.TabIndex = 21;
            CMYK_cyan.Tag = "int";
            CMYK_cyan.Scroll += CMYK_cyan_Scroll;
            // 
            // CMYK_key
            // 
            CMYK_key.Location = new Point(593, 373);
            CMYK_key.Maximum = 100;
            CMYK_key.Name = "CMYK_key";
            CMYK_key.Size = new Size(125, 56);
            CMYK_key.TabIndex = 24;
            CMYK_key.Tag = "int";
            CMYK_key.Scroll += CMYK_key_Scroll;
            // 
            // HLS_saturation
            // 
            HLS_saturation.Location = new Point(754, 311);
            HLS_saturation.Maximum = 100;
            HLS_saturation.Name = "HLS_saturation";
            HLS_saturation.Size = new Size(125, 56);
            HLS_saturation.TabIndex = 27;
            HLS_saturation.Tag = "int";
            HLS_saturation.Scroll += HLS_saturation_Scroll;
            // 
            // HLS_lightness
            // 
            HLS_lightness.Location = new Point(754, 247);
            HLS_lightness.Maximum = 100;
            HLS_lightness.Name = "HLS_lightness";
            HLS_lightness.Size = new Size(125, 56);
            HLS_lightness.TabIndex = 26;
            HLS_lightness.Tag = "int";
            HLS_lightness.Value = 100;
            HLS_lightness.Scroll += HLS_lightness_Scroll;
            // 
            // HLS_hue
            // 
            HLS_hue.Location = new Point(754, 187);
            HLS_hue.Maximum = 360;
            HLS_hue.Name = "HLS_hue";
            HLS_hue.Size = new Size(125, 56);
            HLS_hue.TabIndex = 25;
            HLS_hue.Tag = "int";
            HLS_hue.Scroll += HLS_hue_Scroll;
            // 
            // down_R
            // 
            down_R.AutoSize = true;
            down_R.Location = new Point(6, 23);
            down_R.Name = "down_R";
            down_R.Size = new Size(32, 19);
            down_R.TabIndex = 28;
            down_R.Text = "R: 0";
            // 
            // down_B
            // 
            down_B.AutoSize = true;
            down_B.Location = new Point(176, 23);
            down_B.Name = "down_B";
            down_B.Size = new Size(34, 19);
            down_B.TabIndex = 29;
            down_B.Text = "B: 0";
            // 
            // down_G
            // 
            down_G.AutoSize = true;
            down_G.Location = new Point(94, 23);
            down_G.Name = "down_G";
            down_G.Size = new Size(34, 19);
            down_G.TabIndex = 30;
            down_G.Text = "G: 0";
            // 
            // groupRGB
            // 
            groupRGB.Controls.Add(down_R);
            groupRGB.Controls.Add(down_B);
            groupRGB.Controls.Add(down_G);
            groupRGB.Location = new Point(12, 497);
            groupRGB.Name = "groupRGB";
            groupRGB.Size = new Size(250, 58);
            groupRGB.TabIndex = 31;
            groupRGB.TabStop = false;
            groupRGB.Text = "RGB";
            // 
            // groupCMYK
            // 
            groupCMYK.Controls.Add(down_K);
            groupCMYK.Controls.Add(down_Y);
            groupCMYK.Controls.Add(down_M);
            groupCMYK.Controls.Add(down_C);
            groupCMYK.Location = new Point(277, 497);
            groupCMYK.Name = "groupCMYK";
            groupCMYK.Size = new Size(343, 58);
            groupCMYK.TabIndex = 32;
            groupCMYK.TabStop = false;
            groupCMYK.Text = "CMYK";
            // 
            // down_K
            // 
            down_K.AutoSize = true;
            down_K.Location = new Point(272, 23);
            down_K.Name = "down_K";
            down_K.Size = new Size(33, 19);
            down_K.TabIndex = 34;
            down_K.Text = "K: 0";
            // 
            // down_Y
            // 
            down_Y.AutoSize = true;
            down_Y.Location = new Point(190, 23);
            down_Y.Name = "down_Y";
            down_Y.Size = new Size(32, 19);
            down_Y.TabIndex = 34;
            down_Y.Text = "Y: 0";
            // 
            // down_M
            // 
            down_M.AutoSize = true;
            down_M.Location = new Point(111, 23);
            down_M.Name = "down_M";
            down_M.Size = new Size(37, 19);
            down_M.TabIndex = 34;
            down_M.Text = "M: 0";
            // 
            // down_C
            // 
            down_C.AutoSize = true;
            down_C.Location = new Point(33, 23);
            down_C.Name = "down_C";
            down_C.Size = new Size(34, 19);
            down_C.TabIndex = 34;
            down_C.Text = "C: 0";
            // 
            // groupHLS
            // 
            groupHLS.Controls.Add(down_S);
            groupHLS.Controls.Add(down_L);
            groupHLS.Controls.Add(down_H);
            groupHLS.Location = new Point(640, 497);
            groupHLS.Name = "groupHLS";
            groupHLS.Size = new Size(250, 58);
            groupHLS.TabIndex = 33;
            groupHLS.TabStop = false;
            groupHLS.Text = "HLS";
            // 
            // down_S
            // 
            down_S.AutoSize = true;
            down_S.Location = new Point(189, 23);
            down_S.Name = "down_S";
            down_S.Size = new Size(32, 19);
            down_S.TabIndex = 35;
            down_S.Text = "S: 0";
            // 
            // down_L
            // 
            down_L.AutoSize = true;
            down_L.Location = new Point(114, 23);
            down_L.Name = "down_L";
            down_L.Size = new Size(32, 19);
            down_L.TabIndex = 35;
            down_L.Text = "L: 0";
            // 
            // down_H
            // 
            down_H.AutoSize = true;
            down_H.Location = new Point(33, 23);
            down_H.Name = "down_H";
            down_H.Size = new Size(35, 19);
            down_H.TabIndex = 35;
            down_H.Text = "H: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(479, 11);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 38;
            label1.Text = "RGB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(624, 13);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 39;
            label2.Text = "CMYK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(787, 13);
            label3.Name = "label3";
            label3.Size = new Size(36, 19);
            label3.TabIndex = 40;
            label3.Text = "HLS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 567);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupHLS);
            Controls.Add(groupCMYK);
            Controls.Add(groupRGB);
            Controls.Add(HLS_saturation);
            Controls.Add(HLS_lightness);
            Controls.Add(HLS_hue);
            Controls.Add(CMYK_key);
            Controls.Add(CMYK_yellow);
            Controls.Add(CMYK_magenta);
            Controls.Add(CMYK_cyan);
            Controls.Add(RGB_blue);
            Controls.Add(RGB_green);
            Controls.Add(RGB_red);
            Controls.Add(label4);
            Controls.Add(currentColor);
            Controls.Add(input_saturation);
            Controls.Add(input_lightness);
            Controls.Add(input_hue);
            Controls.Add(input_key);
            Controls.Add(input_yellow);
            Controls.Add(input_magenta);
            Controls.Add(input_cyan);
            Controls.Add(input_blue);
            Controls.Add(input_green);
            Controls.Add(input_red);
            Controls.Add(colorSelector);
            Controls.Add(selector);
            Controls.Add(Red);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Converter";
            ((System.ComponentModel.ISupportInitialize)selector).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)RGB_red).EndInit();
            ((System.ComponentModel.ISupportInitialize)RGB_green).EndInit();
            ((System.ComponentModel.ISupportInitialize)RGB_blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)CMYK_yellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)CMYK_magenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)CMYK_cyan).EndInit();
            ((System.ComponentModel.ISupportInitialize)CMYK_key).EndInit();
            ((System.ComponentModel.ISupportInitialize)HLS_saturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)HLS_lightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)HLS_hue).EndInit();
            groupRGB.ResumeLayout(false);
            groupRGB.PerformLayout();
            groupCMYK.ResumeLayout(false);
            groupCMYK.PerformLayout();
            groupHLS.ResumeLayout(false);
            groupHLS.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private TextBox Red;
        private PictureBox selector;
        private Label colorSelector;
        private TextBox input_red;
        private TextBox input_green;
        private TextBox input_blue;
        private TextBox input_yellow;
        private TextBox input_magenta;
        private TextBox input_cyan;
        private TextBox input_key;
        private TextBox input_saturation;
        private TextBox input_lightness;
        private TextBox input_hue;
        private PictureBox currentColor;
        private Label label4;
        private TrackBar RGB_red;
        private TrackBar RGB_green;
        private TrackBar RGB_blue;
        private TrackBar CMYK_yellow;
        private TrackBar CMYK_magenta;
        private TrackBar CMYK_cyan;
        private TrackBar CMYK_key;
        private TrackBar HLS_saturation;
        private TrackBar HLS_lightness;
        private TrackBar HLS_hue;
        private Label down_R;
        private Label down_B;
        private Label down_G;
        private GroupBox groupRGB;
        private GroupBox groupCMYK;
        private Label down_K;
        private Label down_Y;
        private Label down_M;
        private Label down_C;
        private GroupBox groupHLS;
        private Label down_S;
        private Label down_L;
        private Label down_H;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}