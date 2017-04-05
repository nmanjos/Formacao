namespace CSV_info
{
    partial class frmRegisto
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
            this.btnReadAll = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeC = new System.Windows.Forms.TextBox();
            this.txtMoradaC = new System.Windows.Forms.TextBox();
            this.txtContactoV = new System.Windows.Forms.TextBox();
            this.txtNomeV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnADDV = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfissaoC = new System.Windows.Forms.TextBox();
            this.txtContactoC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.lstRegisto = new System.Windows.Forms.ListView();
            this.cbxMotivo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(5, 135);
            this.btnReadAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(309, 28);
            this.btnReadAll.TabIndex = 2;
            this.btnReadAll.Text = "READ CSV TODOS";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(5, 385);
            this.btnADD.Margin = new System.Windows.Forms.Padding(2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(309, 28);
            this.btnADD.TabIndex = 3;
            this.btnADD.Text = "ADD TO CSV";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "MORADA";
            // 
            // txtNomeC
            // 
            this.txtNomeC.Location = new System.Drawing.Point(5, 224);
            this.txtNomeC.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeC.Name = "txtNomeC";
            this.txtNomeC.Size = new System.Drawing.Size(311, 20);
            this.txtNomeC.TabIndex = 6;
            // 
            // txtMoradaC
            // 
            this.txtMoradaC.Location = new System.Drawing.Point(5, 266);
            this.txtMoradaC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoradaC.Name = "txtMoradaC";
            this.txtMoradaC.Size = new System.Drawing.Size(311, 20);
            this.txtMoradaC.TabIndex = 7;
            // 
            // txtContactoV
            // 
            this.txtContactoV.Location = new System.Drawing.Point(320, 266);
            this.txtContactoV.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactoV.Name = "txtContactoV";
            this.txtContactoV.Size = new System.Drawing.Size(311, 20);
            this.txtContactoV.TabIndex = 13;
            // 
            // txtNomeV
            // 
            this.txtNomeV.Location = new System.Drawing.Point(320, 224);
            this.txtNomeV.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeV.Name = "txtNomeV";
            this.txtNomeV.Size = new System.Drawing.Size(311, 20);
            this.txtNomeV.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CONTACTO";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(319, 203);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "NOME";
            // 
            // btnADDV
            // 
            this.btnADDV.Location = new System.Drawing.Point(320, 385);
            this.btnADDV.Margin = new System.Windows.Forms.Padding(2);
            this.btnADDV.Name = "btnADDV";
            this.btnADDV.Size = new System.Drawing.Size(309, 28);
            this.btnADDV.TabIndex = 9;
            this.btnADDV.Text = "ADD TO CSV";
            this.btnADDV.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "CLIENTES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "VISITANTES";
            // 
            // txtProfissaoC
            // 
            this.txtProfissaoC.Location = new System.Drawing.Point(5, 356);
            this.txtProfissaoC.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfissaoC.Name = "txtProfissaoC";
            this.txtProfissaoC.Size = new System.Drawing.Size(311, 20);
            this.txtProfissaoC.TabIndex = 19;
            // 
            // txtContactoC
            // 
            this.txtContactoC.Location = new System.Drawing.Point(5, 311);
            this.txtContactoC.Margin = new System.Windows.Forms.Padding(2);
            this.txtContactoC.Name = "txtContactoC";
            this.txtContactoC.Size = new System.Drawing.Size(311, 20);
            this.txtContactoC.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "PROFISSÃO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CONTACTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 293);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "MOTIVO";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(320, 135);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(139, 28);
            this.btnRead.TabIndex = 23;
            this.btnRead.Text = "READ CSV";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(463, 141);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "VISITANTES";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(553, 141);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "CLIENTES";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // lstRegisto
            // 
            this.lstRegisto.Location = new System.Drawing.Point(5, 8);
            this.lstRegisto.Name = "lstRegisto";
            this.lstRegisto.Size = new System.Drawing.Size(625, 122);
            this.lstRegisto.TabIndex = 26;
            this.lstRegisto.UseCompatibleStateImageBehavior = false;
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.FormattingEnabled = true;
            this.cbxMotivo.Items.AddRange(new object[] {
            "Fazer xixi",
            "paraquedismo",
            "Cinema",
            "Comer",
            "Compras"});
            this.cbxMotivo.Location = new System.Drawing.Point(322, 309);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Size = new System.Drawing.Size(307, 21);
            this.cbxMotivo.TabIndex = 28;
            // 
            // frmRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 421);
            this.Controls.Add(this.cbxMotivo);
            this.Controls.Add(this.lstRegisto);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProfissaoC);
            this.Controls.Add(this.txtContactoC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContactoV);
            this.Controls.Add(this.txtNomeV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnADDV);
            this.Controls.Add(this.txtMoradaC);
            this.Controls.Add(this.txtNomeC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnReadAll);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegisto";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeC;
        private System.Windows.Forms.TextBox txtMoradaC;
        private System.Windows.Forms.TextBox txtContactoV;
        private System.Windows.Forms.TextBox txtNomeV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnADDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfissaoC;
        private System.Windows.Forms.TextBox txtContactoC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListView lstRegisto;
        private System.Windows.Forms.ComboBox cbxMotivo;
    }
}

