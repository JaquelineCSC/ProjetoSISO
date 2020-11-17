namespace ProjetoSISO
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panelMenuEsquerda = new System.Windows.Forms.Panel();
            this.cmdDentista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenuEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(80)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1724, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projeto SISO";
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(80)))), ((int)(((byte)(151)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(193)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::ProjetoSISO.Properties.Resources.close;
            this.button4.Location = new System.Drawing.Point(1647, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 73);
            this.button4.TabIndex = 0;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelMenuEsquerda
            // 
            this.panelMenuEsquerda.AutoSize = true;
            this.panelMenuEsquerda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenuEsquerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.panelMenuEsquerda.Controls.Add(this.cmdDentista);
            this.panelMenuEsquerda.Controls.Add(this.button1);
            this.panelMenuEsquerda.Controls.Add(this.button2);
            this.panelMenuEsquerda.Controls.Add(this.button3);
            this.panelMenuEsquerda.Controls.Add(this.button5);
            this.panelMenuEsquerda.Controls.Add(this.pictureBox1);
            this.panelMenuEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuEsquerda.Location = new System.Drawing.Point(0, 73);
            this.panelMenuEsquerda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuEsquerda.Name = "panelMenuEsquerda";
            this.panelMenuEsquerda.Size = new System.Drawing.Size(325, 715);
            this.panelMenuEsquerda.TabIndex = 1;
            // 
            // cmdDentista
            // 
            this.cmdDentista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.cmdDentista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdDentista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDentista.FlatAppearance.BorderSize = 0;
            this.cmdDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDentista.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDentista.ForeColor = System.Drawing.Color.White;
            this.cmdDentista.Image = global::ProjetoSISO.Properties.Resources.tooth_64px;
            this.cmdDentista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDentista.Location = new System.Drawing.Point(15, 347);
            this.cmdDentista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDentista.Name = "cmdDentista";
            this.cmdDentista.Size = new System.Drawing.Size(305, 86);
            this.cmdDentista.TabIndex = 0;
            this.cmdDentista.Text = "Dentistas";
            this.cmdDentista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdDentista.UseVisualStyleBackColor = false;
            this.cmdDentista.Click += new System.EventHandler(this.cmdDentista_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::ProjetoSISO.Properties.Resources.user_60px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(15, 449);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 86);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pacientes";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::ProjetoSISO.Properties.Resources.calendar_60px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(17, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 86);
            this.button2.TabIndex = 0;
            this.button2.Text = "Agendamentos";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::ProjetoSISO.Properties.Resources.print_60px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(15, 239);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(305, 86);
            this.button3.TabIndex = 0;
            this.button3.Text = "Relatórios";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(74)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::ProjetoSISO.Properties.Resources.cons;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(17, 134);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(305, 86);
            this.button5.TabIndex = 5;
            this.button5.Text = "Consultas";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = global::ProjetoSISO.Properties.Resources.logo2j;
            this.pictureBox1.Location = new System.Drawing.Point(0, 630);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.Transparent;
            this.panelForm.BackgroundImage = global::ProjetoSISO.Properties.Resources.logo;
            this.panelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(325, 73);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1399, 715);
            this.panelForm.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1724, 788);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenuEsquerda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "Projeto SISO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenuEsquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDentista;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelForm;
        public System.Windows.Forms.Panel panelMenuEsquerda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
    }
}

