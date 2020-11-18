namespace ProjetoSISO
{
    partial class frmExcluirAgendamento
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgAgenda = new System.Windows.Forms.DataGridView();
            this.cmdExcluir = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).BeginInit();
            this.gbDados.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(534, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pesquisar por nome do paciente:";
            // 
            // dgAgenda
            // 
            this.dgAgenda.AllowUserToAddRows = false;
            this.dgAgenda.AllowUserToDeleteRows = false;
            this.dgAgenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAgenda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgenda.Location = new System.Drawing.Point(46, 98);
            this.dgAgenda.Margin = new System.Windows.Forms.Padding(5);
            this.dgAgenda.Name = "dgAgenda";
            this.dgAgenda.ReadOnly = true;
            this.dgAgenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgAgenda.RowTemplate.Height = 28;
            this.dgAgenda.Size = new System.Drawing.Size(535, 164);
            this.dgAgenda.TabIndex = 14;
            this.dgAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAgenda_CellContentClick);
            // 
            // cmdExcluir
            // 
            this.cmdExcluir.BackgroundImage = global::ProjetoSISO.Properties.Resources.trash_52px;
            this.cmdExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExcluir.FlatAppearance.BorderSize = 0;
            this.cmdExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcluir.Location = new System.Drawing.Point(296, 498);
            this.cmdExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.cmdExcluir.Name = "cmdExcluir";
            this.cmdExcluir.Size = new System.Drawing.Size(60, 55);
            this.cmdExcluir.TabIndex = 17;
            this.cmdExcluir.UseVisualStyleBackColor = true;
            this.cmdExcluir.Click += new System.EventHandler(this.cmdExcluir_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.BackgroundImage = global::ProjetoSISO.Properties.Resources.close;
            this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.FlatAppearance.BorderSize = 0;
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(1344, 16);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(66, 50);
            this.cmdClose.TabIndex = 18;
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.groupBox4);
            this.gbDados.Controls.Add(this.groupBox3);
            this.gbDados.Controls.Add(this.groupBox2);
            this.gbDados.Controls.Add(this.cmdExcluir);
            this.gbDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDados.Location = new System.Drawing.Point(638, 54);
            this.gbDados.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbDados.Name = "gbDados";
            this.gbDados.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbDados.Size = new System.Drawing.Size(658, 581);
            this.gbDados.TabIndex = 20;
            this.gbDados.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblHora);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbDataAg);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(14, 359);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox4.Size = new System.Drawing.Size(620, 128);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(260, 76);
            this.lblHora.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(100, 25);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "00000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "Horário da Consulta:";
            // 
            // lbDataAg
            // 
            this.lbDataAg.AutoSize = true;
            this.lbDataAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAg.Location = new System.Drawing.Point(260, 34);
            this.lbDataAg.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbDataAg.Name = "lbDataAg";
            this.lbDataAg.Size = new System.Drawing.Size(100, 25);
            this.lbDataAg.TabIndex = 5;
            this.lbDataAg.Text = "00000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
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
            this.groupBox3.Location = new System.Drawing.Point(14, 215);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox3.Size = new System.Drawing.Size(620, 130);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // lbEspDent
            // 
            this.lbEspDent.AutoSize = true;
            this.lbEspDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspDent.Location = new System.Drawing.Point(260, 78);
            this.lbEspDent.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbEspDent.Name = "lbEspDent";
            this.lbEspDent.Size = new System.Drawing.Size(100, 25);
            this.lbEspDent.TabIndex = 5;
            this.lbEspDent.Text = "00000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Especialização:";
            // 
            // lbNomeDent
            // 
            this.lbNomeDent.AutoSize = true;
            this.lbNomeDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeDent.Location = new System.Drawing.Point(260, 34);
            this.lbNomeDent.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbNomeDent.Name = "lbNomeDent";
            this.lbNomeDent.Size = new System.Drawing.Size(100, 25);
            this.lbNomeDent.TabIndex = 4;
            this.lbNomeDent.Text = "00000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 25);
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
            this.groupBox2.Location = new System.Drawing.Point(14, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox2.Size = new System.Drawing.Size(620, 181);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lbNascPac
            // 
            this.lbNascPac.AutoSize = true;
            this.lbNascPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascPac.Location = new System.Drawing.Point(260, 121);
            this.lbNascPac.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbNascPac.Name = "lbNascPac";
            this.lbNascPac.Size = new System.Drawing.Size(100, 25);
            this.lbNascPac.TabIndex = 3;
            this.lbNascPac.Text = "00000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data de Nascimento:";
            // 
            // lbCpfPac
            // 
            this.lbCpfPac.AutoSize = true;
            this.lbCpfPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfPac.Location = new System.Drawing.Point(260, 78);
            this.lbCpfPac.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbCpfPac.Name = "lbCpfPac";
            this.lbCpfPac.Size = new System.Drawing.Size(100, 25);
            this.lbCpfPac.TabIndex = 2;
            this.lbCpfPac.Text = "00000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "CPF:";
            // 
            // lbNomePac
            // 
            this.lbNomePac.AutoSize = true;
            this.lbNomePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePac.Location = new System.Drawing.Point(260, 34);
            this.lbNomePac.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbNomePac.Name = "lbNomePac";
            this.lbNomePac.Size = new System.Drawing.Size(100, 25);
            this.lbNomePac.TabIndex = 1;
            this.lbNomePac.Text = "00000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome do Paciente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(853, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 25);
            this.label13.TabIndex = 19;
            this.label13.Text = "Confirmação de dados";
            // 
            // frmExcluirAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(183)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1530, 723);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExcluirAgendamento";
            this.Text = "frmExcluirAgendamento";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmExcluirAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).EndInit();
            this.gbDados.ResumeLayout(false);
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgAgenda;
        private System.Windows.Forms.Button cmdExcluir;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbDataAg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbEspDent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNomeDent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNascPac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCpfPac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNomePac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
    }
}