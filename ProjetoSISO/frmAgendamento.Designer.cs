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
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgAgendamentos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDentista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgendamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(918, 703);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(116, 26);
            this.txtHora.TabIndex = 5;
            this.txtHora.ValidatingType = typeof(System.DateTime);
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1156, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 1095);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 1028);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHora);
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
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgAgendamentos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}