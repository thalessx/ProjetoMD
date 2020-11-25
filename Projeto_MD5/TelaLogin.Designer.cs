namespace Projeto_MD5
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAcessar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mostrarsenhaCB = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(24, 157);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(263, 23);
            this.txtSenha.TabIndex = 0;
            this.txtSenha.UseSystemPasswordChar = false;

            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(24, 103);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(263, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.UseSystemPasswordChar = false;
            
            // 
            // btnAcessar
            // 
            this.btnAcessar.Depth = 0;
            this.btnAcessar.Location = new System.Drawing.Point(203, 235);
            this.btnAcessar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Primary = true;
            this.btnAcessar.Size = new System.Drawing.Size(89, 23);
            this.btnAcessar.TabIndex = 2;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.Location = new System.Drawing.Point(105, 235);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Primary = true;
            this.btnRegistrar.Size = new System.Drawing.Size(92, 23);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(20, 81);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Login";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(20, 135);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Senha";
            // 
            // mostrarsenhaCB
            // 
            this.mostrarsenhaCB.AutoSize = true;
            this.mostrarsenhaCB.Depth = 0;
            this.mostrarsenhaCB.Font = new System.Drawing.Font("Roboto", 10F);
            this.mostrarsenhaCB.Location = new System.Drawing.Point(24, 187);
            this.mostrarsenhaCB.Margin = new System.Windows.Forms.Padding(0);
            this.mostrarsenhaCB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mostrarsenhaCB.MouseState = MaterialSkin.MouseState.HOVER;
            this.mostrarsenhaCB.Name = "mostrarsenhaCB";
            this.mostrarsenhaCB.Ripple = true;
            this.mostrarsenhaCB.Size = new System.Drawing.Size(119, 30);
            this.mostrarsenhaCB.TabIndex = 6;
            this.mostrarsenhaCB.Text = "Mostrar senha";
            this.mostrarsenhaCB.UseVisualStyleBackColor = true;
            this.mostrarsenhaCB.CheckedChanged += new System.EventHandler(this.mostrarsenhaCB_CheckedChanged);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 280);
            this.Controls.Add(this.mostrarsenhaCB);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Name = "TelaLogin";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnAcessar;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox mostrarsenhaCB;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
    }
}

