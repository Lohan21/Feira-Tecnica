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
            this.btVoltar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.cmbSetores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSenha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbComplemento = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbNumero = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbCEP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbCNPJ = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbCPF = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbNome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbCelular = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbNascimento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFeminino = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMasculino = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.rbEmpresarial = new System.Windows.Forms.RadioButton();
            this.rbFisica = new System.Windows.Forms.RadioButton();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.lbUF = new System.Windows.Forms.Label();
            this.lbCEP = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(320, 391);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(75, 23);
            this.btVoltar.TabIndex = 67;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(171, 391);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btRegistrar.TabIndex = 66;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // cmbSetores
            // 
            this.cmbSetores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSetores.FormattingEnabled = true;
            this.cmbSetores.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSetores.Items.AddRange(new object[] {
            "HTML",
            "Banco de Dados",
            "C#"});
            this.cmbSetores.Location = new System.Drawing.Point(435, 322);
            this.cmbSetores.Name = "cmbSetores";
            this.cmbSetores.Size = new System.Drawing.Size(121, 21);
            this.cmbSetores.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Setor";
            // 
            // tbSenha
            // 
            this.tbSenha.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbSenha.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSenha.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbSenha.BorderThickness = 3;
            this.tbSenha.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbSenha.isPassword = false;
            this.tbSenha.Location = new System.Drawing.Point(432, 280);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(2);
            this.tbSenha.MaxLength = 32767;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(97, 25);
            this.tbSenha.TabIndex = 109;
            this.tbSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbUsuario
            // 
            this.tbUsuario.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbUsuario.BorderThickness = 3;
            this.tbUsuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUsuario.isPassword = false;
            this.tbUsuario.Location = new System.Drawing.Point(432, 220);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsuario.MaxLength = 7;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(97, 25);
            this.tbUsuario.TabIndex = 108;
            this.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbComplemento
            // 
            this.tbComplemento.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbComplemento.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbComplemento.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbComplemento.BorderThickness = 3;
            this.tbComplemento.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbComplemento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbComplemento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbComplemento.isPassword = false;
            this.tbComplemento.Location = new System.Drawing.Point(141, 232);
            this.tbComplemento.Margin = new System.Windows.Forms.Padding(2);
            this.tbComplemento.MaxLength = 32767;
            this.tbComplemento.Name = "tbComplemento";
            this.tbComplemento.Size = new System.Drawing.Size(97, 25);
            this.tbComplemento.TabIndex = 107;
            this.tbComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbNumero
            // 
            this.tbNumero.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbNumero.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNumero.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbNumero.BorderThickness = 3;
            this.tbNumero.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNumero.isPassword = false;
            this.tbNumero.Location = new System.Drawing.Point(141, 203);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(2);
            this.tbNumero.MaxLength = 32767;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(97, 25);
            this.tbNumero.TabIndex = 106;
            this.tbNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // tbCEP
            // 
            this.tbCEP.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbCEP.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCEP.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbCEP.BorderThickness = 3;
            this.tbCEP.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCEP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCEP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCEP.isPassword = false;
            this.tbCEP.Location = new System.Drawing.Point(141, 173);
            this.tbCEP.Margin = new System.Windows.Forms.Padding(2);
            this.tbCEP.MaxLength = 32767;
            this.tbCEP.Name = "tbCEP";
            this.tbCEP.Size = new System.Drawing.Size(97, 25);
            this.tbCEP.TabIndex = 105;
            this.tbCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCEP_KeyPress);
            this.tbCEP.Leave += new System.EventHandler(this.tbCEP_Leave);
            // 
            // tbCNPJ
            // 
            this.tbCNPJ.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbCNPJ.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCNPJ.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbCNPJ.BorderThickness = 3;
            this.tbCNPJ.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCNPJ.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCNPJ.isPassword = false;
            this.tbCNPJ.Location = new System.Drawing.Point(239, 128);
            this.tbCNPJ.Margin = new System.Windows.Forms.Padding(2);
            this.tbCNPJ.MaxLength = 32767;
            this.tbCNPJ.Name = "tbCNPJ";
            this.tbCNPJ.Size = new System.Drawing.Size(97, 25);
            this.tbCNPJ.TabIndex = 104;
            this.tbCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCNPJ_KeyPress);
            // 
            // tbCPF
            // 
            this.tbCPF.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbCPF.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCPF.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbCPF.BorderThickness = 3;
            this.tbCPF.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCPF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCPF.isPassword = false;
            this.tbCPF.Location = new System.Drawing.Point(72, 127);
            this.tbCPF.Margin = new System.Windows.Forms.Padding(2);
            this.tbCPF.MaxLength = 32767;
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(97, 25);
            this.tbCPF.TabIndex = 103;
            this.tbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCPF_KeyPress);
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
            this.tbEmail.Location = new System.Drawing.Point(88, 57);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(132, 25);
            this.tbEmail.TabIndex = 102;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbNome
            // 
            this.tbNome.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbNome.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNome.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbNome.BorderThickness = 3;
            this.tbNome.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNome.isPassword = false;
            this.tbNome.Location = new System.Drawing.Point(88, 19);
            this.tbNome.Margin = new System.Windows.Forms.Padding(2);
            this.tbNome.MaxLength = 32767;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(132, 25);
            this.tbNome.TabIndex = 101;
            this.tbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbCelular
            // 
            this.tbCelular.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbCelular.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCelular.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbCelular.BorderThickness = 3;
            this.tbCelular.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbCelular.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbCelular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbCelular.isPassword = false;
            this.tbCelular.Location = new System.Drawing.Point(399, 56);
            this.tbCelular.Margin = new System.Windows.Forms.Padding(2);
            this.tbCelular.MaxLength = 32767;
            this.tbCelular.Name = "tbCelular";
            this.tbCelular.Size = new System.Drawing.Size(132, 25);
            this.tbCelular.TabIndex = 100;
            this.tbCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCelular_KeyPress);
            // 
            // tbNascimento
            // 
            this.tbNascimento.BackColor = System.Drawing.Color.SteelBlue;
            this.tbNascimento.BorderRadius = 0;
            this.tbNascimento.ForeColor = System.Drawing.Color.White;
            this.tbNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.tbNascimento.FormatCustom = null;
            this.tbNascimento.Location = new System.Drawing.Point(368, 15);
            this.tbNascimento.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbNascimento.Name = "tbNascimento";
            this.tbNascimento.Size = new System.Drawing.Size(189, 30);
            this.tbNascimento.TabIndex = 99;
            this.tbNascimento.Value = new System.DateTime(2018, 10, 27, 2, 13, 42, 435);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Feminino";
            // 
            // cbFeminino
            // 
            this.cbFeminino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbFeminino.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbFeminino.Checked = false;
            this.cbFeminino.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbFeminino.ForeColor = System.Drawing.Color.White;
            this.cbFeminino.Location = new System.Drawing.Point(481, 136);
            this.cbFeminino.Margin = new System.Windows.Forms.Padding(5);
            this.cbFeminino.Name = "cbFeminino";
            this.cbFeminino.Size = new System.Drawing.Size(20, 20);
            this.cbFeminino.TabIndex = 97;
            this.cbFeminino.Click += new System.EventHandler(this.cbFeminino_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 96;
            this.label3.Text = "Masculino";
            // 
            // cbMasculino
            // 
            this.cbMasculino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbMasculino.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbMasculino.Checked = false;
            this.cbMasculino.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbMasculino.ForeColor = System.Drawing.Color.White;
            this.cbMasculino.Location = new System.Drawing.Point(399, 136);
            this.cbMasculino.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbMasculino.Name = "cbMasculino";
            this.cbMasculino.Size = new System.Drawing.Size(20, 20);
            this.cbMasculino.TabIndex = 95;
            this.cbMasculino.Click += new System.EventHandler(this.cbMasculino_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "*no máximo 7 caracteres*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Usuário:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(387, 287);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 91;
            this.lbSenha.Text = "Senha:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(458, 112);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(31, 13);
            this.lbSexo.TabIndex = 90;
            this.lbSexo.Text = "Sexo";
            // 
            // rbEmpresarial
            // 
            this.rbEmpresarial.AutoSize = true;
            this.rbEmpresarial.Location = new System.Drawing.Point(193, 108);
            this.rbEmpresarial.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbEmpresarial.Name = "rbEmpresarial";
            this.rbEmpresarial.Size = new System.Drawing.Size(117, 17);
            this.rbEmpresarial.TabIndex = 89;
            this.rbEmpresarial.TabStop = true;
            this.rbEmpresarial.Text = "Pessoa Empresarial";
            this.rbEmpresarial.UseVisualStyleBackColor = true;
            this.rbEmpresarial.Click += new System.EventHandler(this.rbEmpresarial_Click);
            // 
            // rbFisica
            // 
            this.rbFisica.AutoSize = true;
            this.rbFisica.Location = new System.Drawing.Point(70, 108);
            this.rbFisica.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.rbFisica.Name = "rbFisica";
            this.rbFisica.Size = new System.Drawing.Size(92, 17);
            this.rbFisica.TabIndex = 88;
            this.rbFisica.Text = "Pessoa Física";
            this.rbFisica.UseVisualStyleBackColor = true;
            this.rbFisica.Click += new System.EventHandler(this.rbFisica_Click);
            // 
            // tbUF
            // 
            this.tbUF.Location = new System.Drawing.Point(141, 351);
            this.tbUF.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbUF.Name = "tbUF";
            this.tbUF.ReadOnly = true;
            this.tbUF.Size = new System.Drawing.Size(39, 20);
            this.tbUF.TabIndex = 87;
            // 
            // lbUF
            // 
            this.lbUF.AutoSize = true;
            this.lbUF.Location = new System.Drawing.Point(102, 355);
            this.lbUF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUF.Name = "lbUF";
            this.lbUF.Size = new System.Drawing.Size(24, 13);
            this.lbUF.TabIndex = 86;
            this.lbUF.Text = "UF:";
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(97, 178);
            this.lbCEP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(29, 13);
            this.lbCEP.TabIndex = 85;
            this.lbCEP.Text = "Cep:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(80, 326);
            this.lbCidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(43, 13);
            this.lbCidade.TabIndex = 84;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(46, 235);
            this.lbComplemento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(74, 13);
            this.lbComplemento.TabIndex = 83;
            this.lbComplemento.Text = "Complemento:";
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(141, 321);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.ReadOnly = true;
            this.tbCidade.Size = new System.Drawing.Size(100, 20);
            this.tbCidade.TabIndex = 82;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(81, 296);
            this.lbBairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(37, 13);
            this.lbBairro.TabIndex = 81;
            this.lbBairro.Text = "Bairro:";
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(141, 292);
            this.tbBairro.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.ReadOnly = true;
            this.tbBairro.Size = new System.Drawing.Size(100, 20);
            this.tbBairro.TabIndex = 80;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(75, 207);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(47, 13);
            this.lbNumero.TabIndex = 79;
            this.lbNumero.Text = "Numero:";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(68, 267);
            this.lbRua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(56, 13);
            this.lbRua.TabIndex = 78;
            this.lbRua.Text = "Endereço:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(141, 263);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.ReadOnly = true;
            this.tbEndereco.Size = new System.Drawing.Size(144, 20);
            this.tbEndereco.TabIndex = 94;
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(200, 134);
            this.lbCNPJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lbCNPJ.TabIndex = 77;
            this.lbCNPJ.Text = "CNPJ";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(43, 134);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(30, 13);
            this.lbCPF.TabIndex = 76;
            this.lbCPF.Text = "CPF:";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Location = new System.Drawing.Point(259, 23);
            this.lbNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(105, 13);
            this.lbNascimento.TabIndex = 75;
            this.lbNascimento.Text = "Data de nascimento:";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Location = new System.Drawing.Point(322, 61);
            this.lbCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(42, 13);
            this.lbCelular.TabIndex = 74;
            this.lbCelular.Text = "Celular:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(34, 61);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 73;
            this.lbEmail.Text = "Email:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(34, 22);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 72;
            this.lbNome.Text = "Nome:";
            // 
            // TelaRegistroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 422);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.tbComplemento);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbCEP);
            this.Controls.Add(this.tbCNPJ);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCelular);
            this.Controls.Add(this.tbNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFeminino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMasculino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.rbEmpresarial);
            this.Controls.Add(this.rbFisica);
            this.Controls.Add(this.tbUF);
            this.Controls.Add(this.lbUF);
            this.Controls.Add(this.lbCEP);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lbCNPJ);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSetores);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TelaRegistroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Funcionarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaRegistroFuncionario_FormClosed);
            this.Load += new System.EventHandler(this.TelaRegistroFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.ComboBox cmbSetores;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbSenha;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbUsuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbComplemento;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbNumero;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbCEP;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbCNPJ;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbCPF;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbEmail;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbNome;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbCelular;
        private Bunifu.Framework.UI.BunifuDatepicker tbNascimento;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox cbFeminino;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox cbMasculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.RadioButton rbEmpresarial;
        private System.Windows.Forms.RadioButton rbFisica;
        private System.Windows.Forms.TextBox tbUF;
        private System.Windows.Forms.Label lbUF;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNome;
    }
}