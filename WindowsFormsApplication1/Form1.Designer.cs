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
            this.Mandelbrot = new System.Windows.Forms.PictureBox();
            this.Julia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mandelbrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Julia)).BeginInit();
            this.SuspendLayout();
            // 
            // Mandelbrot
            // 
            this.Mandelbrot.Location = new System.Drawing.Point(12, 12);
            this.Mandelbrot.Name = "Mandelbrot";
            this.Mandelbrot.Size = new System.Drawing.Size(813, 604);
            this.Mandelbrot.TabIndex = 0;
            this.Mandelbrot.TabStop = false;
            // 
            // Julia
            // 
            this.Julia.Location = new System.Drawing.Point(831, 267);
            this.Julia.Name = "Julia";
            this.Julia.Size = new System.Drawing.Size(572, 349);
            this.Julia.TabIndex = 1;
            this.Julia.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 628);
            this.Controls.Add(this.Julia);
            this.Controls.Add(this.Mandelbrot);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Mandelbrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Julia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Mandelbrot;
        private System.Windows.Forms.PictureBox Julia;
    }
}

