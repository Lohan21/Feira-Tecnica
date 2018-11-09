namespace FeiraTecnica
{
    partial class MudarSenhas
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
            this.MudarSenha = new System.Windows.Forms.Button();
            this.lbNewSenha1 = new System.Windows.Forms.Label();
            this.lbNewSenha2 = new System.Windows.Forms.Label();
            this.tbNewSenha1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbNewSenha2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // MudarSenha
            // 
            this.MudarSenha.Location = new System.Drawing.Point(89, 137);
            this.MudarSenha.Name = "MudarSenha";
            this.MudarSenha.Size = new System.Drawing.Size(83, 22);
            this.MudarSenha.TabIndex = 0;
            this.MudarSenha.Text = "Mudar Senha";
            this.MudarSenha.UseVisualStyleBackColor = true;
            this.MudarSenha.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbNewSenha1
            // 
            this.lbNewSenha1.AutoSize = true;
            this.lbNewSenha1.Location = new System.Drawing.Point(27, 56);
            this.lbNewSenha1.Name = "lbNewSenha1";
            this.lbNewSenha1.Size = new System.Drawing.Size(70, 13);
            this.lbNewSenha1.TabIndex = 1;
            this.lbNewSenha1.Text = "Nova Senha:";
            // 
            // lbNewSenha2
            // 
            this.lbNewSenha2.AutoSize = true;
            this.lbNewSenha2.Location = new System.Drawing.Point(9, 86);
            this.lbNewSenha2.Name = "lbNewSenha2";
            this.lbNewSenha2.Size = new System.Drawing.Size(88, 13);
            this.lbNewSenha2.TabIndex = 3;
            this.lbNewSenha2.Text = "Confirmar Senha:";
            // 
            // tbNewSenha1
            // 
            this.tbNewSenha1.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbNewSenha1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewSenha1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbNewSenha1.BorderThickness = 3;
            this.tbNewSenha1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNewSenha1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewSenha1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNewSenha1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewSenha1.isPassword = false;
            this.tbNewSenha1.Location = new System.Drawing.Point(108, 51);
            this.tbNewSenha1.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewSenha1.MaxLength = 32767;
            this.tbNewSenha1.Name = "tbNewSenha1";
            this.tbNewSenha1.Size = new System.Drawing.Size(142, 25);
            this.tbNewSenha1.TabIndex = 13;
            this.tbNewSenha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbNewSenha2
            // 
            this.tbNewSenha2.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbNewSenha2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewSenha2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbNewSenha2.BorderThickness = 3;
            this.tbNewSenha2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNewSenha2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewSenha2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNewSenha2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNewSenha2.isPassword = false;
            this.tbNewSenha2.Location = new System.Drawing.Point(108, 79);
            this.tbNewSenha2.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewSenha2.MaxLength = 32767;
            this.tbNewSenha2.Name = "tbNewSenha2";
            this.tbNewSenha2.Size = new System.Drawing.Size(142, 25);
            this.tbNewSenha2.TabIndex = 14;
            this.tbNewSenha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MudarSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 194);
            this.Controls.Add(this.tbNewSenha2);
            this.Controls.Add(this.tbNewSenha1);
            this.Controls.Add(this.lbNewSenha2);
            this.Controls.Add(this.lbNewSenha1);
            this.Controls.Add(this.MudarSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MudarSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mudar Senha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MudarSenhas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MudarSenha;
        private System.Windows.Forms.Label lbNewSenha1;
        private System.Windows.Forms.Label lbNewSenha2;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbNewSenha1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbNewSenha2;
    }
}