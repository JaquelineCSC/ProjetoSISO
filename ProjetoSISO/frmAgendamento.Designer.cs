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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.cbHora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDentista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 680);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paciente";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(57, 703);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(302, 26);
            this.txtPaciente.TabIndex = 1;
            this.txtPaciente.TextChanged += new System.EventHandler(this.txtPaciente_TextChanged);
            // 
            // dgPaciente
            // 
            this.dgPaciente.AllowUserToAddRows = false;
            this.dgPaciente.AllowUserToDeleteRows = false;
            this.dgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaciente.Location = new System.Drawing.Point(57, 751);
            this.dgPaciente.Name = "dgPaciente";
            this.dgPaciente.ReadOnly = true;
            this.dgPaciente.RowHeadersWidth = 62;
            this.dgPaciente.RowTemplate.Height = 28;
            this.dgPaciente.Size = new System.Drawing.Size(976, 163);
            this.dgPaciente.TabIndex = 2;
            this.dgPaciente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPaciente_CellEnter);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(716, 154);
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
            this.dgDentista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDentista.Location = new System.Drawing.Point(57, 154);
            this.dgDentista.Name = "dgDentista";
            this.dgDentista.ReadOnly = true;
            this.dgDentista.RowHeadersWidth = 62;
            this.dgDentista.RowTemplate.Height = 28;
            this.dgDentista.Size = new System.Drawing.Size(646, 252);
            this.dgDentista.TabIndex = 4;
            this.dgDentista.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDentista_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dentista";
            // 
            // txtDentista
            // 
            this.txtDentista.Location = new System.Drawing.Point(57, 111);
            this.txtDentista.Name = "txtDentista";
            this.txtDentista.Size = new System.Drawing.Size(302, 26);
            this.txtDentista.TabIndex = 1;
            this.txtDentista.TextChanged += new System.EventHandler(this.txtDentista_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data de agendamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(914, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Horário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Consultas do dentista no dia informado";
            // 
            // dgAgendamentos
            // 
            this.dgAgendamentos.AllowUserToAddRows = false;
            this.dgAgendamentos.AllowUserToDeleteRows = false;
            this.dgAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgendamentos.Location = new System.Drawing.Point(57, 462);
            this.dgAgendamentos.Name = "dgAgendamentos";
            this.dgAgendamentos.ReadOnly = true;
            this.dgAgendamentos.RowHeadersWidth = 62;
            this.dgAgendamentos.RowTemplate.Height = 28;
            this.dgAgendamentos.Size = new System.Drawing.Size(976, 175);
            this.dgAgendamentos.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmdConfirmar);
            this.groupBox1.Location = new System.Drawing.Point(1156, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 866);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirmação de dados";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbHora);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbDataAg);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(39, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 127);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(287, 74);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(117, 29);
            this.lbHora.TabIndex = 5;
            this.lbHora.Text = "00000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 29);
            this.label12.TabIndex = 5;
            this.label12.Text = "Horário da Consulta:";
            // 
            // lbDataAg
            // 
            this.lbDataAg.AutoSize = true;
            this.lbDataAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAg.Location = new System.Drawing.Point(287, 29);
            this.lbDataAg.Name = "lbDataAg";
            this.lbDataAg.Size = new System.Drawing.Size(117, 29);
            this.lbDataAg.TabIndex = 5;
            this.lbDataAg.Text = "00000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Data da consulta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbEspDent);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbNomeDent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(39, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 119);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // lbEspDent
            // 
            this.lbEspDent.AutoSize = true;
            this.lbEspDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspDent.Location = new System.Drawing.Point(288, 74);
            this.lbEspDent.Name = "lbEspDent";
            this.lbEspDent.Size = new System.Drawing.Size(117, 29);
            this.lbEspDent.TabIndex = 5;
            this.lbEspDent.Text = "00000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Especialização:";
            // 
            // lbNomeDent
            // 
            this.lbNomeDent.AutoSize = true;
            this.lbNomeDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeDent.Location = new System.Drawing.Point(288, 29);
            this.lbNomeDent.Name = "lbNomeDent";
            this.lbNomeDent.Size = new System.Drawing.Size(117, 29);
            this.lbNomeDent.TabIndex = 4;
            this.lbNomeDent.Text = "00000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 29);
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
            this.groupBox2.Location = new System.Drawing.Point(39, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 165);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lbNascPac
            // 
            this.lbNascPac.AutoSize = true;
            this.lbNascPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascPac.Location = new System.Drawing.Point(291, 116);
            this.lbNascPac.Name = "lbNascPac";
            this.lbNascPac.Size = new System.Drawing.Size(117, 29);
            this.lbNascPac.TabIndex = 3;
            this.lbNascPac.Text = "00000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data de Nascimento:";
            // 
            // lbCpfPac
            // 
            this.lbCpfPac.AutoSize = true;
            this.lbCpfPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfPac.Location = new System.Drawing.Point(291, 72);
            this.lbCpfPac.Name = "lbCpfPac";
            this.lbCpfPac.Size = new System.Drawing.Size(117, 29);
            this.lbCpfPac.TabIndex = 2;
            this.lbCpfPac.Text = "00000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "CPF:";
            // 
            // lbNomePac
            // 
            this.lbNomePac.AutoSize = true;
            this.lbNomePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePac.Location = new System.Drawing.Point(291, 27);
            this.lbNomePac.Name = "lbNomePac";
            this.lbNomePac.Size = new System.Drawing.Size(117, 29);
            this.lbNomePac.TabIndex = 1;
            this.lbNomePac.Text = "00000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome do Paciente:";
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.Location = new System.Drawing.Point(129, 511);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(264, 44);
            this.cmdConfirmar.TabIndex = 0;
            this.cmdConfirmar.Text = "Confirmar";
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // cbHora
            // 
            this.cbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbHora.Location = new System.Drawing.Point(918, 703);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(121, 28);
            this.cbHora.TabIndex = 7;
            this.cbHora.SelectedValueChanged += new System.EventHandler(this.cbHora_SelectedValueChanged);
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 976);
            this.Controls.Add(this.cbHora);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "frmAgendamento";
            this.Text = "frmAgendamento";
            this.Load += new System.EventHandler(this.frmAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDentista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}