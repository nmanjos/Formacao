namespace ProjectoFinal
{
    partial class Tickets_Form
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
            this.Equipamento = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Requesicoes = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Aux = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbEquipamento = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbSoftware = new System.Windows.Forms.RadioButton();
            this.rdbRedes = new System.Windows.Forms.RadioButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.statusStrip1.SuspendLayout();
            this.TicketsTabular.SuspendLayout();
            this.Tickets.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1001, 22);
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
            this.TicketsTabular.Location = new System.Drawing.Point(1, 27);
            this.TicketsTabular.Name = "TicketsTabular";
            this.TicketsTabular.SelectedIndex = 0;
            this.TicketsTabular.Size = new System.Drawing.Size(1000, 480);
            this.TicketsTabular.TabIndex = 1;
            // 
            // Tickets
            // 
            this.Tickets.Controls.Add(this.listView2);
            this.Tickets.Controls.Add(this.rdbRedes);
            this.Tickets.Controls.Add(this.rdbSoftware);
            this.Tickets.Controls.Add(this.rdbTodos);
            this.Tickets.Controls.Add(this.rdbEquipamento);
            this.Tickets.Controls.Add(this.textBox1);
            this.Tickets.Controls.Add(this.label1);
            this.Tickets.Controls.Add(this.listView1);
            this.Tickets.Location = new System.Drawing.Point(4, 22);
            this.Tickets.Name = "Tickets";
            this.Tickets.Padding = new System.Windows.Forms.Padding(3);
            this.Tickets.Size = new System.Drawing.Size(992, 454);
            this.Tickets.TabIndex = 0;
            this.Tickets.Text = "Tickets";
            this.Tickets.UseVisualStyleBackColor = true;
            this.Tickets.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Equipamento
            // 
            this.Equipamento.Location = new System.Drawing.Point(4, 22);
            this.Equipamento.Name = "Equipamento";
            this.Equipamento.Padding = new System.Windows.Forms.Padding(3);
            this.Equipamento.Size = new System.Drawing.Size(992, 454);
            this.Equipamento.TabIndex = 1;
            this.Equipamento.Text = "Equipamento";
            this.Equipamento.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Requesicoes
            // 
            this.Requesicoes.Location = new System.Drawing.Point(4, 22);
            this.Requesicoes.Name = "Requesicoes";
            this.Requesicoes.Size = new System.Drawing.Size(992, 454);
            this.Requesicoes.TabIndex = 2;
            this.Requesicoes.Text = "Requesições";
            this.Requesicoes.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(978, 234);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Aux
            // 
            this.Aux.Location = new System.Drawing.Point(4, 22);
            this.Aux.Name = "Aux";
            this.Aux.Size = new System.Drawing.Size(992, 454);
            this.Aux.TabIndex = 3;
            this.Aux.Text = "Dados Auxiliares";
            this.Aux.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 2;
            // 
            // rdbEquipamento
            // 
            this.rdbEquipamento.AutoSize = true;
            this.rdbEquipamento.Location = new System.Drawing.Point(700, 3);
            this.rdbEquipamento.Name = "rdbEquipamento";
            this.rdbEquipamento.Size = new System.Drawing.Size(87, 17);
            this.rdbEquipamento.TabIndex = 3;
            this.rdbEquipamento.TabStop = true;
            this.rdbEquipamento.Text = "Equipamento";
            this.rdbEquipamento.UseVisualStyleBackColor = true;
            this.rdbEquipamento.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(928, 3);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 4;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // rdbSoftware
            // 
            this.rdbSoftware.AutoSize = true;
            this.rdbSoftware.Location = new System.Drawing.Point(855, 3);
            this.rdbSoftware.Name = "rdbSoftware";
            this.rdbSoftware.Size = new System.Drawing.Size(67, 17);
            this.rdbSoftware.TabIndex = 5;
            this.rdbSoftware.TabStop = true;
            this.rdbSoftware.Text = "Software";
            this.rdbSoftware.UseVisualStyleBackColor = true;
            // 
            // rdbRedes
            // 
            this.rdbRedes.AutoSize = true;
            this.rdbRedes.Location = new System.Drawing.Point(793, 3);
            this.rdbRedes.Name = "rdbRedes";
            this.rdbRedes.Size = new System.Drawing.Size(56, 17);
            this.rdbRedes.TabIndex = 6;
            this.rdbRedes.TabStop = true;
            this.rdbRedes.Text = "Redes";
            this.rdbRedes.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(6, 317);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(978, 134);
            this.listView2.TabIndex = 7;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Tickets_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 532);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TicketsTabular);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tickets_Form";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TicketsTabular.ResumeLayout(false);
            this.Tickets.ResumeLayout(false);
            this.Tickets.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl TicketsTabular;
        private System.Windows.Forms.TabPage Tickets;
        private System.Windows.Forms.TabPage Equipamento;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdbRedes;
        private System.Windows.Forms.RadioButton rdbSoftware;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbEquipamento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage Requesicoes;
        private System.Windows.Forms.TabPage Aux;
        private System.Windows.Forms.ListView listView2;
    }
}

