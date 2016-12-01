namespace SistemaDeVentas.UI.Consultas
{
    partial class MyViewerReciboContado
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
            this.ReciboContadoreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReciboContadoreportViewer
            // 
            this.ReciboContadoreportViewer.Location = new System.Drawing.Point(4, 2);
            this.ReciboContadoreportViewer.Name = "ReciboContadoreportViewer";
            this.ReciboContadoreportViewer.Size = new System.Drawing.Size(714, 313);
            this.ReciboContadoreportViewer.TabIndex = 0;
            // 
            // MyViewerReciboContado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 314);
            this.Controls.Add(this.ReciboContadoreportViewer);
            this.Name = "MyViewerReciboContado";
            this.Text = "MyViewerReciboContado";
            this.Load += new System.EventHandler(this.MyViewerReciboContado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer ReciboContadoreportViewer;
    }
}