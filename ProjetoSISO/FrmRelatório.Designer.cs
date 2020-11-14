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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cmdGerarRelatorio = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProjetoSISODataSet = new ProjetoSISO.ProjetoSISODataSet();
            this.AgendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AgendamentoTableAdapter = new ProjetoSISO.ProjetoSISODataSetTableAdapters.AgendamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdGerarRelatorio
            // 
            this.cmdGerarRelatorio.Location = new System.Drawing.Point(700, 370);
            this.cmdGerarRelatorio.Name = "cmdGerarRelatorio";
            this.cmdGerarRelatorio.Size = new System.Drawing.Size(78, 28);
            this.cmdGerarRelatorio.TabIndex = 1;
            this.cmdGerarRelatorio.Text = "&Gerar";
            this.cmdGerarRelatorio.UseVisualStyleBackColor = true;
            this.cmdGerarRelatorio.Click += new System.EventHandler(this.cmdGerarRelatorio_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Agendamentos";
            reportDataSource1.Value = this.AgendamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoSISO.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(763, 246);
            this.reportViewer1.TabIndex = 2;
            // 
            // ProjetoSISODataSet
            // 
            this.ProjetoSISODataSet.DataSetName = "ProjetoSISODataSet";
            this.ProjetoSISODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AgendamentoBindingSource
            // 
            this.AgendamentoBindingSource.DataMember = "Agendamento";
            this.AgendamentoBindingSource.DataSource = this.ProjetoSISODataSet;
            // 
            // AgendamentoTableAdapter
            // 
            this.AgendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmdGerarRelatorio);
            this.Name = "FrmRelatório";
            this.Text = "FrmRelatório";
            this.Load += new System.EventHandler(this.FrmRelatório_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoSISODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgendamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdGerarRelatorio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AgendamentoBindingSource;
        private ProjetoSISODataSet ProjetoSISODataSet;
        private ProjetoSISODataSetTableAdapters.AgendamentoTableAdapter AgendamentoTableAdapter;
    }
}