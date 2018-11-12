namespace FeiraTecnica
{
    partial class MudarSenhaE
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
            this.lbNewSenha2 = new System.Windows.Forms.Label();
            this.lbNewSenha1 = new System.Windows.Forms.Label();
            this.MudarSenha = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbNewSenha1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbNewSenha2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // lbNewSenha2
            // 
            this.lbNewSenha2.AutoSize = true;
            this.lbNewSenha2.Location = new System.Drawing.Point(14, 72);
            this.lbNewSenha2.Name = "lbNewSenha2";
            this.lbNewSenha2.Size = new System.Drawing.Size(88, 13);
            this.lbNewSenha2.TabIndex = 8;
            this.lbNewSenha2.Text = "Confirmar Senha:";
            // 
            // lbNewSenha1
            // 
            this.lbNewSenha1.AutoSize = true;
            this.lbNewSenha1.Location = new System.Drawing.Point(32, 49);
            this.lbNewSenha1.Name = "lbNewSenha1";
            this.lbNewSenha1.Size = new System.Drawing.Size(70, 13);
            this.lbNewSenha1.TabIndex = 6;
            this.lbNewSenha1.Text = "Nova Senha:";
            // 
            // MudarSenha
            // 
            this.MudarSenha.Location = new System.Drawing.Point(93, 124);
            this.MudarSenha.Name = "MudarSenha";
            this.MudarSenha.Size = new System.Drawing.Size(83, 22);
            this.MudarSenha.TabIndex = 5;
            this.MudarSenha.Text = "Mudar Senha";
            this.MudarSenha.UseVisualStyleBackColor = true;
            this.MudarSenha.Click += new System.EventHandler(this.MudarSenha_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(67, 23);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbEmail.BorderThickness = 3;
            this.tbEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbEmail.isPassword = false;
            this.tbEmail.Location = new System.Drawing.Point(123, 16);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(142, 25);
            this.tbEmail.TabIndex = 12;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.tbNewSenha1.isPassword = true;
            this.tbNewSenha1.Location = new System.Drawing.Point(123, 43);
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
            this.tbNewSenha2.isPassword = true;
            this.tbNewSenha2.Location = new System.Drawing.Point(123, 70);
            this.tbNewSenha2.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewSenha2.MaxLength = 32767;
            this.tbNewSenha2.Name = "tbNewSenha2";
            this.tbNewSenha2.Size = new System.Drawing.Size(142, 25);
            this.tbNewSenha2.TabIndex = 14;
            this.tbNewSenha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNewSenha2.OnValueChanged += new System.EventHandler(this.tbNewSenha2_OnValueChanged);
            this.tbNewSenha2.Enter += new System.EventHandler(this.tbNewSenha2_Enter);
            this.tbNewSenha2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNewSenha2_KeyDown);
            // 
            // MudarSenhaE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 173);
            this.Controls.Add(this.tbNewSenha2);
            this.Controls.Add(this.tbNewSenha1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNewSenha2);
            this.Controls.Add(this.lbNewSenha1);
            this.Controls.Add(this.MudarSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MudarSenhaE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esqueci minha senha";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MudarSenhaE_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNewSenha2;
        private System.Windows.Forms.Label lbNewSenha1;
        private System.Windows.Forms.Button MudarSenha;
        private System.Windows.Forms.Label lbEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbNewSenha1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbNewSenha2;
    }
}