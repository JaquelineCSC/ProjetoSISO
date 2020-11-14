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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProjetoSISODataSet = new ProjetoSISO.ProjetoSISODataSet();
            this.cmdAgenda = new System.Windows.Forms.Button();
            this.cmdPacientes = new System.Windows.Forms.Button();
            this.PacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacientesTableAdapter = new ProjetoSISO.ProjetoSISODataSetTableAdapters.PacientesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjetoSISODataSet
            // 
            this.ProjetoSISODataSet.DataSetName = "ProjetoSISODataSet";
            this.ProjetoSISODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmdAgenda
            // 
            this.cmdAgenda.Location = new System.Drawing.Point(700, 370);
            this.cmdAgenda.Name = "cmdAgenda";
            this.cmdAgenda.Size = new System.Drawing.Size(88, 28);
            this.cmdAgenda.TabIndex = 1;
            this.cmdAgenda.Text = "&Agendamentos";
            this.cmdAgenda.UseVisualStyleBackColor = true;
            // 
            // cmdPacientes
            // 
            this.cmdPacientes.Location = new System.Drawing.Point(594, 370);
            this.cmdPacientes.Name = "cmdPacientes";
            this.cmdPacientes.Size = new System.Drawing.Size(88, 28);
            this.cmdPacientes.TabIndex = 3;
            this.cmdPacientes.Text = "&Pacientes";
            this.cmdPacientes.UseVisualStyleBackColor = true;
            this.cmdPacientes.Click += new System.EventHandler(this.cmdPacientes_Click);
            // 
            // PacientesBindingSource
            // 
            this.PacientesBindingSource.DataMember = "Pacientes";
            this.PacientesBindingSource.DataSource = this.ProjetoSISODataSet;
            // 
            // PacientesTableAdapter
            // 
            this.PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Pacientes";
            reportDataSource2.Value = this.PacientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSISO.Pacientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 246);
            this.reportViewer1.TabIndex = 4;
            // 
            // FrmRelatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmdPacientes);
            this.Controls.Add(this.cmdAgenda);
            this.Name = "FrmRelatório";
            this.Text = "FrmRelatório";
            this.Load += new System.EventHandler(this.FrmRelatório_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdAgenda;
        private ProjetoSISODataSet ProjetoSISODataSet;
        private System.Windows.Forms.Button cmdPacientes;
        private System.Windows.Forms.BindingSource PacientesBindingSource;
        private ProjetoSISODataSetTableAdapters.PacientesTableAdapter PacientesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}