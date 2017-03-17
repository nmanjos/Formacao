namespace ocrexample
{
    partial class image_load
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
            this.ImageOCR = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.getfile = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOCR)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageOCR
            // 
            this.ImageOCR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImageOCR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageOCR.Location = new System.Drawing.Point(81, 1);
            this.ImageOCR.Name = "ImageOCR";
            this.ImageOCR.Size = new System.Drawing.Size(1024, 768);
            this.ImageOCR.TabIndex = 0;
            this.ImageOCR.TabStop = false;
            this.ImageOCR.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageOCR_Paint);
            this.ImageOCR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageOCR_MouseDown);
            this.ImageOCR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageOCR_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // getfile
            // 
            this.getfile.FileName = "image.jpg";
            this.getfile.InitialDirectory = "$USER$";
            this.getfile.Title = "Open File";
            this.getfile.FileOk += new System.ComponentModel.CancelEventHandler(this.getfile_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // image_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1108, 741);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImageOCR);
            this.Name = "image_load";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image_Load";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ImageOCR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageOCR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog getfile;
        private System.Windows.Forms.Button button2;
    }
}