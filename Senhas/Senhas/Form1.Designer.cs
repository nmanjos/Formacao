namespace Senhas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Titulo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PrioPublico = new System.Windows.Forms.Label();
            this.GeralPublico = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ultimasenha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NovoPrio = new System.Windows.Forms.Button();
            this.NovoGeral = new System.Windows.Forms.Button();
            this.Balcao3 = new System.Windows.Forms.Button();
            this.Balcao2 = new System.Windows.Forms.Button();
            this.Balcao1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Titulo);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.PrioPublico);
            this.splitContainer1.Panel1.Controls.Add(this.GeralPublico);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Tag = "Top";
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(929, 366);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 0;
            // 
            // Titulo
            // 
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Margin = new System.Windows.Forms.Padding(3);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(929, 37);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Senhas";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRIORITÁRIO:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PrioPublico
            // 
            this.PrioPublico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrioPublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioPublico.Location = new System.Drawing.Point(376, 87);
            this.PrioPublico.Name = "PrioPublico";
            this.PrioPublico.Size = new System.Drawing.Size(232, 37);
            this.PrioPublico.TabIndex = 2;
            this.PrioPublico.Text = "Balcão 1 - A97";
            this.PrioPublico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeralPublico
            // 
            this.GeralPublico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeralPublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeralPublico.Location = new System.Drawing.Point(376, 50);
            this.GeralPublico.Name = "GeralPublico";
            this.GeralPublico.Size = new System.Drawing.Size(232, 37);
            this.GeralPublico.TabIndex = 1;
            this.GeralPublico.Text = "Balcão 1 - A07";
            this.GeralPublico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "GERAL:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.ultimasenha);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.NovoPrio);
            this.splitContainer2.Panel1.Controls.Add(this.NovoGeral);
            this.splitContainer2.Panel1.Tag = "Left";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel2.Controls.Add(this.Balcao3);
            this.splitContainer2.Panel2.Controls.Add(this.Balcao2);
            this.splitContainer2.Panel2.Controls.Add(this.Balcao1);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Tag = "Right";
            this.splitContainer2.Size = new System.Drawing.Size(929, 217);
            this.splitContainer2.SplitterDistance = 471;
            this.splitContainer2.TabIndex = 0;
            // 
            // ultimasenha
            // 
            this.ultimasenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimasenha.Location = new System.Drawing.Point(121, 65);
            this.ultimasenha.Name = "ultimasenha";
            this.ultimasenha.Size = new System.Drawing.Size(323, 37);
            this.ultimasenha.TabIndex = 6;
            this.ultimasenha.Text = "A Sua Senha é : ";
            this.ultimasenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imprime";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NovoPrio
            // 
            this.NovoPrio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoPrio.Location = new System.Drawing.Point(275, 164);
            this.NovoPrio.Name = "NovoPrio";
            this.NovoPrio.Size = new System.Drawing.Size(94, 41);
            this.NovoPrio.TabIndex = 1;
            this.NovoPrio.Text = "Prioritário";
            this.NovoPrio.UseVisualStyleBackColor = true;
            this.NovoPrio.Click += new System.EventHandler(this.NovoPrio_Click);
            // 
            // NovoGeral
            // 
            this.NovoGeral.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovoGeral.Location = new System.Drawing.Point(70, 164);
            this.NovoGeral.Name = "NovoGeral";
            this.NovoGeral.Size = new System.Drawing.Size(94, 41);
            this.NovoGeral.TabIndex = 0;
            this.NovoGeral.Text = "Geral";
            this.NovoGeral.UseVisualStyleBackColor = true;
            this.NovoGeral.Click += new System.EventHandler(this.NovoGeral_Click);
            // 
            // Balcao3
            // 
            this.Balcao3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balcao3.Location = new System.Drawing.Point(348, 164);
            this.Balcao3.Name = "Balcao3";
            this.Balcao3.Size = new System.Drawing.Size(94, 41);
            this.Balcao3.TabIndex = 9;
            this.Balcao3.Text = "3";
            this.Balcao3.UseVisualStyleBackColor = true;
            this.Balcao3.Click += new System.EventHandler(this.Balcao3_Click);
            // 
            // Balcao2
            // 
            this.Balcao2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balcao2.Location = new System.Drawing.Point(189, 164);
            this.Balcao2.Name = "Balcao2";
            this.Balcao2.Size = new System.Drawing.Size(94, 41);
            this.Balcao2.TabIndex = 8;
            this.Balcao2.Text = "2";
            this.Balcao2.UseVisualStyleBackColor = true;
            this.Balcao2.Click += new System.EventHandler(this.Balcao2_Click);
            // 
            // Balcao1
            // 
            this.Balcao1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balcao1.Location = new System.Drawing.Point(32, 164);
            this.Balcao1.Name = "Balcao1";
            this.Balcao1.Size = new System.Drawing.Size(94, 41);
            this.Balcao1.TabIndex = 7;
            this.Balcao1.Text = "1";
            this.Balcao1.UseVisualStyleBackColor = true;
            this.Balcao1.Click += new System.EventHandler(this.Balcao1_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Balcoes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(630, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 366);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PrioPublico;
        private System.Windows.Forms.Label GeralPublico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NovoPrio;
        private System.Windows.Forms.Button NovoGeral;
        private System.Windows.Forms.Button Balcao3;
        private System.Windows.Forms.Button Balcao2;
        private System.Windows.Forms.Button Balcao1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ultimasenha;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

