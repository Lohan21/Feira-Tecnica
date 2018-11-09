namespace FeiraTecnica
{
    partial class MudarSenha
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
            this.lbNewSenha = new System.Windows.Forms.Label();
            this.tbNewSenha = new System.Windows.Forms.TextBox();
            this.tbNewSenha2 = new System.Windows.Forms.TextBox();
            this.lbNewSenha2 = new System.Windows.Forms.Label();
            this.btChangeSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNewSenha
            // 
            this.lbNewSenha.AutoSize = true;
            this.lbNewSenha.Location = new System.Drawing.Point(29, 29);
            this.lbNewSenha.Name = "lbNewSenha";
            this.lbNewSenha.Size = new System.Drawing.Size(65, 13);
            this.lbNewSenha.TabIndex = 0;
            this.lbNewSenha.Text = "Nova senha";
            // 
            // tbNewSenha
            // 
            this.tbNewSenha.Location = new System.Drawing.Point(116, 26);
            this.tbNewSenha.Name = "tbNewSenha";
            this.tbNewSenha.Size = new System.Drawing.Size(100, 20);
            this.tbNewSenha.TabIndex = 1;
            // 
            // tbNewSenha2
            // 
            this.tbNewSenha2.Location = new System.Drawing.Point(116, 52);
            this.tbNewSenha2.Name = "tbNewSenha2";
            this.tbNewSenha2.Size = new System.Drawing.Size(100, 20);
            this.tbNewSenha2.TabIndex = 3;
            // 
            // lbNewSenha2
            // 
            this.lbNewSenha2.AutoSize = true;
            this.lbNewSenha2.Location = new System.Drawing.Point(9, 55);
            this.lbNewSenha2.Name = "lbNewSenha2";
            this.lbNewSenha2.Size = new System.Drawing.Size(85, 13);
            this.lbNewSenha2.TabIndex = 2;
            this.lbNewSenha2.Text = "Confirmar Senha";
            // 
            // btChangeSenha
            // 
            this.btChangeSenha.Location = new System.Drawing.Point(81, 103);
            this.btChangeSenha.Name = "btChangeSenha";
            this.btChangeSenha.Size = new System.Drawing.Size(87, 23);
            this.btChangeSenha.TabIndex = 4;
            this.btChangeSenha.Text = "Mudar Senha";
            this.btChangeSenha.UseVisualStyleBackColor = true;
            this.btChangeSenha.Click += new System.EventHandler(this.btChangeSenha_Click);
            // 
            // MudarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 154);
            this.Controls.Add(this.btChangeSenha);
            this.Controls.Add(this.tbNewSenha2);
            this.Controls.Add(this.lbNewSenha2);
            this.Controls.Add(this.tbNewSenha);
            this.Controls.Add(this.lbNewSenha);
            this.Name = "MudarSenha";
            this.Text = "MudarSenha";
            this.Load += new System.EventHandler(this.MudarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNewSenha;
        private System.Windows.Forms.TextBox tbNewSenha;
        private System.Windows.Forms.TextBox tbNewSenha2;
        private System.Windows.Forms.Label lbNewSenha2;
        private System.Windows.Forms.Button btChangeSenha;
    }
}