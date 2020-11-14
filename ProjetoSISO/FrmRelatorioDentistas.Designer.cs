namespace ProjetoSISO
{
    partial class FrmRelatorioDentistas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjetoSISODataSet = new ProjetoSISO.ProjetoSISODataSet();
            this.DentistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DentistasTableAdapter = new ProjetoSISO.ProjetoSISODataSetTableAdapters.DentistasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DentistasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Dentistas";
            reportDataSource1.Value = this.DentistasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSISO.Dentistas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProjetoSISODataSet
            // 
            this.ProjetoSISODataSet.DataSetName = "ProjetoSISODataSet";
            this.ProjetoSISODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DentistasBindingSource
            // 
            this.DentistasBindingSource.DataMember = "Dentistas";
            this.DentistasBindingSource.DataSource = this.ProjetoSISODataSet;
            // 
            // DentistasTableAdapter
            // 
            this.DentistasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioDentistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioDentistas";
            this.Text = "Relatório Dentistas";
            this.Load += new System.EventHandler(this.FrmRelatorioDentistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DentistasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DentistasBindingSource;
        private ProjetoSISODataSet ProjetoSISODataSet;
        private ProjetoSISODataSetTableAdapters.DentistasTableAdapter DentistasTableAdapter;
    }
}