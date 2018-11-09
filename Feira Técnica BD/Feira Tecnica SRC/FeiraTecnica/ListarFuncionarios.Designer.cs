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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btApagarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFuncionarios
            // 
            this.dtFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFuncionarios.Location = new System.Drawing.Point(12, 72);
            this.dtFuncionarios.Name = "dtFuncionarios";
            this.dtFuncionarios.Size = new System.Drawing.Size(396, 173);
            this.dtFuncionarios.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Funcionários",
            "Clientes",
            "Usuários"});
            this.comboBox1.Location = new System.Drawing.Point(156, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btApagarRegistro
            // 
            this.btApagarRegistro.Location = new System.Drawing.Point(157, 39);
            this.btApagarRegistro.Name = "btApagarRegistro";
            this.btApagarRegistro.Size = new System.Drawing.Size(120, 23);
            this.btApagarRegistro.TabIndex = 2;
            this.btApagarRegistro.Text = "Demitir Funcionario";
            this.btApagarRegistro.UseVisualStyleBackColor = true;
            this.btApagarRegistro.Click += new System.EventHandler(this.btApagarRegistro_Click);
            // 
            // ListarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 257);
            this.Controls.Add(this.btApagarRegistro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListarFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Funcionarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListarFuncionarios_FormClosed);
            this.Load += new System.EventHandler(this.ListarFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtFuncionarios;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btApagarRegistro;
    }
}