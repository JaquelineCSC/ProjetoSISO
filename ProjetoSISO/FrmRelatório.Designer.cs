namespace ProjetoSISO
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
            this.cmdAgenda = new System.Windows.Forms.Button();
            this.cmdPacientes = new System.Windows.Forms.Button();
            this.cmdDentista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdAgenda
            // 
            this.cmdAgenda.Location = new System.Drawing.Point(305, 133);
            this.cmdAgenda.Name = "cmdAgenda";
            this.cmdAgenda.Size = new System.Drawing.Size(185, 65);
            this.cmdAgenda.TabIndex = 1;
            this.cmdAgenda.Text = "&Agendamentos";
            this.cmdAgenda.UseVisualStyleBackColor = true;
            // 
            // cmdPacientes
            // 
            this.cmdPacientes.Location = new System.Drawing.Point(305, 216);
            this.cmdPacientes.Name = "cmdPacientes";
            this.cmdPacientes.Size = new System.Drawing.Size(185, 56);
            this.cmdPacientes.TabIndex = 3;
            this.cmdPacientes.Text = "&Pacientes";
            this.cmdPacientes.Click += new System.EventHandler(this.cmdPacientes_Click);
            // 
            // cmdDentista
            // 
            this.cmdDentista.Location = new System.Drawing.Point(305, 290);
            this.cmdDentista.Name = "cmdDentista";
            this.cmdDentista.Size = new System.Drawing.Size(185, 64);
            this.cmdDentista.TabIndex = 5;
            this.cmdDentista.Text = "&Dentistas";
            this.cmdDentista.UseVisualStyleBackColor = true;
            this.cmdDentista.Click += new System.EventHandler(this.cmdDentista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Relatórios";
            // 
            // FrmRelatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdDentista);
            this.Controls.Add(this.cmdPacientes);
            this.Controls.Add(this.cmdAgenda);
            this.Name = "FrmRelatório";
            this.Text = "FrmRelatório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdAgenda;
        private System.Windows.Forms.Button cmdPacientes;
        private System.Windows.Forms.Button cmdDentista;
        private System.Windows.Forms.Label label1;
    }
}