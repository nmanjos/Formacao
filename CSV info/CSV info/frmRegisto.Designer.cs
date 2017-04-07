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
            this.lblMorada = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtProfissao = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblProfissao = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.rbVisitantes = new System.Windows.Forms.RadioButton();
            this.rbClientes = new System.Windows.Forms.RadioButton();
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
            this.btnADD.Text = "ADD RECORD";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMorada
            // 
            this.lblMorada.AutoSize = true;
            this.lblMorada.Location = new System.Drawing.Point(23, 237);
            this.lblMorada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(54, 13);
            this.lblMorada.TabIndex = 5;
            this.lblMorada.Text = "MORADA";
            this.lblMorada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 201);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(548, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(81, 234);
            this.txtMorada.Margin = new System.Windows.Forms.Padding(2);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(548, 20);
            this.txtMorada.TabIndex = 7;
            // 
            // txtProfissao
            // 
            this.txtProfissao.Location = new System.Drawing.Point(81, 300);
            this.txtProfissao.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfissao.Name = "txtProfissao";
            this.txtProfissao.Size = new System.Drawing.Size(548, 20);
            this.txtProfissao.TabIndex = 19;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(81, 267);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(2);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(548, 20);
            this.txtContacto.TabIndex = 18;
            // 
            // lblProfissao
            // 
            this.lblProfissao.AutoSize = true;
            this.lblProfissao.Location = new System.Drawing.Point(9, 303);
            this.lblProfissao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfissao.Name = "lblProfissao";
            this.lblProfissao.Size = new System.Drawing.Size(68, 13);
            this.lblProfissao.TabIndex = 17;
            this.lblProfissao.Text = "PROFISSÃO";
            this.lblProfissao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "CONTACTO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(28, 337);
            this.lblMotivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(49, 13);
            this.lblMotivo.TabIndex = 20;
            this.lblMotivo.Text = "MOTIVO";
            this.lblMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(320, 135);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(139, 28);
            this.btnRead.TabIndex = 23;
            this.btnRead.Text = "PESQUISAR";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click_1);
            // 
            // rbVisitantes
            // 
            this.rbVisitantes.AutoSize = true;
            this.rbVisitantes.Checked = true;
            this.rbVisitantes.Location = new System.Drawing.Point(463, 141);
            this.rbVisitantes.Margin = new System.Windows.Forms.Padding(2);
            this.rbVisitantes.Name = "rbVisitantes";
            this.rbVisitantes.Size = new System.Drawing.Size(88, 17);
            this.rbVisitantes.TabIndex = 24;
            this.rbVisitantes.TabStop = true;
            this.rbVisitantes.Text = "VISITANTES";
            this.rbVisitantes.UseVisualStyleBackColor = true;
            this.rbVisitantes.CheckedChanged += new System.EventHandler(this.rbVisitantes_CheckedChanged);
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Location = new System.Drawing.Point(553, 141);
            this.rbClientes.Margin = new System.Windows.Forms.Padding(2);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(77, 17);
            this.rbClientes.TabIndex = 25;
            this.rbClientes.Text = "CLIENTES";
            this.rbClientes.UseVisualStyleBackColor = true;
            this.rbClientes.CheckedChanged += new System.EventHandler(this.rbClientes_CheckedChanged);
            // 
            // lstRegisto
            // 
            this.lstRegisto.FullRowSelect = true;
            this.lstRegisto.Location = new System.Drawing.Point(5, 8);
            this.lstRegisto.Name = "lstRegisto";
            this.lstRegisto.Size = new System.Drawing.Size(625, 122);
            this.lstRegisto.TabIndex = 26;
            this.lstRegisto.UseCompatibleStateImageBehavior = false;
            this.lstRegisto.View = System.Windows.Forms.View.Details;
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
            this.cbxMotivo.Location = new System.Drawing.Point(81, 333);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Size = new System.Drawing.Size(548, 21);
            this.cbxMotivo.TabIndex = 28;
            // 
            // frmRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 459);
            this.Controls.Add(this.cbxMotivo);
            this.Controls.Add(this.lstRegisto);
            this.Controls.Add(this.rbClientes);
            this.Controls.Add(this.rbVisitantes);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtProfissao);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.lblProfissao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnReadAll);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRegisto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmRegisto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtProfissao;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblProfissao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RadioButton rbVisitantes;
        private System.Windows.Forms.RadioButton rbClientes;
        private System.Windows.Forms.ListView lstRegisto;
        private System.Windows.Forms.ComboBox cbxMotivo;
    }
}

