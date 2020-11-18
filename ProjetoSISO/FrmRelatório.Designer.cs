﻿namespace ProjetoSISO
{
    partial class FrmRelatório
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmdDentista = new System.Windows.Forms.Button();
            this.cmdPacientes = new System.Windows.Forms.Button();
            this.cmdAgenda = new System.Windows.Forms.Button();
            this.cmdConsulta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProjetoSISO.Properties.Resources.back;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(22, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 41);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdDentista
            // 
            this.cmdDentista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDentista.FlatAppearance.BorderSize = 0;
            this.cmdDentista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDentista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDentista.Image = global::ProjetoSISO.Properties.Resources.dentist;
            this.cmdDentista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDentista.Location = new System.Drawing.Point(525, 388);
            this.cmdDentista.Name = "cmdDentista";
            this.cmdDentista.Size = new System.Drawing.Size(281, 86);
            this.cmdDentista.TabIndex = 5;
            this.cmdDentista.Text = "&Dentistas";
            this.cmdDentista.UseVisualStyleBackColor = true;
            this.cmdDentista.Click += new System.EventHandler(this.cmdDentista_Click);
            // 
            // cmdPacientes
            // 
            this.cmdPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPacientes.FlatAppearance.BorderSize = 0;
            this.cmdPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPacientes.Image = global::ProjetoSISO.Properties.Resources.paciente;
            this.cmdPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPacientes.Location = new System.Drawing.Point(529, 494);
            this.cmdPacientes.Name = "cmdPacientes";
            this.cmdPacientes.Size = new System.Drawing.Size(278, 93);
            this.cmdPacientes.TabIndex = 3;
            this.cmdPacientes.Text = "&Pacientes";
            this.cmdPacientes.Click += new System.EventHandler(this.cmdPacientes_Click);
            // 
            // cmdAgenda
            // 
            this.cmdAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAgenda.FlatAppearance.BorderSize = 0;
            this.cmdAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgenda.Image = global::ProjetoSISO.Properties.Resources.dentist_appointment;
            this.cmdAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAgenda.Location = new System.Drawing.Point(525, 172);
            this.cmdAgenda.Name = "cmdAgenda";
            this.cmdAgenda.Size = new System.Drawing.Size(281, 80);
            this.cmdAgenda.TabIndex = 1;
            this.cmdAgenda.Text = "&Agendamentos";
            this.cmdAgenda.UseVisualStyleBackColor = true;
            this.cmdAgenda.Click += new System.EventHandler(this.cmdAgenda_Click);
            // 
            // cmdConsulta
            // 
            this.cmdConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdConsulta.FlatAppearance.BorderSize = 0;
            this.cmdConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsulta.Image = global::ProjetoSISO.Properties.Resources.toothache_64px;
            this.cmdConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdConsulta.Location = new System.Drawing.Point(525, 278);
            this.cmdConsulta.Name = "cmdConsulta";
            this.cmdConsulta.Size = new System.Drawing.Size(281, 80);
            this.cmdConsulta.TabIndex = 10;
            this.cmdConsulta.Text = "&Consultas";
            this.cmdConsulta.UseVisualStyleBackColor = true;
            this.cmdConsulta.Click += new System.EventHandler(this.cmdConsulta_Click);
            // 
            // FrmRelatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.cmdConsulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdDentista);
            this.Controls.Add(this.cmdPacientes);
            this.Controls.Add(this.cmdAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatório";
            this.Text = "FrmRelatório";
            this.Load += new System.EventHandler(this.FrmRelatório_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdAgenda;
        private System.Windows.Forms.Button cmdPacientes;
        private System.Windows.Forms.Button cmdDentista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdConsulta;
    }
}