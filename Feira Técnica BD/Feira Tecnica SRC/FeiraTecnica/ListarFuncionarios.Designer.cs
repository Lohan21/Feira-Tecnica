namespace FeiraTecnica
{
    partial class ListarFuncionarios
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
            this.dtFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFuncionarios
            // 
            this.dtFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFuncionarios.Location = new System.Drawing.Point(12, 12);
            this.dtFuncionarios.Name = "dtFuncionarios";
            this.dtFuncionarios.Size = new System.Drawing.Size(321, 173);
            this.dtFuncionarios.TabIndex = 0;
            // 
            // ListarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 197);
            this.Controls.Add(this.dtFuncionarios);
            this.Name = "ListarFuncionarios";
            this.Text = "ListarFuncionarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListarFuncionarios_FormClosed);
            this.Load += new System.EventHandler(this.ListarFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtFuncionarios;
    }
}