namespace ProjetoSISO {
    partial class frmPacientes {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdLimpar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpSexo = new System.Windows.Forms.GroupBox();
            this.radioButtonMasc = new System.Windows.Forms.RadioButton();
            this.radioButtonFem = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBack = new System.Windows.Forms.Button();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.cmdAdicionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdLimpar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.gpSexo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboEstado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmdSalvar);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEndereco);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 501);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.BackgroundImage = global::ProjetoSISO.Properties.Resources.erase;
            this.cmdLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdLimpar.FlatAppearance.BorderSize = 0;
            this.cmdLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpar.Location = new System.Drawing.Point(206, 422);
            this.cmdLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(72, 73);
            this.cmdLimpar.TabIndex = 37;
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 382);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(201, 376);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(440, 27);
            this.txtTelefone.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(201, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(440, 32);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(201, 20);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(440, 27);
            this.txtNome.TabIndex = 1;
            // 
            // gpSexo
            // 
            this.gpSexo.BackColor = System.Drawing.Color.Transparent;
            this.gpSexo.Controls.Add(this.radioButtonMasc);
            this.gpSexo.Controls.Add(this.radioButtonFem);
            this.gpSexo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSexo.Location = new System.Drawing.Point(201, 46);
            this.gpSexo.Name = "gpSexo";
            this.gpSexo.Size = new System.Drawing.Size(233, 36);
            this.gpSexo.TabIndex = 2;
            this.gpSexo.TabStop = false;
            // 
            // radioButtonMasc
            // 
            this.radioButtonMasc.AutoSize = true;
            this.radioButtonMasc.Location = new System.Drawing.Point(113, 16);
            this.radioButtonMasc.Name = "radioButtonMasc";
            this.radioButtonMasc.Size = new System.Drawing.Size(90, 20);
            this.radioButtonMasc.TabIndex = 1;
            this.radioButtonMasc.TabStop = true;
            this.radioButtonMasc.Text = "Masculino";
            this.radioButtonMasc.UseVisualStyleBackColor = true;
            // 
            // radioButtonFem
            // 
            this.radioButtonFem.AutoSize = true;
            this.radioButtonFem.Location = new System.Drawing.Point(6, 16);
            this.radioButtonFem.Name = "radioButtonFem";
            this.radioButtonFem.Size = new System.Drawing.Size(84, 20);
            this.radioButtonFem.TabIndex = 0;
            this.radioButtonFem.TabStop = true;
            this.radioButtonFem.Text = "Feminino";
            this.radioButtonFem.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sexo:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboEstado.Location = new System.Drawing.Point(201, 291);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(66, 28);
            this.cboEstado.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estado:";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(201, 247);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(440, 27);
            this.txtCep.TabIndex = 7;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(201, 205);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(440, 27);
            this.txtCidade.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cidade:";
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.BackColor = System.Drawing.Color.White;
            this.cmdSalvar.BackgroundImage = global::ProjetoSISO.Properties.Resources.save;
            this.cmdSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSalvar.FlatAppearance.BorderSize = 0;
            this.cmdSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalvar.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalvar.Location = new System.Drawing.Point(564, 422);
            this.cmdSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(77, 72);
            this.cmdSalvar.TabIndex = 12;
            this.cmdSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSalvar.UseVisualStyleBackColor = false;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(21, 27);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(61, 20);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Celular:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(201, 165);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(440, 27);
            this.txtEndereco.TabIndex = 5;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(201, 334);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(440, 27);
            this.txtCelular.TabIndex = 9;
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(201, 127);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(440, 27);
            this.txtCPF.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço:";
            // 
            // cmdBack
            // 
            this.cmdBack.BackgroundImage = global::ProjetoSISO.Properties.Resources.back;
            this.cmdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdBack.FlatAppearance.BorderSize = 0;
            this.cmdBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBack.Location = new System.Drawing.Point(39, 25);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(50, 44);
            this.cmdBack.TabIndex = 10;
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.BackColor = System.Drawing.Color.White;
            this.cmdPesquisar.BackgroundImage = global::ProjetoSISO.Properties.Resources.search;
            this.cmdPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPesquisar.FlatAppearance.BorderSize = 0;
            this.cmdPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPesquisar.Location = new System.Drawing.Point(548, 13);
            this.cmdPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(78, 74);
            this.cmdPesquisar.TabIndex = 7;
            this.cmdPesquisar.UseVisualStyleBackColor = false;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // cmdAdicionar
            // 
            this.cmdAdicionar.BackColor = System.Drawing.Color.White;
            this.cmdAdicionar.BackgroundImage = global::ProjetoSISO.Properties.Resources._new;
            this.cmdAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAdicionar.FlatAppearance.BorderSize = 0;
            this.cmdAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAdicionar.Location = new System.Drawing.Point(634, 13);
            this.cmdAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdAdicionar.Name = "cmdAdicionar";
            this.cmdAdicionar.Size = new System.Drawing.Size(80, 74);
            this.cmdAdicionar.TabIndex = 6;
            this.cmdAdicionar.UseVisualStyleBackColor = false;
            this.cmdAdicionar.Click += new System.EventHandler(this.cmdAdicionar_Click);
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 624);
            this.Controls.Add(this.cmdBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.cmdAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPacientes";
            this.Text = "frmPacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpSexo.ResumeLayout(false);
            this.gpSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.Button cmdAdicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gpSexo;
        private System.Windows.Forms.RadioButton radioButtonMasc;
        private System.Windows.Forms.RadioButton radioButtonFem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button cmdLimpar;
    }
}