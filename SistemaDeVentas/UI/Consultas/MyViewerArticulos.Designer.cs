namespace SistemaDeVentas.Consultas
{
    partial class MyViewerArticulos
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
            this.ArticulosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ArticulosreportViewer
            // 
            this.ArticulosreportViewer.Location = new System.Drawing.Point(2, 2);
            this.ArticulosreportViewer.Name = "ArticulosreportViewer";
            this.ArticulosreportViewer.Size = new System.Drawing.Size(671, 315);
            this.ArticulosreportViewer.TabIndex = 0;
            this.ArticulosreportViewer.Load += new System.EventHandler(this.ArticulosreportViewer_Load);
            // 
            // MyViewerArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 309);
            this.Controls.Add(this.ArticulosreportViewer);
            this.Name = "MyViewerArticulos";
            this.Text = "MyViewerArticulos";
            this.Load += new System.EventHandler(this.MyViewerArticulos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer ArticulosreportViewer;
    }
}