namespace LR_17_Form_HTTP_API
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
            ImageDogi = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImageDogi).BeginInit();
            SuspendLayout();
            // 
            // ImageDogi
            // 
            ImageDogi.Location = new Point(25, 21);
            ImageDogi.Name = "ImageDogi";
            ImageDogi.Size = new Size(707, 362);
            ImageDogi.TabIndex = 0;
            ImageDogi.TabStop = false;
            ImageDogi.Click += ImageDogi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ImageDogi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ImageDogi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ImageDogi;
    }
}