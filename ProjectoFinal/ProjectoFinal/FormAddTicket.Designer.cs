namespace ProjectoFinal
{
    partial class FormAddTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxDescr = new System.Windows.Forms.RichTextBox();
            this.cbxEquipamento = new System.Windows.Forms.ComboBox();
            this.cbxPrioridade = new System.Windows.Forms.ComboBox();
            this.cbxTAvaria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prioridade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // rtxDescr
            // 
            this.rtxDescr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxDescr.Location = new System.Drawing.Point(12, 38);
            this.rtxDescr.Name = "rtxDescr";
            this.rtxDescr.Size = new System.Drawing.Size(271, 222);
            this.rtxDescr.TabIndex = 5;
            this.rtxDescr.Text = "";
            // 
            // cbxEquipamento
            // 
            this.cbxEquipamento.FormattingEnabled = true;
            this.cbxEquipamento.Location = new System.Drawing.Point(90, 310);
            this.cbxEquipamento.Name = "cbxEquipamento";
            this.cbxEquipamento.Size = new System.Drawing.Size(193, 21);
            this.cbxEquipamento.TabIndex = 6;
            // 
            // cbxPrioridade
            // 
            this.cbxPrioridade.FormattingEnabled = true;
            this.cbxPrioridade.Location = new System.Drawing.Point(90, 337);
            this.cbxPrioridade.Name = "cbxPrioridade";
            this.cbxPrioridade.Size = new System.Drawing.Size(193, 21);
            this.cbxPrioridade.TabIndex = 7;
            // 
            // cbxTAvaria
            // 
            this.cbxTAvaria.FormattingEnabled = true;
            this.cbxTAvaria.Location = new System.Drawing.Point(90, 281);
            this.cbxTAvaria.Name = "cbxTAvaria";
            this.cbxTAvaria.Size = new System.Drawing.Size(193, 21);
            this.cbxTAvaria.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de Avaria:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(152, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 47);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSaveAdd
            // 
            this.btnSaveAdd.Location = new System.Drawing.Point(11, 381);
            this.btnSaveAdd.Name = "btnSaveAdd";
            this.btnSaveAdd.Size = new System.Drawing.Size(131, 47);
            this.btnSaveAdd.TabIndex = 11;
            this.btnSaveAdd.Text = "Save and New";
            this.btnSaveAdd.UseVisualStyleBackColor = true;
            this.btnSaveAdd.Click += new System.EventHandler(this.btn_Click);
            // 
            // FormAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 440);
            this.Controls.Add(this.btnSaveAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxTAvaria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxPrioridade);
            this.Controls.Add(this.cbxEquipamento);
            this.Controls.Add(this.rtxDescr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAddTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addTicket";
            this.Load += new System.EventHandler(this.addTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxDescr;
        private System.Windows.Forms.ComboBox cbxEquipamento;
        private System.Windows.Forms.ComboBox cbxPrioridade;
        private System.Windows.Forms.ComboBox cbxTAvaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAdd;
    }
}