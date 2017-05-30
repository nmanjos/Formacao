namespace ProjectoFinal
{
    partial class FormTickets
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TicketsTabular = new System.Windows.Forms.TabControl();
            this.Tickets = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.rdbRedes = new System.Windows.Forms.RadioButton();
            this.rdbSoftware = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbEquipamento = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTickets = new System.Windows.Forms.ListView();
            this.Requesicoes = new System.Windows.Forms.TabPage();
            this.Equipamento = new System.Windows.Forms.TabPage();
            this.Aux = new System.Windows.Forms.TabPage();
            this.Perfil = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.TicketsTabular.SuspendLayout();
            this.Tickets.SuspendLayout();
            this.Perfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // TicketsTabular
            // 
            this.TicketsTabular.Controls.Add(this.Tickets);
            this.TicketsTabular.Controls.Add(this.Requesicoes);
            this.TicketsTabular.Controls.Add(this.Equipamento);
            this.TicketsTabular.Controls.Add(this.Aux);
            this.TicketsTabular.Controls.Add(this.Perfil);
            this.TicketsTabular.Location = new System.Drawing.Point(1, 2);
            this.TicketsTabular.Name = "TicketsTabular";
            this.TicketsTabular.SelectedIndex = 0;
            this.TicketsTabular.Size = new System.Drawing.Size(1181, 496);
            this.TicketsTabular.TabIndex = 1;
            // 
            // Tickets
            // 
            this.Tickets.Controls.Add(this.btnNovo);
            this.Tickets.Controls.Add(this.listView2);
            this.Tickets.Controls.Add(this.rdbRedes);
            this.Tickets.Controls.Add(this.rdbSoftware);
            this.Tickets.Controls.Add(this.rdbTodos);
            this.Tickets.Controls.Add(this.rdbEquipamento);
            this.Tickets.Controls.Add(this.textBox1);
            this.Tickets.Controls.Add(this.label1);
            this.Tickets.Controls.Add(this.lstTickets);
            this.Tickets.Location = new System.Drawing.Point(4, 22);
            this.Tickets.Name = "Tickets";
            this.Tickets.Padding = new System.Windows.Forms.Padding(3);
            this.Tickets.Size = new System.Drawing.Size(1173, 470);
            this.Tickets.TabIndex = 0;
            this.Tickets.Text = "Tickets";
            this.Tickets.UseVisualStyleBackColor = true;
            this.Tickets.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(792, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 23);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(6, 347);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1162, 120);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // rdbRedes
            // 
            this.rdbRedes.AutoSize = true;
            this.rdbRedes.Location = new System.Drawing.Point(975, 6);
            this.rdbRedes.Name = "rdbRedes";
            this.rdbRedes.Size = new System.Drawing.Size(56, 17);
            this.rdbRedes.TabIndex = 6;
            this.rdbRedes.Text = "Redes";
            this.rdbRedes.UseVisualStyleBackColor = true;
            // 
            // rdbSoftware
            // 
            this.rdbSoftware.AutoSize = true;
            this.rdbSoftware.Location = new System.Drawing.Point(1037, 6);
            this.rdbSoftware.Name = "rdbSoftware";
            this.rdbSoftware.Size = new System.Drawing.Size(67, 17);
            this.rdbSoftware.TabIndex = 5;
            this.rdbSoftware.Text = "Software";
            this.rdbSoftware.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Checked = true;
            this.rdbTodos.Location = new System.Drawing.Point(1110, 6);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 4;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbEquipamento
            // 
            this.rdbEquipamento.AutoSize = true;
            this.rdbEquipamento.Location = new System.Drawing.Point(882, 6);
            this.rdbEquipamento.Name = "rdbEquipamento";
            this.rdbEquipamento.Size = new System.Drawing.Size(87, 17);
            this.rdbEquipamento.TabIndex = 3;
            this.rdbEquipamento.Text = "Equipamento";
            this.rdbEquipamento.UseVisualStyleBackColor = true;
            this.rdbEquipamento.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lstTickets
            // 
            this.lstTickets.Location = new System.Drawing.Point(6, 26);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(1162, 289);
            this.lstTickets.TabIndex = 0;
            this.lstTickets.UseCompatibleStateImageBehavior = false;
            this.lstTickets.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Requesicoes
            // 
            this.Requesicoes.Location = new System.Drawing.Point(4, 22);
            this.Requesicoes.Name = "Requesicoes";
            this.Requesicoes.Size = new System.Drawing.Size(1173, 470);
            this.Requesicoes.TabIndex = 2;
            this.Requesicoes.Text = "Requesições";
            this.Requesicoes.UseVisualStyleBackColor = true;
            // 
            // Equipamento
            // 
            this.Equipamento.Location = new System.Drawing.Point(4, 22);
            this.Equipamento.Name = "Equipamento";
            this.Equipamento.Padding = new System.Windows.Forms.Padding(3);
            this.Equipamento.Size = new System.Drawing.Size(1173, 470);
            this.Equipamento.TabIndex = 1;
            this.Equipamento.Text = "Equipamento";
            this.Equipamento.UseVisualStyleBackColor = true;
            // 
            // Aux
            // 
            this.Aux.Location = new System.Drawing.Point(4, 22);
            this.Aux.Name = "Aux";
            this.Aux.Size = new System.Drawing.Size(1173, 470);
            this.Aux.TabIndex = 3;
            this.Aux.Text = "Dados Auxiliares";
            this.Aux.UseVisualStyleBackColor = true;
            // 
            // Perfil
            // 
            this.Perfil.Controls.Add(this.comboBox1);
            this.Perfil.Controls.Add(this.label5);
            this.Perfil.Controls.Add(this.textBox4);
            this.Perfil.Controls.Add(this.label4);
            this.Perfil.Controls.Add(this.txtNome);
            this.Perfil.Controls.Add(this.label3);
            this.Perfil.Controls.Add(this.textBox2);
            this.Perfil.Controls.Add(this.label2);
            this.Perfil.Controls.Add(this.listView1);
            this.Perfil.Location = new System.Drawing.Point(4, 22);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(1173, 470);
            this.Perfil.TabIndex = 4;
            this.Perfil.Text = "Perfil";
            this.Perfil.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(7, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 440);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(688, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(725, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "000000000";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(860, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 21);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(814, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(725, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(423, 21);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(660, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(614, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nivel de Habilitação";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(725, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(423, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 519);
            this.Controls.Add(this.TicketsTabular);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTickets";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tickets_Form_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TicketsTabular.ResumeLayout(false);
            this.Tickets.ResumeLayout(false);
            this.Tickets.PerformLayout();
            this.Perfil.ResumeLayout(false);
            this.Perfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl TicketsTabular;
        private System.Windows.Forms.TabPage Tickets;
        private System.Windows.Forms.TabPage Equipamento;
        private System.Windows.Forms.RadioButton rdbRedes;
        private System.Windows.Forms.RadioButton rdbSoftware;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbEquipamento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstTickets;
        private System.Windows.Forms.TabPage Requesicoes;
        private System.Windows.Forms.TabPage Aux;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabPage Perfil;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
    }
}

