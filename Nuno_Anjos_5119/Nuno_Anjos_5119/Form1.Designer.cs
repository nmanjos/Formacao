namespace Nuno_Anjos_5119
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
            this.txtInputA = new System.Windows.Forms.TextBox();
            this.lblInputA = new System.Windows.Forms.Label();
            this.lblInputB = new System.Windows.Forms.Label();
            this.txtInputB = new System.Windows.Forms.TextBox();
            this.rtxtResultA = new System.Windows.Forms.RichTextBox();
            this.lblResultA = new System.Windows.Forms.Label();
            this.lblResultB = new System.Windows.Forms.Label();
            this.rtxtResultB = new System.Windows.Forms.RichTextBox();
            this.btMatriz = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btScores = new System.Windows.Forms.Button();
            this.btContagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputA
            // 
            this.txtInputA.Location = new System.Drawing.Point(78, 12);
            this.txtInputA.Name = "txtInputA";
            this.txtInputA.Size = new System.Drawing.Size(271, 20);
            this.txtInputA.TabIndex = 0;
            // 
            // lblInputA
            // 
            this.lblInputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputA.Location = new System.Drawing.Point(12, 12);
            this.lblInputA.Name = "lblInputA";
            this.lblInputA.Size = new System.Drawing.Size(60, 20);
            this.lblInputA.TabIndex = 1;
            this.lblInputA.Text = "Input A";
            this.lblInputA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInputB
            // 
            this.lblInputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputB.Location = new System.Drawing.Point(12, 38);
            this.lblInputB.Name = "lblInputB";
            this.lblInputB.Size = new System.Drawing.Size(60, 20);
            this.lblInputB.TabIndex = 3;
            this.lblInputB.Text = "Input B";
            this.lblInputB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInputB
            // 
            this.txtInputB.Location = new System.Drawing.Point(78, 38);
            this.txtInputB.Name = "txtInputB";
            this.txtInputB.Size = new System.Drawing.Size(271, 20);
            this.txtInputB.TabIndex = 2;
            // 
            // rtxtResultA
            // 
            this.rtxtResultA.Location = new System.Drawing.Point(10, 101);
            this.rtxtResultA.Name = "rtxtResultA";
            this.rtxtResultA.Size = new System.Drawing.Size(339, 96);
            this.rtxtResultA.TabIndex = 4;
            this.rtxtResultA.Text = "";
            // 
            // lblResultA
            // 
            this.lblResultA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultA.Location = new System.Drawing.Point(10, 78);
            this.lblResultA.Name = "lblResultA";
            this.lblResultA.Size = new System.Drawing.Size(339, 20);
            this.lblResultA.TabIndex = 5;
            this.lblResultA.Text = "Resultado A";
            this.lblResultA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultB
            // 
            this.lblResultB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultB.Location = new System.Drawing.Point(10, 209);
            this.lblResultB.Name = "lblResultB";
            this.lblResultB.Size = new System.Drawing.Size(339, 20);
            this.lblResultB.TabIndex = 7;
            this.lblResultB.Text = "Resultado B";
            this.lblResultB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtResultB
            // 
            this.rtxtResultB.Location = new System.Drawing.Point(10, 232);
            this.rtxtResultB.Name = "rtxtResultB";
            this.rtxtResultB.Size = new System.Drawing.Size(339, 96);
            this.rtxtResultB.TabIndex = 6;
            this.rtxtResultB.Text = "";
            // 
            // btMatriz
            // 
            this.btMatriz.Location = new System.Drawing.Point(10, 334);
            this.btMatriz.Name = "btMatriz";
            this.btMatriz.Size = new System.Drawing.Size(83, 47);
            this.btMatriz.TabIndex = 8;
            this.btMatriz.Text = "MATRIZ";
            this.btMatriz.UseVisualStyleBackColor = true;
            this.btMatriz.Click += new System.EventHandler(this.btMatriz_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(266, 334);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(83, 47);
            this.btDel.TabIndex = 9;
            this.btDel.Text = "DEL";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btScores
            // 
            this.btScores.Location = new System.Drawing.Point(180, 334);
            this.btScores.Name = "btScores";
            this.btScores.Size = new System.Drawing.Size(83, 47);
            this.btScores.TabIndex = 10;
            this.btScores.Text = "SCORES";
            this.btScores.UseVisualStyleBackColor = true;
            this.btScores.Click += new System.EventHandler(this.btScores_Click);
            // 
            // btContagem
            // 
            this.btContagem.Location = new System.Drawing.Point(95, 334);
            this.btContagem.Name = "btContagem";
            this.btContagem.Size = new System.Drawing.Size(83, 47);
            this.btContagem.TabIndex = 11;
            this.btContagem.Text = "CONTAGEM";
            this.btContagem.UseVisualStyleBackColor = true;
            this.btContagem.Click += new System.EventHandler(this.btContagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 383);
            this.Controls.Add(this.btContagem);
            this.Controls.Add(this.btScores);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btMatriz);
            this.Controls.Add(this.lblResultB);
            this.Controls.Add(this.rtxtResultB);
            this.Controls.Add(this.lblResultA);
            this.Controls.Add(this.rtxtResultA);
            this.Controls.Add(this.lblInputB);
            this.Controls.Add(this.txtInputB);
            this.Controls.Add(this.lblInputA);
            this.Controls.Add(this.txtInputA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.Label lblInputA;
        private System.Windows.Forms.Label lblInputB;
        private System.Windows.Forms.TextBox txtInputB;
        private System.Windows.Forms.RichTextBox rtxtResultA;
        private System.Windows.Forms.Label lblResultA;
        private System.Windows.Forms.Label lblResultB;
        private System.Windows.Forms.RichTextBox rtxtResultB;
        private System.Windows.Forms.Button btMatriz;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btScores;
        private System.Windows.Forms.Button btContagem;
    }
}

