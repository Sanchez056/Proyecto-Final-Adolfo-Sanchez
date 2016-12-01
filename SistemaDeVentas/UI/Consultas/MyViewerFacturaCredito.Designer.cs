namespace SistemaDeVentas.UI.Consultas
{
    partial class MyViewerFacturaCredito
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
            this.FacturaCreditoreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // FacturaCreditoreportViewer
            // 
            this.FacturaCreditoreportViewer.Location = new System.Drawing.Point(-1, -3);
            this.FacturaCreditoreportViewer.Name = "FacturaCreditoreportViewer";
            this.FacturaCreditoreportViewer.Size = new System.Drawing.Size(716, 367);
            this.FacturaCreditoreportViewer.TabIndex = 0;
            // 
            // MyViewerFacturaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 365);
            this.Controls.Add(this.FacturaCreditoreportViewer);
            this.Name = "MyViewerFacturaCredito";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.MyViewerFacturaCredito_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer FacturaCreditoreportViewer;
    }
}