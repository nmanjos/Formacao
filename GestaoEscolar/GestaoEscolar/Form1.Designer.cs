namespace GestaoEscolar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAluno = new System.Windows.Forms.Button();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnExterno = new System.Windows.Forms.RadioButton();
            this.rbtnInterno = new System.Windows.Forms.RadioButton();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddMediaAnual = new System.Windows.Forms.Button();
            this.txtMediaAnual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMatAval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNotaDisc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddDisc = new System.Windows.Forms.Button();
            this.txtNomeDisc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnAvaliacoes = new System.Windows.Forms.RadioButton();
            this.rbtnDados = new System.Windows.Forms.RadioButton();
            this.txtVisualizacoes = new System.Windows.Forms.RichTextBox();
            this.txtMatVis = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAluno);
            this.groupBox1.Controls.Add(this.cmbTurma);
            this.groupBox1.Controls.Add(this.cmbCurso);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtnExterno);
            this.groupBox1.Controls.Add(this.rbtnInterno);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtCc);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRIAR ALUNO";
            // 
            // btnAddAluno
            // 
            this.btnAddAluno.Location = new System.Drawing.Point(11, 417);
            this.btnAddAluno.Name = "btnAddAluno";
            this.btnAddAluno.Size = new System.Drawing.Size(290, 43);
            this.btnAddAluno.TabIndex = 1;
            this.btnAddAluno.Text = "CRIAR ALUNO";
            this.btnAddAluno.UseVisualStyleBackColor = true;
            this.btnAddAluno.Click += new System.EventHandler(this.btnAddAluno_Click);
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "10A",
            "10B",
            "10C",
            "10D",
            "11A",
            "11B"});
            this.cmbTurma.Location = new System.Drawing.Point(11, 378);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(290, 28);
            this.cmbTurma.TabIndex = 11;
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "REDES",
            "PROGRAMAÇÃO",
            "MULTIMÉDIA"});
            this.cmbCurso.Location = new System.Drawing.Point(11, 318);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(290, 28);
            this.cmbCurso.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "TURMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "CURSO";
            // 
            // rbtnExterno
            // 
            this.rbtnExterno.AutoSize = true;
            this.rbtnExterno.Location = new System.Drawing.Point(175, 255);
            this.rbtnExterno.Name = "rbtnExterno";
            this.rbtnExterno.Size = new System.Drawing.Size(89, 24);
            this.rbtnExterno.TabIndex = 8;
            this.rbtnExterno.TabStop = true;
            this.rbtnExterno.Text = "Externo";
            this.rbtnExterno.UseVisualStyleBackColor = true;
            // 
            // rbtnInterno
            // 
            this.rbtnInterno.AutoSize = true;
            this.rbtnInterno.Location = new System.Drawing.Point(11, 255);
            this.rbtnInterno.Name = "rbtnInterno";
            this.rbtnInterno.Size = new System.Drawing.Size(85, 24);
            this.rbtnInterno.TabIndex = 1;
            this.rbtnInterno.TabStop = true;
            this.rbtnInterno.Text = "Interno";
            this.rbtnInterno.UseVisualStyleBackColor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(11, 219);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(290, 26);
            this.txtData.TabIndex = 7;
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(11, 157);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(290, 26);
            this.txtCc.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(11, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(290, 26);
            this.txtNome.TabIndex = 5;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(11, 49);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(290, 26);
            this.txtMatricula.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "DATA NASCIMENTO ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRICULA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddMediaAnual);
            this.groupBox2.Controls.Add(this.txtMediaAnual);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(10, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AVALIAÇÔES INTERNO";
            // 
            // btnAddMediaAnual
            // 
            this.btnAddMediaAnual.Location = new System.Drawing.Point(11, 89);
            this.btnAddMediaAnual.Name = "btnAddMediaAnual";
            this.btnAddMediaAnual.Size = new System.Drawing.Size(290, 42);
            this.btnAddMediaAnual.TabIndex = 2;
            this.btnAddMediaAnual.Text = "ADICIONAR MÉDIA";
            this.btnAddMediaAnual.UseVisualStyleBackColor = true;
            this.btnAddMediaAnual.Click += new System.EventHandler(this.btnAddMediaAnual_Click);
            // 
            // txtMediaAnual
            // 
            this.txtMediaAnual.Location = new System.Drawing.Point(11, 53);
            this.txtMediaAnual.Name = "txtMediaAnual";
            this.txtMediaAnual.Size = new System.Drawing.Size(290, 26);
            this.txtMediaAnual.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "MEDIA ANUAL";
            // 
            // txtMatAval
            // 
            this.txtMatAval.Location = new System.Drawing.Point(21, 46);
            this.txtMatAval.Name = "txtMatAval";
            this.txtMatAval.Size = new System.Drawing.Size(290, 26);
            this.txtMatAval.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "MATRICULA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNotaDisc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnAddDisc);
            this.groupBox3.Controls.Add(this.txtNomeDisc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCodigo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(10, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 245);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "AVALIAÇÔES EXTERNO";
            // 
            // txtNotaDisc
            // 
            this.txtNotaDisc.Location = new System.Drawing.Point(10, 162);
            this.txtNotaDisc.Name = "txtNotaDisc";
            this.txtNotaDisc.Size = new System.Drawing.Size(290, 26);
            this.txtNotaDisc.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "NOTA";
            // 
            // btnAddDisc
            // 
            this.btnAddDisc.Location = new System.Drawing.Point(10, 197);
            this.btnAddDisc.Name = "btnAddDisc";
            this.btnAddDisc.Size = new System.Drawing.Size(290, 42);
            this.btnAddDisc.TabIndex = 2;
            this.btnAddDisc.Text = "ADICIONAR DISCIPLINA";
            this.btnAddDisc.UseVisualStyleBackColor = true;
            this.btnAddDisc.Click += new System.EventHandler(this.btnAddDisc_Click);
            // 
            // txtNomeDisc
            // 
            this.txtNomeDisc.Location = new System.Drawing.Point(10, 107);
            this.txtNomeDisc.Name = "txtNomeDisc";
            this.txtNomeDisc.Size = new System.Drawing.Size(290, 26);
            this.txtNomeDisc.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "NOME";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(10, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(290, 26);
            this.txtCodigo.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "CODIGO DISCIPLINA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.rbtnAvaliacoes);
            this.groupBox4.Controls.Add(this.rbtnDados);
            this.groupBox4.Controls.Add(this.txtVisualizacoes);
            this.groupBox4.Controls.Add(this.txtMatVis);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(12, 504);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(647, 190);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VISUALIZAÇÕES";
            // 
            // rbtnAvaliacoes
            // 
            this.rbtnAvaliacoes.AutoSize = true;
            this.rbtnAvaliacoes.Location = new System.Drawing.Point(7, 109);
            this.rbtnAvaliacoes.Name = "rbtnAvaliacoes";
            this.rbtnAvaliacoes.Size = new System.Drawing.Size(185, 24);
            this.rbtnAvaliacoes.TabIndex = 9;
            this.rbtnAvaliacoes.TabStop = true;
            this.rbtnAvaliacoes.Text = "AVALIAÇÃO ALUNO";
            this.rbtnAvaliacoes.UseVisualStyleBackColor = true;
            this.rbtnAvaliacoes.CheckedChanged += new System.EventHandler(this.rbtnAvaliacoes_CheckedChanged);
            // 
            // rbtnDados
            // 
            this.rbtnDados.AutoSize = true;
            this.rbtnDados.Location = new System.Drawing.Point(7, 79);
            this.rbtnDados.Name = "rbtnDados";
            this.rbtnDados.Size = new System.Drawing.Size(151, 24);
            this.rbtnDados.TabIndex = 8;
            this.rbtnDados.TabStop = true;
            this.rbtnDados.Text = "DADOS ALUNO";
            this.rbtnDados.UseVisualStyleBackColor = true;
            this.rbtnDados.CheckedChanged += new System.EventHandler(this.rbtnDados_CheckedChanged);
            // 
            // txtVisualizacoes
            // 
            this.txtVisualizacoes.Location = new System.Drawing.Point(206, 19);
            this.txtVisualizacoes.Name = "txtVisualizacoes";
            this.txtVisualizacoes.Size = new System.Drawing.Size(418, 165);
            this.txtVisualizacoes.TabIndex = 7;
            this.txtVisualizacoes.Text = "";
            // 
            // txtMatVis
            // 
            this.txtMatVis.Location = new System.Drawing.Point(11, 46);
            this.txtMatVis.Name = "txtMatVis";
            this.txtMatVis.Size = new System.Drawing.Size(189, 26);
            this.txtMatVis.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "MATRICULA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "LIMPAR SELEÇÃO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtMatAval);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(325, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 481);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AVALIAÇÕES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 706);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAluno;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnExterno;
        private System.Windows.Forms.RadioButton rbtnInterno;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddMediaAnual;
        private System.Windows.Forms.TextBox txtMediaAnual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMatAval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNotaDisc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddDisc;
        private System.Windows.Forms.TextBox txtNomeDisc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtnAvaliacoes;
        private System.Windows.Forms.RadioButton rbtnDados;
        private System.Windows.Forms.RichTextBox txtVisualizacoes;
        private System.Windows.Forms.TextBox txtMatVis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

