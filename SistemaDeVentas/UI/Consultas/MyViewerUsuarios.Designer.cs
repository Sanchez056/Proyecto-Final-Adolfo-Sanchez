namespace SistemaDeVentas.Consultas
{
    partial class MyViewerUsuarios
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
            this.UsuariosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // UsuariosreportViewer
            // 
            this.UsuariosreportViewer.Location = new System.Drawing.Point(1, 2);
            this.UsuariosreportViewer.Name = "UsuariosreportViewer";
            this.UsuariosreportViewer.Size = new System.Drawing.Size(765, 302);
            this.UsuariosreportViewer.TabIndex = 0;
            // 
            // MyViewerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 303);
            this.Controls.Add(this.UsuariosreportViewer);
            this.Name = "MyViewerUsuarios";
            this.Text = "MyViewerUsuarios";
            this.Load += new System.EventHandler(this.MyViewerUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer UsuariosreportViewer;
    }
}