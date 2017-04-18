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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nupX = new System.Windows.Forms.NumericUpDown();
            this.nupY = new System.Windows.Forms.NumericUpDown();
            this.btnAddPonto = new System.Windows.Forms.Button();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.cmbPontoA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPontoB = new System.Windows.Forms.ComboBox();
            this.lblPontoB = new System.Windows.Forms.Label();
            this.btnAddLinha = new System.Windows.Forms.Button();
            this.cmbLinhas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPTriB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPTriC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDrawTri = new System.Windows.Forms.Button();
            this.cmbPTriA = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddTri = new System.Windows.Forms.Button();
            this.cmbtriang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FazLinhas = new System.Windows.Forms.Button();
            this.lstPontos = new System.Windows.Forms.ListView();
            this.Tabloid = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.FazTriangulos = new System.Windows.Forms.Button();
            this.FazQuadrados = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupY)).BeginInit();
            this.Tabloid.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nupX
            // 
            this.nupX.Location = new System.Drawing.Point(42, 6);
            this.nupX.Name = "nupX";
            this.nupX.Size = new System.Drawing.Size(80, 20);
            this.nupX.TabIndex = 0;
            // 
            // nupY
            // 
            this.nupY.Location = new System.Drawing.Point(160, 6);
            this.nupY.Name = "nupY";
            this.nupY.Size = new System.Drawing.Size(80, 20);
            this.nupY.TabIndex = 1;
            // 
            // btnAddPonto
            // 
            this.btnAddPonto.Location = new System.Drawing.Point(132, 32);
            this.btnAddPonto.Name = "btnAddPonto";
            this.btnAddPonto.Size = new System.Drawing.Size(80, 22);
            this.btnAddPonto.TabIndex = 2;
            this.btnAddPonto.Text = "Add Ponto";
            this.btnAddPonto.UseVisualStyleBackColor = true;
            this.btnAddPonto.Click += new System.EventHandler(this.btnAddPonto_Click);
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.Transparent;
            this.panelDraw.Location = new System.Drawing.Point(273, 4);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(789, 520);
            this.panelDraw.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(129, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lista de Pontos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawLine.Location = new System.Drawing.Point(194, 60);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(45, 21);
            this.btnDrawLine.TabIndex = 12;
            this.btnDrawLine.Text = ">";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // cmbPontoA
            // 
            this.cmbPontoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPontoA.FormattingEnabled = true;
            this.cmbPontoA.Location = new System.Drawing.Point(59, 5);
            this.cmbPontoA.Name = "cmbPontoA";
            this.cmbPontoA.Size = new System.Drawing.Size(129, 21);
            this.cmbPontoA.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(-1, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ponto A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cmbPontoB
            // 
            this.cmbPontoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPontoB.FormattingEnabled = true;
            this.cmbPontoB.Location = new System.Drawing.Point(59, 33);
            this.cmbPontoB.Name = "cmbPontoB";
            this.cmbPontoB.Size = new System.Drawing.Size(129, 21);
            this.cmbPontoB.TabIndex = 8;
            // 
            // lblPontoB
            // 
            this.lblPontoB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontoB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPontoB.Location = new System.Drawing.Point(-1, 31);
            this.lblPontoB.Name = "lblPontoB";
            this.lblPontoB.Size = new System.Drawing.Size(58, 20);
            this.lblPontoB.TabIndex = 9;
            this.lblPontoB.Text = "Ponto B";
            this.lblPontoB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnAddLinha
            // 
            this.btnAddLinha.Location = new System.Drawing.Point(194, 3);
            this.btnAddLinha.Name = "btnAddLinha";
            this.btnAddLinha.Size = new System.Drawing.Size(46, 51);
            this.btnAddLinha.TabIndex = 2;
            this.btnAddLinha.Text = "Add Linha";
            this.btnAddLinha.UseVisualStyleBackColor = true;
            this.btnAddLinha.Click += new System.EventHandler(this.btnAddLinha_Click);
            // 
            // cmbLinhas
            // 
            this.cmbLinhas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLinhas.FormattingEnabled = true;
            this.cmbLinhas.Location = new System.Drawing.Point(59, 60);
            this.cmbLinhas.Name = "cmbLinhas";
            this.cmbLinhas.Size = new System.Drawing.Size(129, 21);
            this.cmbLinhas.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Linhas";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPTriB
            // 
            this.cmbPTriB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPTriB.FormattingEnabled = true;
            this.cmbPTriB.Location = new System.Drawing.Point(62, 41);
            this.cmbPTriB.Name = "cmbPTriB";
            this.cmbPTriB.Size = new System.Drawing.Size(103, 21);
            this.cmbPTriB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ponto B";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPTriC
            // 
            this.cmbPTriC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPTriC.FormattingEnabled = true;
            this.cmbPTriC.Location = new System.Drawing.Point(62, 68);
            this.cmbPTriC.Name = "cmbPTriC";
            this.cmbPTriC.Size = new System.Drawing.Size(103, 21);
            this.cmbPTriC.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ponto C";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDrawTri
            // 
            this.btnDrawTri.Location = new System.Drawing.Point(21, 202);
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
            this.cmbPTriA.Location = new System.Drawing.Point(62, 12);
            this.cmbPTriA.Name = "cmbPTriA";
            this.cmbPTriA.Size = new System.Drawing.Size(103, 21);
            this.cmbPTriA.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ponto A";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btAddTri
            // 
            this.btAddTri.Location = new System.Drawing.Point(21, 115);
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
            this.cmbtriang.Location = new System.Drawing.Point(7, 167);
            this.cmbtriang.Name = "cmbtriang";
            this.cmbtriang.Size = new System.Drawing.Size(158, 21);
            this.cmbtriang.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lista de Triangulos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FazLinhas
            // 
            this.FazLinhas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FazLinhas.Location = new System.Drawing.Point(189, 65);
            this.FazLinhas.Name = "FazLinhas";
            this.FazLinhas.Size = new System.Drawing.Size(62, 48);
            this.FazLinhas.TabIndex = 8;
            this.FazLinhas.Text = "Linhas >";
            this.FazLinhas.UseVisualStyleBackColor = true;
            // 
            // lstPontos
            // 
            this.lstPontos.Location = new System.Drawing.Point(3, 65);
            this.lstPontos.Name = "lstPontos";
            this.lstPontos.Size = new System.Drawing.Size(180, 410);
            this.lstPontos.TabIndex = 18;
            this.lstPontos.UseCompatibleStateImageBehavior = false;
            // 
            // Tabloid
            // 
            this.Tabloid.Controls.Add(this.tabPage1);
            this.Tabloid.Controls.Add(this.tabPage2);
            this.Tabloid.Controls.Add(this.tabPage3);
            this.Tabloid.Controls.Add(this.tabPage4);
            this.Tabloid.Controls.Add(this.tabPage5);
            this.Tabloid.Location = new System.Drawing.Point(2, 4);
            this.Tabloid.Name = "Tabloid";
            this.Tabloid.SelectedIndex = 0;
            this.Tabloid.Size = new System.Drawing.Size(265, 501);
            this.Tabloid.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.FazQuadrados);
            this.tabPage1.Controls.Add(this.FazTriangulos);
            this.tabPage1.Controls.Add(this.lstPontos);
            this.tabPage1.Controls.Add(this.FazLinhas);
            this.tabPage1.Controls.Add(this.nupX);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.nupY);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnAddPonto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(257, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pontos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDrawLine);
            this.tabPage2.Controls.Add(this.cmbPontoA);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmbLinhas);
            this.tabPage2.Controls.Add(this.cmbPontoB);
            this.tabPage2.Controls.Add(this.btnAddLinha);
            this.tabPage2.Controls.Add(this.lblPontoB);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(257, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linhas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbPTriB);
            this.tabPage3.Controls.Add(this.cmbPTriA);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.cmbPTriC);
            this.tabPage3.Controls.Add(this.cmbtriang);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btAddTri);
            this.tabPage3.Controls.Add(this.btnDrawTri);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(257, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Triangulos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(246, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quadrilateros";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(246, 296);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Poligonos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // FazTriangulos
            // 
            this.FazTriangulos.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FazTriangulos.Location = new System.Drawing.Point(189, 119);
            this.FazTriangulos.Name = "FazTriangulos";
            this.FazTriangulos.Size = new System.Drawing.Size(62, 48);
            this.FazTriangulos.TabIndex = 19;
            this.FazTriangulos.Text = "Tri >";
            this.FazTriangulos.UseVisualStyleBackColor = true;
            // 
            // FazQuadrados
            // 
            this.FazQuadrados.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FazQuadrados.Location = new System.Drawing.Point(189, 173);
            this.FazQuadrados.Name = "FazQuadrados";
            this.FazQuadrados.Size = new System.Drawing.Size(62, 48);
            this.FazQuadrados.TabIndex = 20;
            this.FazQuadrados.Text = "Quadri >";
            this.FazQuadrados.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(189, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Poligon >";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1165, 536);
            this.Controls.Add(this.Tabloid);
            this.Controls.Add(this.panelDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupY)).EndInit();
            this.Tabloid.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupX;
        private System.Windows.Forms.NumericUpDown nupY;
        private System.Windows.Forms.Button btnAddPonto;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPontoA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPontoB;
        private System.Windows.Forms.Label lblPontoB;
        private System.Windows.Forms.Button btnAddLinha;
        private System.Windows.Forms.ComboBox cmbLinhas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDrawLine;
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
        private System.Windows.Forms.Button FazLinhas;
        private System.Windows.Forms.ListView lstPontos;
        private System.Windows.Forms.TabControl Tabloid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button FazQuadrados;
        private System.Windows.Forms.Button FazTriangulos;
        private System.Windows.Forms.Button button1;
    }
}

