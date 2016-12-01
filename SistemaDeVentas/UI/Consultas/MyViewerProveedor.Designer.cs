namespace SistemaDeVentas.Consultas
{
    partial class MyViewerProveedor
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
            this.ProveedorreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ProveedorreportViewer
            // 
            this.ProveedorreportViewer.Location = new System.Drawing.Point(0, -1);
            this.ProveedorreportViewer.Name = "ProveedorreportViewer";
            this.ProveedorreportViewer.Size = new System.Drawing.Size(785, 309);
            this.ProveedorreportViewer.TabIndex = 0;
            // 
            // MyViewerProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 306);
            this.Controls.Add(this.ProveedorreportViewer);
            this.Name = "MyViewerProveedor";
            this.Text = "MyViewerProveedor";
            this.Load += new System.EventHandler(this.MyViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer ProveedorreportViewer;
    }
}