namespace FeiraTecnica
{
    partial class TelaRegistroFuncionario
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
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.lbSexo = new System.Windows.Forms.Label();
            this.cbFeminino = new System.Windows.Forms.CheckBox();
            this.cbMasculino = new System.Windows.Forms.CheckBox();
            this.rbEmpresarial = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.lbUF = new System.Windows.Forms.Label();
            this.tbCEP = new System.Windows.Forms.TextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.tbComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lbRua = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.tbCNPJ = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.tbNascimento = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.cmbSetores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSenha
            // 
            this.tbSenha.Location = new System.Drawing.Point(360, 312);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(100, 20);
            this.tbSenha.TabIndex = 69;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(272, 315);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 68;
            this.lbSenha.Text = "Senha:";
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(398, 385);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 67;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(296, 385);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 66;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(395, 73);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(31, 13);
            this.lbSexo.TabIndex = 65;
            this.lbSexo.Text = "Sexo";
            // 
            // cbFeminino
            // 
            this.cbFeminino.AutoSize = true;
            this.cbFeminino.Location = new System.Drawing.Point(436, 104);
            this.cbFeminino.Name = "cbFeminino";
            this.cbFeminino.Size = new System.Drawing.Size(68, 17);
            this.cbFeminino.TabIndex = 64;
            this.cbFeminino.Text = "Feminino";
            this.cbFeminino.UseVisualStyleBackColor = true;
            this.cbFeminino.Click += new System.EventHandler(this.cbFeminino_Click);
            // 
            // cbMasculino
            // 
            this.cbMasculino.AutoSize = true;
            this.cbMasculino.Location = new System.Drawing.Point(323, 104);
            this.cbMasculino.Name = "cbMasculino";
            this.cbMasculino.Size = new System.Drawing.Size(74, 17);
            this.cbMasculino.TabIndex = 63;
            this.cbMasculino.Text = "Masculino";
            this.cbMasculino.UseVisualStyleBackColor = true;
            this.cbMasculino.Click += new System.EventHandler(this.cbMasculino_Click);
            // 
            // rbEmpresarial
            // 
            this.rbEmpresarial.AutoSize = true;
            this.rbEmpresarial.Location = new System.Drawing.Point(417, 138);
            this.rbEmpresarial.Name = "rbEmpresarial";
            this.rbEmpresarial.Size = new System.Drawing.Size(117, 17);
            this.rbEmpresarial.TabIndex = 62;
            this.rbEmpresarial.Text = "Pessoa Empresarial";
            this.rbEmpresarial.UseVisualStyleBackColor = true;
            this.rbEmpresarial.CheckedChanged += new System.EventHandler(this.rbEmpresarial_CheckedChanged);
            this.rbEmpresarial.Click += new System.EventHandler(this.rbEmpresarial_Click);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Checked = true;
            this.rbFisica.Location = new System.Drawing.Point(295, 138);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(92, 17);
            this.rbFisica.TabIndex = 61;
            this.rbFisica.TabStop = true;
            this.rbFisica.Text = "Pessoa Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.Click += new System.EventHandler(this.rbFisica_Click);
            // 
            // tbUF
            // 
            this.tbUF.Location = new System.Drawing.Point(514, 248);
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(100, 20);
            this.tbUF.TabIndex = 60;
            // 
            // lbUF
            // 
            this.lbUF.AutoSize = true;
            this.lbUF.Location = new System.Drawing.Point(480, 251);
            this.lbUF.Name = "lbUF";
            this.lbUF.Size = new System.Drawing.Size(24, 13);
            this.lbUF.TabIndex = 59;
            this.lbUF.Text = "UF:";
            // 
            // tbCEP
            // 
            this.tbCEP.Location = new System.Drawing.Point(360, 245);
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(100, 20);
            this.tbCEP.TabIndex = 58;
            this.tbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCEP_KeyPress);
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(325, 248);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(29, 13);
            this.lbCEP.TabIndex = 57;
            this.lbCEP.Text = "Cep:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(156, 245);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(43, 13);
            this.lbCidade.TabIndex = 56;
            this.lbCidade.Text = "Cidade:";
            // 
            // tbComplemento
            // 
            this.tbComplemento.Location = new System.Drawing.Point(360, 286);
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(100, 20);
            this.tbComplemento.TabIndex = 55;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(272, 289);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(74, 13);
            this.lbComplemento.TabIndex = 54;
            this.lbComplemento.Text = "Complemento:";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(205, 242);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(100, 20);
            this.tbCidade.TabIndex = 53;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(471, 208);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(37, 13);
            this.lbBairro.TabIndex = 52;
            this.lbBairro.Text = "Bairro:";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(514, 205);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(100, 20);
            this.tbBairro.TabIndex = 51;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(305, 208);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(47, 13);
            this.lbNumero.TabIndex = 50;
            this.lbNumero.Text = "Numero:";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(358, 205);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(100, 20);
            this.tbNumero.TabIndex = 49;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(156, 205);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(30, 13);
            this.lbRua.TabIndex = 48;
            this.lbRua.Text = "Rua:";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(198, 202);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(100, 20);
            this.tbRua.TabIndex = 47;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(424, 164);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lbCNPJ.TabIndex = 46;
            this.lbCNPJ.Text = "CNPJ";
            // 
            // tbCNPJ
            // 
            this.tbCNPJ.Enabled = false;
            this.tbCNPJ.Location = new System.Drawing.Point(464, 161);
            this.tbCNPJ.Name = "tbCNPJ";
            this.tbCNPJ.Size = new System.Drawing.Size(100, 20);
            this.tbCNPJ.TabIndex = 45;
            this.tbCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNPJ_KeyPress);
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(268, 164);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(30, 13);
            this.lbCPF.TabIndex = 44;
            this.lbCPF.Text = "CPF:";
            // 
            // tbCPF
            // 
            this.tbCPF.Location = new System.Drawing.Point(304, 161);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(100, 20);
            this.tbCPF.TabIndex = 43;
            this.tbCPF.TextChanged += new System.EventHandler(this.tbCPF_TextChanged);
            this.tbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCPF_KeyPress);
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Location = new System.Drawing.Point(394, 41);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(105, 13);
            this.lbNascimento.TabIndex = 42;
            this.lbNascimento.Text = "Data de nascimento:";
            // 
            // tbNascimento
            // 
            this.tbNascimento.Location = new System.Drawing.Point(533, 38);
            this.tbNascimento.Name = "tbNascimento";
            this.tbNascimento.Size = new System.Drawing.Size(100, 20);
            this.tbNascimento.TabIndex = 41;
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(217, 41);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(42, 13);
            this.lbCelular.TabIndex = 40;
            this.lbCelular.Text = "Celular:";
            // 
            // tbCelular
            // 
            this.tbCelular.Location = new System.Drawing.Point(271, 38);
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(100, 20);
            this.tbCelular.TabIndex = 39;
            this.tbCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCelular_KeyPress);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(394, 15);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 38;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(533, 12);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 37;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(217, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 36;
            this.lbNome.Text = "Nome:";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(271, 12);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 35;
            // 
            // cmbSetores
            // 
            this.cmbSetores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetores.FormattingEnabled = true;
            this.cmbSetores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSetores.Items.AddRange(new object[] {
            "SETOR A",
            "SETOR B",
            "SETOR C",
            "SETOR D"});
            this.cmbSetores.Location = new System.Drawing.Point(360, 338);
            this.cmbSetores.Name = "cmbSetores";
            this.cmbSetores.Size = new System.Drawing.Size(121, 21);
            this.cmbSetores.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Setor";
            // 
            // TelaRegistroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSetores);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.cbFeminino);
            this.Controls.Add(this.cbMasculino);
            this.Controls.Add(this.rbEmpresarial);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.tbUF);
            this.Controls.Add(this.lbUF);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.lbCEP);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.lbCNPJ);
            this.Controls.Add(this.tbCNPJ);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.tbNascimento);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNome);
            this.Name = "TelaRegistroFuncionario";
            this.Text = "Registro - Funcionarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaRegistroFuncionario_FormClosed);
            this.Load += new System.EventHandler(this.TelaRegistroFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.CheckBox cbFeminino;
        private System.Windows.Forms.CheckBox cbMasculino;
        private System.Windows.Forms.RadioButton rbEmpresarial;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox tbUF;
        private System.Windows.Forms.Label lbUF;
        private System.Windows.Forms.TextBox tbCEP;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.TextBox tbComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox tbRua;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.TextBox tbCNPJ;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox tbCPF;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.TextBox tbNascimento;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.TextBox tbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ComboBox cmbSetores;
        private System.Windows.Forms.Label label1;
    }
}