namespace ProjetoSISO {
    partial class frmAgendamento {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.dgPaciente = new System.Windows.Forms.DataGridView();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.dgDentista = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDentista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgAgendamentos = new System.Windows.Forms.DataGridView();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbHora = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbDataAg = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbEspDent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbNomeDent = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNascPac = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCpfPac = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNomePac = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDentista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamentos)).BeginInit();
            this.gbDados.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(709, 329);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(284, 23);
            this.txtPaciente.TabIndex = 1;
            this.txtPaciente.TextChanged += new System.EventHandler(this.txtPaciente_TextChanged);
            // 
            // dgPaciente
            // 
            this.dgPaciente.AllowUserToAddRows = false;
            this.dgPaciente.AllowUserToDeleteRows = false;
            this.dgPaciente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaciente.Location = new System.Drawing.Point(709, 359);
            this.dgPaciente.Name = "dgPaciente";
            this.dgPaciente.ReadOnly = true;
            this.dgPaciente.RowHeadersWidth = 62;
            this.dgPaciente.RowTemplate.Height = 28;
            this.dgPaciente.Size = new System.Drawing.Size(400, 142);
            this.dgPaciente.TabIndex = 2;
            this.dgPaciente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPaciente_CellEnter);
            // 
            // Calendar
            // 
            this.Calendar.BackColor = System.Drawing.SystemColors.Menu;
            this.Calendar.Location = new System.Drawing.Point(150, 121);
            this.Calendar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Calendar.MaxDate = new System.DateTime(2500, 2, 2, 0, 0, 0, 0);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 3;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // dgDentista
            // 
            this.dgDentista.AllowUserToAddRows = false;
            this.dgDentista.AllowUserToDeleteRows = false;
            this.dgDentista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDentista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDentista.Location = new System.Drawing.Point(150, 359);
            this.dgDentista.Name = "dgDentista";
            this.dgDentista.ReadOnly = true;
            this.dgDentista.RowHeadersWidth = 62;
            this.dgDentista.RowTemplate.Height = 28;
            this.dgDentista.Size = new System.Drawing.Size(400, 142);
            this.dgDentista.TabIndex = 4;
            this.dgDentista.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDentista_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dentista";
            // 
            // txtDentista
            // 
            this.txtDentista.Location = new System.Drawing.Point(150, 329);
            this.txtDentista.Name = "txtDentista";
            this.txtDentista.Size = new System.Drawing.Size(284, 23);
            this.txtDentista.TabIndex = 1;
            this.txtDentista.TextChanged += new System.EventHandler(this.txtDentista_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de agendamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horário de agendamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(708, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Consultas do dentista no dia informado";
            // 
            // dgAgendamentos
            // 
            this.dgAgendamentos.AllowUserToAddRows = false;
            this.dgAgendamentos.AllowUserToDeleteRows = false;
            this.dgAgendamentos.AllowUserToResizeColumns = false;
            this.dgAgendamentos.AllowUserToResizeRows = false;
            this.dgAgendamentos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgendamentos.Location = new System.Drawing.Point(709, 121);
            this.dgAgendamentos.MultiSelect = false;
            this.dgAgendamentos.Name = "dgAgendamentos";
            this.dgAgendamentos.RowHeadersWidth = 62;
            this.dgAgendamentos.RowTemplate.Height = 28;
            this.dgAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAgendamentos.ShowCellErrors = false;
            this.dgAgendamentos.Size = new System.Drawing.Size(400, 142);
            this.dgAgendamentos.TabIndex = 4;
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.cmdExcluir);
            this.gbDados.Controls.Add(this.cmdLimpar);
            this.gbDados.Controls.Add(this.groupBox4);
            this.gbDados.Controls.Add(this.groupBox3);
            this.gbDados.Controls.Add(this.groupBox2);
            this.gbDados.Controls.Add(this.cmdConfirmar);
            this.gbDados.Controls.Add(this.label13);
            this.gbDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDados.Location = new System.Drawing.Point(31, 521);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(1131, 271);
            this.gbDados.TabIndex = 6;
            this.gbDados.TabStop = false;
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = global::ProjetoSISO.Properties.Resources.trash_52px;
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcluir.FlatAppearance.BorderSize = 0;
            this.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcluir.Location = new System.Drawing.Point(582, 190);
            this.cmdExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(50, 46);
            this.cmdExcluir.TabIndex = 10;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.BackgroundImage = global::ProjetoSISO.Properties.Resources.erase;
            this.cmdLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdLimpar.FlatAppearance.BorderSize = 0;
            this.cmdLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpar.Location = new System.Drawing.Point(750, 190);
            this.cmdLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(51, 46);
            this.cmdLimpar.TabIndex = 9;
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbHora);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbDataAg);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(858, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 95);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(164, 55);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(81, 20);
            this.lbHora.TabIndex = 5;
            this.lbHora.Text = "00000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Horário da Consulta:";
            // 
            // lbDataAg
            // 
            this.lbDataAg.AutoSize = true;
            this.lbDataAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAg.Location = new System.Drawing.Point(164, 18);
            this.lbDataAg.Name = "lbDataAg";
            this.lbDataAg.Size = new System.Drawing.Size(81, 20);
            this.lbDataAg.TabIndex = 5;
            this.lbDataAg.Text = "00000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Data da consulta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbEspDent);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbNomeDent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(13, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 90);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // lbEspDent
            // 
            this.lbEspDent.AutoSize = true;
            this.lbEspDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspDent.Location = new System.Drawing.Point(151, 55);
            this.lbEspDent.Name = "lbEspDent";
            this.lbEspDent.Size = new System.Drawing.Size(81, 20);
            this.lbEspDent.TabIndex = 5;
            this.lbEspDent.Text = "00000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Especialização:";
            // 
            // lbNomeDent
            // 
            this.lbNomeDent.AutoSize = true;
            this.lbNomeDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeDent.Location = new System.Drawing.Point(151, 18);
            this.lbNomeDent.Name = "lbNomeDent";
            this.lbNomeDent.Size = new System.Drawing.Size(81, 20);
            this.lbNomeDent.TabIndex = 4;
            this.lbNomeDent.Text = "00000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Nome do Dentista:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNascPac);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbCpfPac);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbNomePac);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(421, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 136);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lbNascPac
            // 
            this.lbNascPac.AutoSize = true;
            this.lbNascPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascPac.Location = new System.Drawing.Point(170, 92);
            this.lbNascPac.Name = "lbNascPac";
            this.lbNascPac.Size = new System.Drawing.Size(81, 20);
            this.lbNascPac.TabIndex = 3;
            this.lbNascPac.Text = "00000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data de Nascimento:";
            // 
            // lbCpfPac
            // 
            this.lbCpfPac.AutoSize = true;
            this.lbCpfPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfPac.Location = new System.Drawing.Point(170, 55);
            this.lbCpfPac.Name = "lbCpfPac";
            this.lbCpfPac.Size = new System.Drawing.Size(81, 20);
            this.lbCpfPac.TabIndex = 2;
            this.lbCpfPac.Text = "00000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "CPF:";
            // 
            // lbNomePac
            // 
            this.lbNomePac.AutoSize = true;
            this.lbNomePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePac.Location = new System.Drawing.Point(170, 18);
            this.lbNomePac.Name = "lbNomePac";
            this.lbNomePac.Size = new System.Drawing.Size(81, 20);
            this.lbNomePac.TabIndex = 1;
            this.lbNomePac.Text = "00000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome do Paciente:";
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.BackgroundImage = global::ProjetoSISO.Properties.Resources.save;
            this.cmdConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdConfirmar.FlatAppearance.BorderSize = 0;
            this.cmdConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConfirmar.Location = new System.Drawing.Point(415, 190);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(57, 46);
            this.cmdConfirmar.TabIndex = 0;
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(515, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Confirmação de dados";
            // 
            // cbHora
            // 
            this.cbHora.BackColor = System.Drawing.SystemColors.Control;
            this.cbHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30"});
            this.cbHora.Location = new System.Drawing.Point(434, 158);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(118, 28);
            this.cbHora.TabIndex = 7;
            this.cbHora.SelectedValueChanged += new System.EventHandler(this.cbHora_SelectedValueChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjetoSISO.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(49, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 42);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 838);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.dgAgendamentos);
            this.Controls.Add(this.dgDentista);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.dgPaciente);
            this.Controls.Add(this.txtDentista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgendamento";
            this.Text = "frmAgendamento";
            this.Load += new System.EventHandler(this.frmAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDentista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamentos)).EndInit();
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.DataGridView dgPaciente;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.DataGridView dgDentista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDentista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgAgendamentos;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.Label lbEspDent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNomeDent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbNascPac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCpfPac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNomePac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDataAg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdLimpar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cmdExcluir;
    }
}