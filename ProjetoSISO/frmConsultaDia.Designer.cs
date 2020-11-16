namespace ProjetoSISO
{
    partial class frmConsultaDia
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
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.dgAgenda = new System.Windows.Forms.DataGridView();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.cmdConfirmar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProcedimento = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).BeginInit();
            this.gbDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(32, 150);
            this.Calendar.Margin = new System.Windows.Forms.Padding(18, 16, 18, 16);
            this.Calendar.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // dgAgenda
            // 
            this.dgAgenda.AllowUserToAddRows = false;
            this.dgAgenda.AllowUserToDeleteRows = false;
            this.dgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgenda.Location = new System.Drawing.Point(396, 194);
            this.dgAgenda.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgAgenda.Name = "dgAgenda";
            this.dgAgenda.ReadOnly = true;
            this.dgAgenda.RowHeadersWidth = 62;
            this.dgAgenda.RowTemplate.Height = 28;
            this.dgAgenda.Size = new System.Drawing.Size(602, 200);
            this.dgAgenda.TabIndex = 1;
            this.dgAgenda.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAgenda_CellEnter);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.cmdLimpar);
            this.gbDados.Controls.Add(this.groupBox1);
            this.gbDados.Controls.Add(this.groupBox4);
            this.gbDados.Controls.Add(this.groupBox3);
            this.gbDados.Controls.Add(this.groupBox2);
            this.gbDados.Controls.Add(this.cmdConfirmar);
            this.gbDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDados.Location = new System.Drawing.Point(1012, 89);
            this.gbDados.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gbDados.Name = "gbDados";
            this.gbDados.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gbDados.Size = new System.Drawing.Size(740, 846);
            this.gbDados.TabIndex = 8;
            this.gbDados.TabStop = false;
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.BackgroundImage = global::ProjetoSISO.Properties.Resources.erase;
            this.cmdLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdLimpar.FlatAppearance.BorderSize = 0;
            this.cmdLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpar.Location = new System.Drawing.Point(377, 720);
            this.cmdLimpar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(81, 86);
            this.cmdLimpar.TabIndex = 9;
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(16, 610);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Size = new System.Drawing.Size(698, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(292, 38);
            this.lblValor.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(117, 29);
            this.lblValor.TabIndex = 5;
            this.lblValor.Text = "00000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblHora);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbDataAg);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(16, 438);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox4.Size = new System.Drawing.Size(698, 156);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(292, 93);
            this.lblHora.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(117, 29);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "00000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 93);
            this.label12.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 29);
            this.label12.TabIndex = 5;
            this.label12.Text = "Horário da Consulta:";
            // 
            // lbDataAg
            // 
            this.lbDataAg.AutoSize = true;
            this.lbDataAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataAg.Location = new System.Drawing.Point(292, 42);
            this.lbDataAg.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbDataAg.Name = "lbDataAg";
            this.lbDataAg.Size = new System.Drawing.Size(117, 29);
            this.lbDataAg.TabIndex = 5;
            this.lbDataAg.Text = "00000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 42);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
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
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(16, 263);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox3.Size = new System.Drawing.Size(698, 159);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // lbEspDent
            // 
            this.lbEspDent.AutoSize = true;
            this.lbEspDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspDent.Location = new System.Drawing.Point(292, 94);
            this.lbEspDent.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbEspDent.Name = "lbEspDent";
            this.lbEspDent.Size = new System.Drawing.Size(117, 29);
            this.lbEspDent.TabIndex = 5;
            this.lbEspDent.Text = "00000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 94);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Especialização:";
            // 
            // lbNomeDent
            // 
            this.lbNomeDent.AutoSize = true;
            this.lbNomeDent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeDent.Location = new System.Drawing.Point(292, 42);
            this.lbNomeDent.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNomeDent.Name = "lbNomeDent";
            this.lbNomeDent.Size = new System.Drawing.Size(117, 29);
            this.lbNomeDent.TabIndex = 4;
            this.lbNomeDent.Text = "00000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
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
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(16, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox2.Size = new System.Drawing.Size(698, 220);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lbNascPac
            // 
            this.lbNascPac.AutoSize = true;
            this.lbNascPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascPac.Location = new System.Drawing.Point(292, 147);
            this.lbNascPac.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNascPac.Name = "lbNascPac";
            this.lbNascPac.Size = new System.Drawing.Size(117, 29);
            this.lbNascPac.TabIndex = 3;
            this.lbNascPac.Text = "00000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Data de Nascimento:";
            // 
            // lbCpfPac
            // 
            this.lbCpfPac.AutoSize = true;
            this.lbCpfPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpfPac.Location = new System.Drawing.Point(292, 94);
            this.lbCpfPac.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbCpfPac.Name = "lbCpfPac";
            this.lbCpfPac.Size = new System.Drawing.Size(117, 29);
            this.lbCpfPac.TabIndex = 2;
            this.lbCpfPac.Text = "00000000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "CPF:";
            // 
            // lbNomePac
            // 
            this.lbNomePac.AutoSize = true;
            this.lbNomePac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomePac.Location = new System.Drawing.Point(292, 42);
            this.lbNomePac.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbNomePac.Name = "lbNomePac";
            this.lbNomePac.Size = new System.Drawing.Size(117, 29);
            this.lbNomePac.TabIndex = 1;
            this.lbNomePac.Text = "00000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome do Paciente:";
            // 
            // cmdConfirmar
            // 
            this.cmdConfirmar.BackgroundImage = global::ProjetoSISO.Properties.Resources.save;
            this.cmdConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdConfirmar.FlatAppearance.BorderSize = 0;
            this.cmdConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConfirmar.Location = new System.Drawing.Point(246, 720);
            this.cmdConfirmar.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cmdConfirmar.Name = "cmdConfirmar";
            this.cmdConfirmar.Size = new System.Drawing.Size(87, 86);
            this.cmdConfirmar.TabIndex = 0;
            this.cmdConfirmar.UseVisualStyleBackColor = true;
            this.cmdConfirmar.Click += new System.EventHandler(this.cmdConfirmar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1290, 56);
            this.label13.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 29);
            this.label13.TabIndex = 7;
            this.label13.Text = "Confirmação de dados";
            // 
            // txtProcedimento
            // 
            this.txtProcedimento.BackColor = System.Drawing.SystemColors.Window;
            this.txtProcedimento.Location = new System.Drawing.Point(32, 454);
            this.txtProcedimento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProcedimento.Name = "txtProcedimento";
            this.txtProcedimento.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtProcedimento.Size = new System.Drawing.Size(964, 310);
            this.txtProcedimento.TabIndex = 9;
            this.txtProcedimento.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Procedimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(30, 789);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(117, 784);
            this.txtValor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtValor.Mask = "000.00";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 30);
            this.txtValor.TabIndex = 11;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Consultas no dia";
            // 
            // cmdBack
            // 
            this.cmdBack.BackgroundImage = global::ProjetoSISO.Properties.Resources.back;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(34, 18);
            this.cmdBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 66);
            this.cmdBack.TabIndex = 12;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(396, 150);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 30);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(392, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pesquisar por nome";
            // 
            // frmConsultaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1796, 972);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProcedimento);
            this.Controls.Add(this.gbDados);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgAgenda);
            this.Controls.Add(this.Calendar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmConsultaDia";
            this.Text = "frmConsultaDia";
            this.Load += new System.EventHandler(this.frmConsultaDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAgenda)).EndInit();
            this.gbDados.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.DataGridView dgAgenda;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.Button cmdLimpar;
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
        private System.Windows.Forms.Button cmdConfirmar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox txtProcedimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}