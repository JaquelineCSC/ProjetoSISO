﻿namespace ProjetoSISO
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjetoSISODataSet = new ProjetoSISO.ProjetoSISODataSet();
            this.PacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PacientesTableAdapter = new ProjetoSISO.ProjetoSISODataSetTableAdapters.PacientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ProjetoSISODataSet
            // 
            this.ProjetoSISODataSet.DataSetName = "ProjetoSISODataSet";
            this.ProjetoSISODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // FrmRelatorioPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioPaciente";
            this.Text = "FrmRelatorioPaciente";
            this.Load += new System.EventHandler(this.FrmRelatorioPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PacientesBindingSource;
        private ProjetoSISODataSet ProjetoSISODataSet;
        private ProjetoSISODataSetTableAdapters.PacientesTableAdapter PacientesTableAdapter;
    }
}