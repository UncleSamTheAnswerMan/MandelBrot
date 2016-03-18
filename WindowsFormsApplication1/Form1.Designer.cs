namespace WindowsFormsApplication1
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
            this.Julia = new System.Windows.Forms.PictureBox();
            this.Mandelbrot = new System.Windows.Forms.PictureBox();
            this.newCoords = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.RealLabel = new System.Windows.Forms.Label();
            this.ImagLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Julia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mandelbrot)).BeginInit();
            this.SuspendLayout();
            // 
            // Julia
            // 
            this.Julia.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.IMG_73925582093831;
            this.Julia.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.IMG_73925582093831;
            this.Julia.InitialImage = global::WindowsFormsApplication1.Properties.Resources.IMG_73925582093831;
            this.Julia.Location = new System.Drawing.Point(831, 267);
            this.Julia.Name = "Julia";
            this.Julia.Size = new System.Drawing.Size(572, 349);
            this.Julia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Julia.TabIndex = 1;
            this.Julia.TabStop = false;
            // 
            // Mandelbrot
            // 
            this.Mandelbrot.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources._20140906_161616;
            this.Mandelbrot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mandelbrot.ErrorImage = global::WindowsFormsApplication1.Properties.Resources._20140906_161616;
            this.Mandelbrot.InitialImage = global::WindowsFormsApplication1.Properties.Resources._20140906_161616;
            this.Mandelbrot.Location = new System.Drawing.Point(12, 12);
            this.Mandelbrot.Name = "Mandelbrot";
            this.Mandelbrot.Size = new System.Drawing.Size(813, 604);
            this.Mandelbrot.TabIndex = 0;
            this.Mandelbrot.TabStop = false;
            // 
            // newCoords
            // 
            this.newCoords.Location = new System.Drawing.Point(1020, 189);
            this.newCoords.Name = "newCoords";
            this.newCoords.Size = new System.Drawing.Size(219, 72);
            this.newCoords.TabIndex = 2;
            this.newCoords.Text = "Draw New Coordinates";
            this.newCoords.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(857, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(857, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1245, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1245, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 20);
            this.textBox4.TabIndex = 6;
            // 
            // RealLabel
            // 
            this.RealLabel.Location = new System.Drawing.Point(857, 9);
            this.RealLabel.Name = "RealLabel";
            this.RealLabel.Size = new System.Drawing.Size(259, 23);
            this.RealLabel.TabIndex = 7;
            this.RealLabel.Text = "Real Coordinates (X values)";
            this.RealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImagLabel
            // 
            this.ImagLabel.Location = new System.Drawing.Point(1122, 9);
            this.ImagLabel.Name = "ImagLabel";
            this.ImagLabel.Size = new System.Drawing.Size(281, 23);
            this.ImagLabel.TabIndex = 8;
            this.ImagLabel.Text = "Imaginary Coordinates (Yi values)";
            this.ImagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minLabel
            // 
            this.minLabel.Location = new System.Drawing.Point(1020, 42);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(219, 19);
            this.minLabel.TabIndex = 9;
            this.minLabel.Text = "Minimum Value";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxVal
            // 
            this.maxVal.Location = new System.Drawing.Point(1020, 68);
            this.maxVal.Name = "maxVal";
            this.maxVal.Size = new System.Drawing.Size(219, 19);
            this.maxVal.TabIndex = 10;
            this.maxVal.Text = "Maximum Value";
            this.maxVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 628);
            this.Controls.Add(this.maxVal);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.ImagLabel);
            this.Controls.Add(this.RealLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newCoords);
            this.Controls.Add(this.Julia);
            this.Controls.Add(this.Mandelbrot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Julia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mandelbrot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Mandelbrot;
        private System.Windows.Forms.PictureBox Julia;
        private System.Windows.Forms.Button newCoords;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label RealLabel;
        private System.Windows.Forms.Label ImagLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxVal;
    }
}

