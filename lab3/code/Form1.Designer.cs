using OxyPlot.Axes;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.firstPoint = new System.Windows.Forms.TextBox();
            this.secondPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.scale = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.bresenham = new System.Windows.Forms.CheckBox();
            this.stepBystep = new System.Windows.Forms.CheckBox();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Point 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstPoint
            // 
            this.firstPoint.Location = new System.Drawing.Point(908, 37);
            this.firstPoint.Name = "firstPoint";
            this.firstPoint.Size = new System.Drawing.Size(100, 22);
            this.firstPoint.TabIndex = 1;
            // 
            // secondPoint
            // 
            this.secondPoint.Location = new System.Drawing.Point(908, 81);
            this.secondPoint.Name = "secondPoint";
            this.secondPoint.Size = new System.Drawing.Size(100, 22);
            this.secondPoint.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(905, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Point 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(908, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Paint";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(908, 226);
            this.scale.Maximum = 200;
            this.scale.Name = "scale";
            this.scale.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.scale.Size = new System.Drawing.Size(56, 104);
            this.scale.TabIndex = 7;
            this.scale.Value = 100;
            this.scale.Scroll += new System.EventHandler(this.Scale_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(908, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time: 0";
            // 
            // bresenham
            // 
            this.bresenham.AutoSize = true;
            this.bresenham.Checked = true;
            this.bresenham.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bresenham.Location = new System.Drawing.Point(908, 109);
            this.bresenham.Name = "bresenham";
            this.bresenham.Size = new System.Drawing.Size(156, 20);
            this.bresenham.TabIndex = 9;
            this.bresenham.Text = "Bresenham algorithm";
            this.bresenham.UseVisualStyleBackColor = true;
            this.bresenham.CheckedChanged += new System.EventHandler(this.Bresenham_CheckedChanged);
            // 
            // stepBystep
            // 
            this.stepBystep.AutoSize = true;
            this.stepBystep.Location = new System.Drawing.Point(908, 135);
            this.stepBystep.Name = "stepBystep";
            this.stepBystep.Size = new System.Drawing.Size(164, 20);
            this.stepBystep.TabIndex = 10;
            this.stepBystep.Text = "Step-by-step algorithm";
            this.stepBystep.UseVisualStyleBackColor = true;
            this.stepBystep.CheckedChanged += new System.EventHandler(this.StepBystep_CheckedChanged);
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(12, 18);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(870, 537);
            this.plotView1.TabIndex = 11;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 592);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.stepBystep);
            this.Controls.Add(this.bresenham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secondPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstPoint);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstPoint;
        private System.Windows.Forms.TextBox secondPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar scale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox bresenham;
        private System.Windows.Forms.CheckBox stepBystep;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}

