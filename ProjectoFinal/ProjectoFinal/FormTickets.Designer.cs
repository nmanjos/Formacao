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
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.TicketsTabular = new System.Windows.Forms.TabControl();
            this.tabTickets = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.rdbRedes = new System.Windows.Forms.RadioButton();
            this.rdbSoftware = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbEquipamento = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTickets = new System.Windows.Forms.ListView();
            this.tabRequesicoes = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.tabEquipamento = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.Aux = new System.Windows.Forms.TabPage();
            this.tbAuxs = new System.Windows.Forms.TabControl();
            this.tabAuxs = new System.Windows.Forms.TabPage();
            this.btnHabilitSave = new System.Windows.Forms.Button();
            this.txtHabilitDescr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstHabilit = new System.Windows.Forms.ListView();
            this.tbAreas = new System.Windows.Forms.TabPage();
            this.btnAreasSave = new System.Windows.Forms.Button();
            this.txtAreaDescr = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAreaNivel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstAreas = new System.Windows.Forms.ListView();
            this.tbStates = new System.Windows.Forms.TabPage();
            this.btnStateSave = new System.Windows.Forms.Button();
            this.chkStateIsRequest = new System.Windows.Forms.CheckBox();
            this.chkStateIsTicket = new System.Windows.Forms.CheckBox();
            this.chkStateIsReject = new System.Windows.Forms.CheckBox();
            this.chkStateIsFinal = new System.Windows.Forms.CheckBox();
            this.txtStateDescr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstStates = new System.Windows.Forms.ListView();
            this.tbPriority = new System.Windows.Forms.TabPage();
            this.btnPrioSave = new System.Windows.Forms.Button();
            this.txtPrioDescr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrioLevel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lstPrio = new System.Windows.Forms.ListView();
            this.tbMateriais = new System.Windows.Forms.TabPage();
            this.btnMatSave = new System.Windows.Forms.Button();
            this.chkMatIsSoftware = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lstMateriais = new System.Windows.Forms.ListView();
            this.tabPerfil = new System.Windows.Forms.TabPage();
            this.btnPerfilNovo = new System.Windows.Forms.Button();
            this.btnPerfilSave = new System.Windows.Forms.Button();
            this.cbxPerfilHabilit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPerfilSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPerfilNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerfilNIF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPerfil = new System.Windows.Forms.ListView();
            this.chkIsSuper = new System.Windows.Forms.CheckBox();
            this.chkIsTeck = new System.Windows.Forms.CheckBox();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.TicketsTabular.SuspendLayout();
            this.tabTickets.SuspendLayout();
            this.tabRequesicoes.SuspendLayout();
            this.tabEquipamento.SuspendLayout();
            this.Aux.SuspendLayout();
            this.tbAuxs.SuspendLayout();
            this.tabAuxs.SuspendLayout();
            this.tbAreas.SuspendLayout();
            this.tbStates.SuspendLayout();
            this.tbPriority.SuspendLayout();
            this.tbMateriais.SuspendLayout();
            this.tabPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusBar
            // 
            this.StatusBar.Location = new System.Drawing.Point(0, 497);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(1184, 22);
            this.StatusBar.TabIndex = 0;
            // 
            // TicketsTabular
            // 
            this.TicketsTabular.Controls.Add(this.tabTickets);
            this.TicketsTabular.Controls.Add(this.tabRequesicoes);
            this.TicketsTabular.Controls.Add(this.tabEquipamento);
            this.TicketsTabular.Controls.Add(this.Aux);
            this.TicketsTabular.Controls.Add(this.tabPerfil);
            this.TicketsTabular.Location = new System.Drawing.Point(1, 2);
            this.TicketsTabular.Name = "TicketsTabular";
            this.TicketsTabular.SelectedIndex = 0;
            this.TicketsTabular.Size = new System.Drawing.Size(1181, 496);
            this.TicketsTabular.TabIndex = 1;
            this.TicketsTabular.Click += new System.EventHandler(this.TicketsTabular_Click);
            // 
            // tabTickets
            // 
            this.tabTickets.Controls.Add(this.btnNovo);
            this.tabTickets.Controls.Add(this.listView2);
            this.tabTickets.Controls.Add(this.rdbRedes);
            this.tabTickets.Controls.Add(this.rdbSoftware);
            this.tabTickets.Controls.Add(this.rdbTodos);
            this.tabTickets.Controls.Add(this.rdbEquipamento);
            this.tabTickets.Controls.Add(this.textBox1);
            this.tabTickets.Controls.Add(this.label1);
            this.tabTickets.Controls.Add(this.lstTickets);
            this.tabTickets.Location = new System.Drawing.Point(4, 22);
            this.tabTickets.Name = "tabTickets";
            this.tabTickets.Padding = new System.Windows.Forms.Padding(3);
            this.tabTickets.Size = new System.Drawing.Size(1173, 470);
            this.tabTickets.TabIndex = 0;
            this.tabTickets.Text = "Tickets";
            this.tabTickets.UseVisualStyleBackColor = true;
            this.tabTickets.Enter += new System.EventHandler(this.tabTickets_Enter);
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
            this.lstTickets.FullRowSelect = true;
            this.lstTickets.Location = new System.Drawing.Point(6, 26);
            this.lstTickets.MultiSelect = false;
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(1162, 289);
            this.lstTickets.TabIndex = 0;
            this.lstTickets.UseCompatibleStateImageBehavior = false;
            this.lstTickets.SelectedIndexChanged += new System.EventHandler(this.lstTickets_SelectedIndexChanged);
            // 
            // tabRequesicoes
            // 
            this.tabRequesicoes.Controls.Add(this.listView3);
            this.tabRequesicoes.Location = new System.Drawing.Point(4, 22);
            this.tabRequesicoes.Name = "tabRequesicoes";
            this.tabRequesicoes.Size = new System.Drawing.Size(1173, 470);
            this.tabRequesicoes.TabIndex = 2;
            this.tabRequesicoes.Text = "Requesições";
            this.tabRequesicoes.UseVisualStyleBackColor = true;
            this.tabRequesicoes.Enter += new System.EventHandler(this.tabRequesicoes_Enter);
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(5, 35);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(1162, 289);
            this.listView3.TabIndex = 1;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // tabEquipamento
            // 
            this.tabEquipamento.Controls.Add(this.listView4);
            this.tabEquipamento.Location = new System.Drawing.Point(4, 22);
            this.tabEquipamento.Name = "tabEquipamento";
            this.tabEquipamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabEquipamento.Size = new System.Drawing.Size(1173, 470);
            this.tabEquipamento.TabIndex = 1;
            this.tabEquipamento.Text = "Equipamento";
            this.tabEquipamento.UseVisualStyleBackColor = true;
            this.tabEquipamento.Enter += new System.EventHandler(this.tabEquipamento_Enter);
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(5, 91);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1162, 289);
            this.listView4.TabIndex = 1;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // Aux
            // 
            this.Aux.Controls.Add(this.tbAuxs);
            this.Aux.Location = new System.Drawing.Point(4, 22);
            this.Aux.Name = "Aux";
            this.Aux.Size = new System.Drawing.Size(1173, 470);
            this.Aux.TabIndex = 3;
            this.Aux.Text = "Dados Auxiliares";
            this.Aux.UseVisualStyleBackColor = true;
            // 
            // tbAuxs
            // 
            this.tbAuxs.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbAuxs.Controls.Add(this.tabAuxs);
            this.tbAuxs.Controls.Add(this.tbAreas);
            this.tbAuxs.Controls.Add(this.tbStates);
            this.tbAuxs.Controls.Add(this.tbPriority);
            this.tbAuxs.Controls.Add(this.tbMateriais);
            this.tbAuxs.Location = new System.Drawing.Point(7, 3);
            this.tbAuxs.Multiline = true;
            this.tbAuxs.Name = "tbAuxs";
            this.tbAuxs.SelectedIndex = 0;
            this.tbAuxs.Size = new System.Drawing.Size(1160, 464);
            this.tbAuxs.TabIndex = 0;
            this.tbAuxs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbAuxs_Selected);
            // 
            // tabAuxs
            // 
            this.tabAuxs.Controls.Add(this.btnHabilitSave);
            this.tabAuxs.Controls.Add(this.txtHabilitDescr);
            this.tabAuxs.Controls.Add(this.label7);
            this.tabAuxs.Controls.Add(this.txtNivel);
            this.tabAuxs.Controls.Add(this.label6);
            this.tabAuxs.Controls.Add(this.lstHabilit);
            this.tabAuxs.Location = new System.Drawing.Point(23, 4);
            this.tabAuxs.Name = "tabAuxs";
            this.tabAuxs.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuxs.Size = new System.Drawing.Size(1133, 456);
            this.tabAuxs.TabIndex = 0;
            this.tabAuxs.Text = "Habilitações";
            this.tabAuxs.UseVisualStyleBackColor = true;
            this.tabAuxs.Enter += new System.EventHandler(this.tabAuxs_Enter);
            // 
            // btnHabilitSave
            // 
            this.btnHabilitSave.Location = new System.Drawing.Point(1069, 3);
            this.btnHabilitSave.Name = "btnHabilitSave";
            this.btnHabilitSave.Size = new System.Drawing.Size(61, 61);
            this.btnHabilitSave.TabIndex = 20;
            this.btnHabilitSave.Text = "Gravar";
            this.btnHabilitSave.UseVisualStyleBackColor = true;
            // 
            // txtHabilitDescr
            // 
            this.txtHabilitDescr.Location = new System.Drawing.Point(610, 40);
            this.txtHabilitDescr.Name = "txtHabilitDescr";
            this.txtHabilitDescr.Size = new System.Drawing.Size(433, 20);
            this.txtHabilitDescr.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(476, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Habilitação Literária:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(610, 6);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(63, 20);
            this.txtNivel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(499, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nível:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstHabilit
            // 
            this.lstHabilit.Location = new System.Drawing.Point(0, 0);
            this.lstHabilit.Name = "lstHabilit";
            this.lstHabilit.Size = new System.Drawing.Size(464, 400);
            this.lstHabilit.TabIndex = 0;
            this.lstHabilit.UseCompatibleStateImageBehavior = false;
            // 
            // tbAreas
            // 
            this.tbAreas.Controls.Add(this.btnAreasSave);
            this.tbAreas.Controls.Add(this.txtAreaDescr);
            this.tbAreas.Controls.Add(this.label8);
            this.tbAreas.Controls.Add(this.txtAreaNivel);
            this.tbAreas.Controls.Add(this.label9);
            this.tbAreas.Controls.Add(this.lstAreas);
            this.tbAreas.Location = new System.Drawing.Point(23, 4);
            this.tbAreas.Name = "tbAreas";
            this.tbAreas.Padding = new System.Windows.Forms.Padding(3);
            this.tbAreas.Size = new System.Drawing.Size(1133, 456);
            this.tbAreas.TabIndex = 1;
            this.tbAreas.Text = "Areas";
            this.tbAreas.UseVisualStyleBackColor = true;
            // 
            // btnAreasSave
            // 
            this.btnAreasSave.Location = new System.Drawing.Point(1069, 3);
            this.btnAreasSave.Name = "btnAreasSave";
            this.btnAreasSave.Size = new System.Drawing.Size(61, 61);
            this.btnAreasSave.TabIndex = 20;
            this.btnAreasSave.Text = "Gravar";
            this.btnAreasSave.UseVisualStyleBackColor = true;
            // 
            // txtAreaDescr
            // 
            this.txtAreaDescr.Location = new System.Drawing.Point(610, 40);
            this.txtAreaDescr.Name = "txtAreaDescr";
            this.txtAreaDescr.Size = new System.Drawing.Size(433, 20);
            this.txtAreaDescr.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(476, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Area de Intrevenção:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAreaNivel
            // 
            this.txtAreaNivel.Location = new System.Drawing.Point(610, 6);
            this.txtAreaNivel.Name = "txtAreaNivel";
            this.txtAreaNivel.Size = new System.Drawing.Size(63, 20);
            this.txtAreaNivel.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(499, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Habilitação Minima:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstAreas
            // 
            this.lstAreas.Location = new System.Drawing.Point(0, 0);
            this.lstAreas.Name = "lstAreas";
            this.lstAreas.Size = new System.Drawing.Size(464, 400);
            this.lstAreas.TabIndex = 5;
            this.lstAreas.UseCompatibleStateImageBehavior = false;
            // 
            // tbStates
            // 
            this.tbStates.Controls.Add(this.btnStateSave);
            this.tbStates.Controls.Add(this.chkStateIsRequest);
            this.tbStates.Controls.Add(this.chkStateIsTicket);
            this.tbStates.Controls.Add(this.chkStateIsReject);
            this.tbStates.Controls.Add(this.chkStateIsFinal);
            this.tbStates.Controls.Add(this.txtStateDescr);
            this.tbStates.Controls.Add(this.label10);
            this.tbStates.Controls.Add(this.lstStates);
            this.tbStates.Location = new System.Drawing.Point(23, 4);
            this.tbStates.Name = "tbStates";
            this.tbStates.Size = new System.Drawing.Size(1133, 456);
            this.tbStates.TabIndex = 2;
            this.tbStates.Text = "Estados";
            this.tbStates.UseVisualStyleBackColor = true;
            this.tbStates.Enter += new System.EventHandler(this.tbStates_Enter);
            // 
            // btnStateSave
            // 
            this.btnStateSave.Location = new System.Drawing.Point(1069, 3);
            this.btnStateSave.Name = "btnStateSave";
            this.btnStateSave.Size = new System.Drawing.Size(61, 61);
            this.btnStateSave.TabIndex = 19;
            this.btnStateSave.Text = "Gravar";
            this.btnStateSave.UseVisualStyleBackColor = true;
            // 
            // chkStateIsRequest
            // 
            this.chkStateIsRequest.AutoSize = true;
            this.chkStateIsRequest.Location = new System.Drawing.Point(890, 40);
            this.chkStateIsRequest.Name = "chkStateIsRequest";
            this.chkStateIsRequest.Size = new System.Drawing.Size(93, 17);
            this.chkStateIsRequest.TabIndex = 18;
            this.chkStateIsRequest.Text = "É Requesição";
            this.chkStateIsRequest.UseVisualStyleBackColor = true;
            // 
            // chkStateIsTicket
            // 
            this.chkStateIsTicket.AutoSize = true;
            this.chkStateIsTicket.Location = new System.Drawing.Point(799, 40);
            this.chkStateIsTicket.Name = "chkStateIsTicket";
            this.chkStateIsTicket.Size = new System.Drawing.Size(66, 17);
            this.chkStateIsTicket.TabIndex = 17;
            this.chkStateIsTicket.Text = "É Ticket";
            this.chkStateIsTicket.UseVisualStyleBackColor = true;
            // 
            // chkStateIsReject
            // 
            this.chkStateIsReject.AutoSize = true;
            this.chkStateIsReject.Location = new System.Drawing.Point(693, 40);
            this.chkStateIsReject.Name = "chkStateIsReject";
            this.chkStateIsReject.Size = new System.Drawing.Size(81, 17);
            this.chkStateIsReject.TabIndex = 16;
            this.chkStateIsReject.Text = "É Rejeitado";
            this.chkStateIsReject.UseVisualStyleBackColor = true;
            // 
            // chkStateIsFinal
            // 
            this.chkStateIsFinal.AutoSize = true;
            this.chkStateIsFinal.Location = new System.Drawing.Point(610, 40);
            this.chkStateIsFinal.Name = "chkStateIsFinal";
            this.chkStateIsFinal.Size = new System.Drawing.Size(58, 17);
            this.chkStateIsFinal.TabIndex = 15;
            this.chkStateIsFinal.Text = "É Final";
            this.chkStateIsFinal.UseVisualStyleBackColor = true;
            // 
            // txtStateDescr
            // 
            this.txtStateDescr.Location = new System.Drawing.Point(610, 6);
            this.txtStateDescr.Name = "txtStateDescr";
            this.txtStateDescr.Size = new System.Drawing.Size(373, 20);
            this.txtStateDescr.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(476, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nome do Estado:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstStates
            // 
            this.lstStates.Location = new System.Drawing.Point(0, 0);
            this.lstStates.Name = "lstStates";
            this.lstStates.Size = new System.Drawing.Size(464, 400);
            this.lstStates.TabIndex = 10;
            this.lstStates.UseCompatibleStateImageBehavior = false;
            // 
            // tbPriority
            // 
            this.tbPriority.Controls.Add(this.btnPrioSave);
            this.tbPriority.Controls.Add(this.txtPrioDescr);
            this.tbPriority.Controls.Add(this.label12);
            this.tbPriority.Controls.Add(this.txtPrioLevel);
            this.tbPriority.Controls.Add(this.label13);
            this.tbPriority.Controls.Add(this.lstPrio);
            this.tbPriority.Location = new System.Drawing.Point(23, 4);
            this.tbPriority.Name = "tbPriority";
            this.tbPriority.Size = new System.Drawing.Size(1133, 456);
            this.tbPriority.TabIndex = 3;
            this.tbPriority.Text = "Prioridades";
            this.tbPriority.UseVisualStyleBackColor = true;
            // 
            // btnPrioSave
            // 
            this.btnPrioSave.Location = new System.Drawing.Point(1069, 3);
            this.btnPrioSave.Name = "btnPrioSave";
            this.btnPrioSave.Size = new System.Drawing.Size(61, 61);
            this.btnPrioSave.TabIndex = 20;
            this.btnPrioSave.Text = "Gravar";
            this.btnPrioSave.UseVisualStyleBackColor = true;
            // 
            // txtPrioDescr
            // 
            this.txtPrioDescr.Location = new System.Drawing.Point(610, 40);
            this.txtPrioDescr.Name = "txtPrioDescr";
            this.txtPrioDescr.Size = new System.Drawing.Size(433, 20);
            this.txtPrioDescr.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(476, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Nome da Prioridade:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrioLevel
            // 
            this.txtPrioLevel.Location = new System.Drawing.Point(610, 6);
            this.txtPrioLevel.Name = "txtPrioLevel";
            this.txtPrioLevel.Size = new System.Drawing.Size(63, 20);
            this.txtPrioLevel.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(499, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Nivel da Prioridade:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstPrio
            // 
            this.lstPrio.Location = new System.Drawing.Point(0, 0);
            this.lstPrio.Name = "lstPrio";
            this.lstPrio.Size = new System.Drawing.Size(464, 400);
            this.lstPrio.TabIndex = 15;
            this.lstPrio.UseCompatibleStateImageBehavior = false;
            // 
            // tbMateriais
            // 
            this.tbMateriais.Controls.Add(this.btnMatSave);
            this.tbMateriais.Controls.Add(this.chkMatIsSoftware);
            this.tbMateriais.Controls.Add(this.textBox5);
            this.tbMateriais.Controls.Add(this.label16);
            this.tbMateriais.Controls.Add(this.textBox3);
            this.tbMateriais.Controls.Add(this.label11);
            this.tbMateriais.Controls.Add(this.textBox8);
            this.tbMateriais.Controls.Add(this.label14);
            this.tbMateriais.Controls.Add(this.textBox9);
            this.tbMateriais.Controls.Add(this.label15);
            this.tbMateriais.Controls.Add(this.lstMateriais);
            this.tbMateriais.Location = new System.Drawing.Point(23, 4);
            this.tbMateriais.Name = "tbMateriais";
            this.tbMateriais.Size = new System.Drawing.Size(1133, 456);
            this.tbMateriais.TabIndex = 4;
            this.tbMateriais.Text = "Materiais";
            this.tbMateriais.UseVisualStyleBackColor = true;
            this.tbMateriais.UseWaitCursor = true;
            this.tbMateriais.Enter += new System.EventHandler(this.tbMateriais_Enter);
            // 
            // btnMatSave
            // 
            this.btnMatSave.Location = new System.Drawing.Point(1069, 3);
            this.btnMatSave.Name = "btnMatSave";
            this.btnMatSave.Size = new System.Drawing.Size(61, 61);
            this.btnMatSave.TabIndex = 25;
            this.btnMatSave.Text = "Gravar";
            this.btnMatSave.UseVisualStyleBackColor = true;
            this.btnMatSave.UseWaitCursor = true;
            // 
            // chkMatIsSoftware
            // 
            this.chkMatIsSoftware.AutoSize = true;
            this.chkMatIsSoftware.Location = new System.Drawing.Point(712, 9);
            this.chkMatIsSoftware.Name = "chkMatIsSoftware";
            this.chkMatIsSoftware.Size = new System.Drawing.Size(78, 17);
            this.chkMatIsSoftware.TabIndex = 24;
            this.chkMatIsSoftware.Text = "É Software";
            this.chkMatIsSoftware.UseVisualStyleBackColor = true;
            this.chkMatIsSoftware.UseWaitCursor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(610, 111);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(433, 20);
            this.textBox5.TabIndex = 23;
            this.textBox5.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(499, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Preço:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(610, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(433, 20);
            this.textBox3.TabIndex = 21;
            this.textBox3.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(499, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Fornecedor:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.UseWaitCursor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(610, 41);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(433, 20);
            this.textBox8.TabIndex = 19;
            this.textBox8.UseWaitCursor = true;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(499, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Nome da Peça:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.UseWaitCursor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(610, 6);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(63, 20);
            this.textBox9.TabIndex = 17;
            this.textBox9.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(499, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "PartNumber:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.UseWaitCursor = true;
            // 
            // lstMateriais
            // 
            this.lstMateriais.Location = new System.Drawing.Point(0, 0);
            this.lstMateriais.Name = "lstMateriais";
            this.lstMateriais.Size = new System.Drawing.Size(464, 400);
            this.lstMateriais.TabIndex = 15;
            this.lstMateriais.UseCompatibleStateImageBehavior = false;
            this.lstMateriais.UseWaitCursor = true;
            // 
            // tabPerfil
            // 
            this.tabPerfil.Controls.Add(this.chkIsSuper);
            this.tabPerfil.Controls.Add(this.chkIsTeck);
            this.tabPerfil.Controls.Add(this.chkIsAdmin);
            this.tabPerfil.Controls.Add(this.btnPerfilNovo);
            this.tabPerfil.Controls.Add(this.btnPerfilSave);
            this.tabPerfil.Controls.Add(this.cbxPerfilHabilit);
            this.tabPerfil.Controls.Add(this.label5);
            this.tabPerfil.Controls.Add(this.txtPerfilSenha);
            this.tabPerfil.Controls.Add(this.label4);
            this.tabPerfil.Controls.Add(this.txtPerfilNome);
            this.tabPerfil.Controls.Add(this.label3);
            this.tabPerfil.Controls.Add(this.txtPerfilNIF);
            this.tabPerfil.Controls.Add(this.label2);
            this.tabPerfil.Controls.Add(this.lstPerfil);
            this.tabPerfil.Location = new System.Drawing.Point(4, 22);
            this.tabPerfil.Name = "tabPerfil";
            this.tabPerfil.Size = new System.Drawing.Size(1173, 470);
            this.tabPerfil.TabIndex = 4;
            this.tabPerfil.Text = "Perfil";
            this.tabPerfil.UseVisualStyleBackColor = true;
            this.tabPerfil.Click += new System.EventHandler(this.tabPerfil_Click);
            this.tabPerfil.Enter += new System.EventHandler(this.tabPerfil_Enter);
            // 
            // btnPerfilNovo
            // 
            this.btnPerfilNovo.Location = new System.Drawing.Point(1046, 3);
            this.btnPerfilNovo.Name = "btnPerfilNovo";
            this.btnPerfilNovo.Size = new System.Drawing.Size(59, 53);
            this.btnPerfilNovo.TabIndex = 10;
            this.btnPerfilNovo.Text = "Novo";
            this.btnPerfilNovo.UseVisualStyleBackColor = true;
            // 
            // btnPerfilSave
            // 
            this.btnPerfilSave.Location = new System.Drawing.Point(1111, 3);
            this.btnPerfilSave.Name = "btnPerfilSave";
            this.btnPerfilSave.Size = new System.Drawing.Size(59, 53);
            this.btnPerfilSave.TabIndex = 9;
            this.btnPerfilSave.Text = "Gravar";
            this.btnPerfilSave.UseVisualStyleBackColor = true;
            // 
            // cbxPerfilHabilit
            // 
            this.cbxPerfilHabilit.FormattingEnabled = true;
            this.cbxPerfilHabilit.Location = new System.Drawing.Point(748, 143);
            this.cbxPerfilHabilit.Name = "cbxPerfilHabilit";
            this.cbxPerfilHabilit.Size = new System.Drawing.Size(406, 21);
            this.cbxPerfilHabilit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(639, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nivel de Habilitação";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerfilSenha
            // 
            this.txtPerfilSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfilSenha.Location = new System.Drawing.Point(748, 105);
            this.txtPerfilSenha.Name = "txtPerfilSenha";
            this.txtPerfilSenha.Size = new System.Drawing.Size(406, 21);
            this.txtPerfilSenha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(697, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerfilNome
            // 
            this.txtPerfilNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfilNome.Location = new System.Drawing.Point(748, 67);
            this.txtPerfilNome.Name = "txtPerfilNome";
            this.txtPerfilNome.Size = new System.Drawing.Size(406, 21);
            this.txtPerfilNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(704, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPerfilNIF
            // 
            this.txtPerfilNIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfilNIF.Location = new System.Drawing.Point(748, 29);
            this.txtPerfilNIF.Name = "txtPerfilNIF";
            this.txtPerfilNIF.Size = new System.Drawing.Size(94, 21);
            this.txtPerfilNIF.TabIndex = 2;
            this.txtPerfilNIF.Text = "000000000";
            this.txtPerfilNIF.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(713, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstPerfil
            // 
            this.lstPerfil.FullRowSelect = true;
            this.lstPerfil.Location = new System.Drawing.Point(7, 27);
            this.lstPerfil.MultiSelect = false;
            this.lstPerfil.Name = "lstPerfil";
            this.lstPerfil.Size = new System.Drawing.Size(607, 440);
            this.lstPerfil.TabIndex = 0;
            this.lstPerfil.UseCompatibleStateImageBehavior = false;
            // 
            // chkIsSuper
            // 
            this.chkIsSuper.AutoSize = true;
            this.chkIsSuper.Location = new System.Drawing.Point(937, 182);
            this.chkIsSuper.Name = "chkIsSuper";
            this.chkIsSuper.Size = new System.Drawing.Size(86, 17);
            this.chkIsSuper.TabIndex = 20;
            this.chkIsSuper.Text = "É SuperUser";
            this.chkIsSuper.UseVisualStyleBackColor = true;
            // 
            // chkIsTeck
            // 
            this.chkIsTeck.AutoSize = true;
            this.chkIsTeck.Location = new System.Drawing.Point(831, 182);
            this.chkIsTeck.Name = "chkIsTeck";
            this.chkIsTeck.Size = new System.Drawing.Size(75, 17);
            this.chkIsTeck.TabIndex = 19;
            this.chkIsTeck.Text = "É Técnico";
            this.chkIsTeck.UseVisualStyleBackColor = true;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Location = new System.Drawing.Point(748, 182);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(65, 17);
            this.chkIsAdmin.TabIndex = 18;
            this.chkIsAdmin.Text = "É Admin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // FormTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 519);
            this.Controls.Add(this.TicketsTabular);
            this.Controls.Add(this.StatusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormTickets";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tickets_Form_Load);
            this.TicketsTabular.ResumeLayout(false);
            this.tabTickets.ResumeLayout(false);
            this.tabTickets.PerformLayout();
            this.tabRequesicoes.ResumeLayout(false);
            this.tabEquipamento.ResumeLayout(false);
            this.Aux.ResumeLayout(false);
            this.tbAuxs.ResumeLayout(false);
            this.tabAuxs.ResumeLayout(false);
            this.tabAuxs.PerformLayout();
            this.tbAreas.ResumeLayout(false);
            this.tbAreas.PerformLayout();
            this.tbStates.ResumeLayout(false);
            this.tbStates.PerformLayout();
            this.tbPriority.ResumeLayout(false);
            this.tbPriority.PerformLayout();
            this.tbMateriais.ResumeLayout(false);
            this.tbMateriais.PerformLayout();
            this.tabPerfil.ResumeLayout(false);
            this.tabPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.TabControl TicketsTabular;
        private System.Windows.Forms.TabPage tabTickets;
        private System.Windows.Forms.TabPage tabEquipamento;
        private System.Windows.Forms.RadioButton rdbRedes;
        private System.Windows.Forms.RadioButton rdbSoftware;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbEquipamento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstTickets;
        private System.Windows.Forms.TabPage tabRequesicoes;
        private System.Windows.Forms.TabPage Aux;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TabPage tabPerfil;
        private System.Windows.Forms.ComboBox cbxPerfilHabilit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPerfilSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPerfilNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerfilNIF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstPerfil;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.TabControl tbAuxs;
        private System.Windows.Forms.TabPage tabAuxs;
        private System.Windows.Forms.TabPage tbAreas;
        private System.Windows.Forms.TabPage tbStates;
        private System.Windows.Forms.TabPage tbPriority;
        private System.Windows.Forms.TabPage tbMateriais;
        private System.Windows.Forms.ListView lstHabilit;
        private System.Windows.Forms.TextBox txtHabilitDescr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAreaDescr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAreaNivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lstAreas;
        private System.Windows.Forms.TextBox txtStateDescr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lstStates;
        private System.Windows.Forms.TextBox txtPrioDescr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrioLevel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView lstPrio;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView lstMateriais;
        private System.Windows.Forms.CheckBox chkStateIsRequest;
        private System.Windows.Forms.CheckBox chkStateIsTicket;
        private System.Windows.Forms.CheckBox chkStateIsReject;
        private System.Windows.Forms.CheckBox chkStateIsFinal;
        private System.Windows.Forms.CheckBox chkMatIsSoftware;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHabilitSave;
        private System.Windows.Forms.Button btnAreasSave;
        private System.Windows.Forms.Button btnStateSave;
        private System.Windows.Forms.Button btnPrioSave;
        private System.Windows.Forms.Button btnMatSave;
        private System.Windows.Forms.Button btnPerfilSave;
        private System.Windows.Forms.Button btnPerfilNovo;
        private System.Windows.Forms.CheckBox chkIsSuper;
        private System.Windows.Forms.CheckBox chkIsTeck;
        private System.Windows.Forms.CheckBox chkIsAdmin;
    }
}

