namespace ControleEstoque
{
    partial class telaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.pbLogoStockControl = new System.Windows.Forms.PictureBox();
            this.linklbEsqueciSenha = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoStockControl)).BeginInit();
            this.SuspendLayout();
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(478, 144);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.Size = new System.Drawing.Size(209, 20);
            this.inputLogin.TabIndex = 1;
            this.inputLogin.TextChanged += new System.EventHandler(this.txtBoxLogin_TextChanged);
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(478, 185);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.PasswordChar = '*';
            this.inputSenha.Size = new System.Drawing.Size(209, 20);
            this.inputSenha.TabIndex = 2;
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Location = new System.Drawing.Point(585, 240);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(102, 35);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(436, 147);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(36, 13);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Login:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(436, 188);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 5;
            this.lbSenha.Text = "Senha:";
            this.lbSenha.Click += new System.EventHandler(this.lbSenha_Click);
            // 
            // pbLogoStockControl
            // 
            this.pbLogoStockControl.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoStockControl.Image")));
            this.pbLogoStockControl.Location = new System.Drawing.Point(37, 12);
            this.pbLogoStockControl.Name = "pbLogoStockControl";
            this.pbLogoStockControl.Size = new System.Drawing.Size(393, 393);
            this.pbLogoStockControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoStockControl.TabIndex = 6;
            this.pbLogoStockControl.TabStop = false;
            // 
            // linklbEsqueciSenha
            // 
            this.linklbEsqueciSenha.AutoSize = true;
            this.linklbEsqueciSenha.Location = new System.Drawing.Point(601, 208);
            this.linklbEsqueciSenha.Name = "linklbEsqueciSenha";
            this.linklbEsqueciSenha.Size = new System.Drawing.Size(86, 13);
            this.linklbEsqueciSenha.TabIndex = 7;
            this.linklbEsqueciSenha.TabStop = true;
            this.linklbEsqueciSenha.Text = "Esqueci a senha";
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linklbEsqueciSenha);
            this.Controls.Add(this.pbLogoStockControl);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.inputLogin);
            this.Name = "telaLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.telaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoStockControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.TextBox inputSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.PictureBox pbLogoStockControl;
        private System.Windows.Forms.LinkLabel linklbEsqueciSenha;
    }
}