namespace ProjetoSISO
{
    partial class FrmRelatorioPaciente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjetoSISO2DataSet = new ProjetoSISO.ProjetoSISO2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PacientesTableAdapter = new ProjetoSISO.ProjetoSISO2DataSetTableAdapters.PacientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISO2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // PacientesBindingSource
            // 
            this.PacientesBindingSource.DataMember = "Pacientes";
            this.PacientesBindingSource.DataSource = this.ProjetoSISO2DataSet;
            // 
            // ProjetoSISO2DataSet
            // 
            this.ProjetoSISO2DataSet.DataSetName = "ProjetoSISO2DataSet";
            this.ProjetoSISO2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Pacientes";
            reportDataSource1.Value = this.PacientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSISO.Pacientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1082, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // PacientesTableAdapter
            // 
            this.PacientesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioPaciente";
            this.Text = "FrmRelatorioPaciente";
            this.Load += new System.EventHandler(this.FrmRelatorioPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISO2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjetoSISO2DataSet ProjetoSISO2DataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PacientesBindingSource;
        private ProjetoSISO2DataSetTableAdapters.PacientesTableAdapter PacientesTableAdapter;
    }
}