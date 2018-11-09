namespace FeiraTecnica
{
    partial class TelaLogin
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.lbEsqueceu = new System.Windows.Forms.Label();
            this.tbUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbSenha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(22, 38);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(22, 77);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(38, 13);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(59, 130);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(102, 23);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(193, 130);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(102, 23);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(138, 159);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 7;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // lbEsqueceu
            // 
            this.lbEsqueceu.AutoSize = true;
            this.lbEsqueceu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEsqueceu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbEsqueceu.Location = new System.Drawing.Point(150, 102);
            this.lbEsqueceu.Name = "lbEsqueceu";
            this.lbEsqueceu.Size = new System.Drawing.Size(102, 13);
            this.lbEsqueceu.TabIndex = 8;
            this.lbEsqueceu.Text = "Esqueceu a senha?";
            this.lbEsqueceu.Click += new System.EventHandler(this.lbEsqueceu_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbUsuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.tbUsuario.HintText = "";
            this.tbUsuario.isPassword = false;
            this.tbUsuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbUsuario.LineIdleColor = System.Drawing.Color.Gray;
            this.tbUsuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbUsuario.LineThickness = 3;
            this.tbUsuario.Location = new System.Drawing.Point(82, 30);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.MaxLength = 32767;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(244, 33);
            this.tbUsuario.TabIndex = 9;
            this.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsuario_KeyDown);
            // 
            // tbSenha
            // 
            this.tbSenha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSenha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSenha.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSenha.HintForeColor = System.Drawing.Color.Empty;
            this.tbSenha.HintText = "";
            this.tbSenha.isPassword = true;
            this.tbSenha.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbSenha.LineIdleColor = System.Drawing.Color.Gray;
            this.tbSenha.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbSenha.LineThickness = 3;
            this.tbSenha.Location = new System.Drawing.Point(83, 68);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4);
            this.tbSenha.MaxLength = 32767;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(244, 33);
            this.tbSenha.TabIndex = 10;
            this.tbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSenha_KeyDown);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 188);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lbEsqueceu);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label lbEsqueceu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbSenha;
    }
}