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
            this.xMinTextBox = new System.Windows.Forms.TextBox();
            this.xMaxTextBox = new System.Windows.Forms.TextBox();
            this.yMinTextBox = new System.Windows.Forms.TextBox();
            this.yMaxTextBox = new System.Windows.Forms.TextBox();
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
            this.Julia.ErrorImage = null;
            this.Julia.InitialImage = null;
            this.Julia.Location = new System.Drawing.Point(831, 267);
            this.Julia.Name = "Julia";
            this.Julia.Size = new System.Drawing.Size(575, 350);
            this.Julia.TabIndex = 1;
            this.Julia.TabStop = false;
            // 
            // Mandelbrot
            // 
            this.Mandelbrot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mandelbrot.ErrorImage = null;
            this.Mandelbrot.InitialImage = null;
            this.Mandelbrot.Location = new System.Drawing.Point(12, 12);
            this.Mandelbrot.Name = "Mandelbrot";
            this.Mandelbrot.Size = new System.Drawing.Size(800, 600);
            this.Mandelbrot.TabIndex = 0;
            this.Mandelbrot.TabStop = false;
            this.Mandelbrot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mandelbrot_MouseClick);
            // 
            // newCoords
            // 
            this.newCoords.Location = new System.Drawing.Point(1020, 189);
            this.newCoords.Name = "newCoords";
            this.newCoords.Size = new System.Drawing.Size(219, 72);
            this.newCoords.TabIndex = 5;
            this.newCoords.Text = "Draw New Coordinates";
            this.newCoords.UseVisualStyleBackColor = true;
            this.newCoords.Click += new System.EventHandler(this.newCoords_Click);
            // 
            // xMinTextBox
            // 
            this.xMinTextBox.Location = new System.Drawing.Point(857, 42);
            this.xMinTextBox.Name = "xMinTextBox";
            this.xMinTextBox.Size = new System.Drawing.Size(157, 20);
            this.xMinTextBox.TabIndex = 1;
            // 
            // xMaxTextBox
            // 
            this.xMaxTextBox.Location = new System.Drawing.Point(857, 68);
            this.xMaxTextBox.Name = "xMaxTextBox";
            this.xMaxTextBox.Size = new System.Drawing.Size(157, 20);
            this.xMaxTextBox.TabIndex = 3;
            // 
            // yMinTextBox
            // 
            this.yMinTextBox.Location = new System.Drawing.Point(1245, 42);
            this.yMinTextBox.Name = "yMinTextBox";
            this.yMinTextBox.Size = new System.Drawing.Size(158, 20);
            this.yMinTextBox.TabIndex = 2;
            // 
            // yMaxTextBox
            // 
            this.yMaxTextBox.Location = new System.Drawing.Point(1245, 68);
            this.yMaxTextBox.Name = "yMaxTextBox";
            this.yMaxTextBox.Size = new System.Drawing.Size(158, 20);
            this.yMaxTextBox.TabIndex = 4;
            // 
            // RealLabel
            // 
            this.RealLabel.Location = new System.Drawing.Point(857, 9);
            this.RealLabel.Name = "RealLabel";
            this.RealLabel.Size = new System.Drawing.Size(259, 23);
            this.RealLabel.TabIndex = 1;
            this.RealLabel.Text = "Real Coordinates (X values)";
            this.RealLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImagLabel
            // 
            this.ImagLabel.Location = new System.Drawing.Point(1122, 9);
            this.ImagLabel.Name = "ImagLabel";
            this.ImagLabel.Size = new System.Drawing.Size(281, 23);
            this.ImagLabel.TabIndex = 0;
            this.ImagLabel.Text = "Imaginary Coordinates (Yi values)";
            this.ImagLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // minLabel
            // 
            this.minLabel.Location = new System.Drawing.Point(1020, 42);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(219, 19);
            this.minLabel.TabIndex = 0;
            this.minLabel.Text = "Minimum Value";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxVal
            // 
            this.maxVal.Location = new System.Drawing.Point(1020, 68);
            this.maxVal.Name = "maxVal";
            this.maxVal.Size = new System.Drawing.Size(219, 19);
            this.maxVal.TabIndex = 0;
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
            this.Controls.Add(this.yMaxTextBox);
            this.Controls.Add(this.yMinTextBox);
            this.Controls.Add(this.xMaxTextBox);
            this.Controls.Add(this.xMinTextBox);
            this.Controls.Add(this.newCoords);
            this.Controls.Add(this.Julia);
            this.Controls.Add(this.Mandelbrot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Julia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mandelbrot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Mandelbrot;
        private System.Windows.Forms.PictureBox Julia;
        private System.Windows.Forms.Button newCoords;
        private System.Windows.Forms.TextBox xMinTextBox;
        private System.Windows.Forms.TextBox xMaxTextBox;
        private System.Windows.Forms.TextBox yMinTextBox;
        private System.Windows.Forms.TextBox yMaxTextBox;
        private System.Windows.Forms.Label RealLabel;
        private System.Windows.Forms.Label ImagLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxVal;
    }
}

