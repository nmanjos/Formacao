namespace Figuras
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
            this.nupX = new System.Windows.Forms.NumericUpDown();
            this.nupY = new System.Windows.Forms.NumericUpDown();
            this.btnAddPonto = new System.Windows.Forms.Button();
            this.cmbPontos = new System.Windows.Forms.ComboBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPontos = new System.Windows.Forms.GroupBox();
            this.gbLinhas = new System.Windows.Forms.GroupBox();
            this.cmbPontoA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPontoB = new System.Windows.Forms.ComboBox();
            this.lblPontoB = new System.Windows.Forms.Label();
            this.btnAddLinha = new System.Windows.Forms.Button();
            this.cmbLinhas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrawTri = new System.Windows.Forms.Button();
            this.cmbPTriA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddTri = new System.Windows.Forms.Button();
            this.cmbtriang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbPTriC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPTriB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupY)).BeginInit();
            this.gbPontos.SuspendLayout();
            this.gbLinhas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nupX
            // 
            this.nupX.Location = new System.Drawing.Point(48, 19);
            this.nupX.Name = "nupX";
            this.nupX.Size = new System.Drawing.Size(95, 20);
            this.nupX.TabIndex = 0;
            // 
            // nupY
            // 
            this.nupY.Location = new System.Drawing.Point(48, 45);
            this.nupY.Name = "nupY";
            this.nupY.Size = new System.Drawing.Size(95, 20);
            this.nupY.TabIndex = 1;
            // 
            // btnAddPonto
            // 
            this.btnAddPonto.Location = new System.Drawing.Point(17, 80);
            this.btnAddPonto.Name = "btnAddPonto";
            this.btnAddPonto.Size = new System.Drawing.Size(126, 23);
            this.btnAddPonto.TabIndex = 2;
            this.btnAddPonto.Text = "Add Ponto";
            this.btnAddPonto.UseVisualStyleBackColor = true;
            this.btnAddPonto.Click += new System.EventHandler(this.btnAddPonto_Click);
            // 
            // cmbPontos
            // 
            this.cmbPontos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPontos.FormattingEnabled = true;
            this.cmbPontos.Location = new System.Drawing.Point(12, 134);
            this.cmbPontos.Name = "cmbPontos";
            this.cmbPontos.Size = new System.Drawing.Size(131, 21);
            this.cmbPontos.TabIndex = 3;
            this.cmbPontos.SelectedIndexChanged += new System.EventHandler(this.cmbPontos_SelectedIndexChanged);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.White;
            this.panelDraw.Location = new System.Drawing.Point(2, 241);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(803, 296);
            this.panelDraw.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de Pontos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gbPontos
            // 
            this.gbPontos.Controls.Add(this.nupX);
            this.gbPontos.Controls.Add(this.nupY);
            this.gbPontos.Controls.Add(this.btnAddPonto);
            this.gbPontos.Controls.Add(this.cmbPontos);
            this.gbPontos.Controls.Add(this.label1);
            this.gbPontos.Controls.Add(this.label2);
            this.gbPontos.Controls.Add(this.label3);
            this.gbPontos.Location = new System.Drawing.Point(12, 2);
            this.gbPontos.Name = "gbPontos";
            this.gbPontos.Size = new System.Drawing.Size(158, 170);
            this.gbPontos.TabIndex = 15;
            this.gbPontos.TabStop = false;
            this.gbPontos.Text = "Pontos";
            // 
            // gbLinhas
            // 
            this.gbLinhas.Controls.Add(this.btnDrawLine);
            this.gbLinhas.Controls.Add(this.cmbPontoA);
            this.gbLinhas.Controls.Add(this.label5);
            this.gbLinhas.Controls.Add(this.cmbPontoB);
            this.gbLinhas.Controls.Add(this.lblPontoB);
            this.gbLinhas.Controls.Add(this.btnAddLinha);
            this.gbLinhas.Controls.Add(this.cmbLinhas);
            this.gbLinhas.Controls.Add(this.label6);
            this.gbLinhas.Location = new System.Drawing.Point(190, 2);
            this.gbLinhas.Name = "gbLinhas";
            this.gbLinhas.Size = new System.Drawing.Size(158, 233);
            this.gbLinhas.TabIndex = 16;
            this.gbLinhas.TabStop = false;
            this.gbLinhas.Text = "Linhas";
            // 
            // cmbPontoA
            // 
            this.cmbPontoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPontoA.FormattingEnabled = true;
            this.cmbPontoA.Location = new System.Drawing.Point(17, 34);
            this.cmbPontoA.Name = "cmbPontoA";
            this.cmbPontoA.Size = new System.Drawing.Size(126, 21);
            this.cmbPontoA.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ponto A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbPontoB
            // 
            this.cmbPontoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPontoB.FormattingEnabled = true;
            this.cmbPontoB.Location = new System.Drawing.Point(17, 81);
            this.cmbPontoB.Name = "cmbPontoB";
            this.cmbPontoB.Size = new System.Drawing.Size(126, 21);
            this.cmbPontoB.TabIndex = 8;
            // 
            // lblPontoB
            // 
            this.lblPontoB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontoB.Location = new System.Drawing.Point(14, 58);
            this.lblPontoB.Name = "lblPontoB";
            this.lblPontoB.Size = new System.Drawing.Size(129, 20);
            this.lblPontoB.TabIndex = 9;
            this.lblPontoB.Text = "Ponto B";
            this.lblPontoB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnAddLinha
            // 
            this.btnAddLinha.Location = new System.Drawing.Point(14, 120);
            this.btnAddLinha.Name = "btnAddLinha";
            this.btnAddLinha.Size = new System.Drawing.Size(129, 20);
            this.btnAddLinha.TabIndex = 2;
            this.btnAddLinha.Text = "Add Linha";
            this.btnAddLinha.UseVisualStyleBackColor = true;
            this.btnAddLinha.Click += new System.EventHandler(this.btnAddLinha_Click);
            // 
            // cmbLinhas
            // 
            this.cmbLinhas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinhas.FormattingEnabled = true;
            this.cmbLinhas.Location = new System.Drawing.Point(14, 172);
            this.cmbLinhas.Name = "cmbLinhas";
            this.cmbLinhas.Size = new System.Drawing.Size(129, 21);
            this.cmbLinhas.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lista de Linhas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(14, 207);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(129, 26);
            this.btnDrawLine.TabIndex = 12;
            this.btnDrawLine.Text = "Desenha Linha";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPTriB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbPTriC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDrawTri);
            this.groupBox1.Controls.Add(this.cmbPTriA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btAddTri);
            this.groupBox1.Controls.Add(this.cmbtriang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(389, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 233);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triangulos";
            // 
            // btnDrawTri
            // 
            this.btnDrawTri.Location = new System.Drawing.Point(14, 207);
            this.btnDrawTri.Name = "btnDrawTri";
            this.btnDrawTri.Size = new System.Drawing.Size(129, 26);
            this.btnDrawTri.TabIndex = 12;
            this.btnDrawTri.Text = "Desenha Triângulos";
            this.btnDrawTri.UseVisualStyleBackColor = true;
            this.btnDrawTri.Click += new System.EventHandler(this.btnDrawTri_Click);
            // 
            // cmbPTriA
            // 
            this.cmbPTriA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPTriA.FormattingEnabled = true;
            this.cmbPTriA.Location = new System.Drawing.Point(55, 17);
            this.cmbPTriA.Name = "cmbPTriA";
            this.cmbPTriA.Size = new System.Drawing.Size(103, 21);
            this.cmbPTriA.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ponto A";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btAddTri
            // 
            this.btAddTri.Location = new System.Drawing.Point(14, 120);
            this.btAddTri.Name = "btAddTri";
            this.btAddTri.Size = new System.Drawing.Size(129, 20);
            this.btAddTri.TabIndex = 2;
            this.btAddTri.Text = "Add Triângulo";
            this.btAddTri.UseVisualStyleBackColor = true;
            this.btAddTri.Click += new System.EventHandler(this.btAddTri_Click);
            // 
            // cmbtriang
            // 
            this.cmbtriang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtriang.FormattingEnabled = true;
            this.cmbtriang.Location = new System.Drawing.Point(0, 172);
            this.cmbtriang.Name = "cmbtriang";
            this.cmbtriang.Size = new System.Drawing.Size(158, 21);
            this.cmbtriang.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lista de Triangulos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbPTriC
            // 
            this.cmbPTriC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPTriC.FormattingEnabled = true;
            this.cmbPTriC.Location = new System.Drawing.Point(55, 73);
            this.cmbPTriC.Name = "cmbPTriC";
            this.cmbPTriC.Size = new System.Drawing.Size(103, 21);
            this.cmbPTriC.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ponto C";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPTriB
            // 
            this.cmbPTriB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPTriB.FormattingEnabled = true;
            this.cmbPTriB.Location = new System.Drawing.Point(55, 46);
            this.cmbPTriB.Name = "cmbPTriB";
            this.cmbPTriB.Size = new System.Drawing.Size(103, 21);
            this.cmbPTriB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ponto B";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 536);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbLinhas);
            this.Controls.Add(this.gbPontos);
            this.Controls.Add(this.panelDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nupX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupY)).EndInit();
            this.gbPontos.ResumeLayout(false);
            this.gbLinhas.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupX;
        private System.Windows.Forms.NumericUpDown nupY;
        private System.Windows.Forms.Button btnAddPonto;
        private System.Windows.Forms.ComboBox cmbPontos;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPontos;
        private System.Windows.Forms.GroupBox gbLinhas;
        private System.Windows.Forms.ComboBox cmbPontoA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPontoB;
        private System.Windows.Forms.Label lblPontoB;
        private System.Windows.Forms.Button btnAddLinha;
        private System.Windows.Forms.ComboBox cmbLinhas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPTriB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPTriC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDrawTri;
        private System.Windows.Forms.ComboBox cmbPTriA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAddTri;
        private System.Windows.Forms.ComboBox cmbtriang;
        private System.Windows.Forms.Label label8;
    }
}

