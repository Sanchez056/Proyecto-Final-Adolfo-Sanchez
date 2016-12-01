namespace SistemaDeVentas.Consultas
{
    partial class MyViewerClientes
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
            this.ClientesreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ClientesreportViewer
            // 
            this.ClientesreportViewer.Location = new System.Drawing.Point(1, -1);
            this.ClientesreportViewer.Name = "ClientesreportViewer";
            this.ClientesreportViewer.Size = new System.Drawing.Size(691, 298);
            this.ClientesreportViewer.TabIndex = 0;
            this.ClientesreportViewer.Load += new System.EventHandler(this.ClientesreportViewer_Load);
            // 
            // MyViewerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 292);
            this.Controls.Add(this.ClientesreportViewer);
            this.Name = "MyViewerClientes";
            this.Text = "MyViewerClientes";
            this.Load += new System.EventHandler(this.MyViewerClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer ClientesreportViewer;
    }
}