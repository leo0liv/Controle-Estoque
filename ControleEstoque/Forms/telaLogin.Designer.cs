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
            this.lbControleEstoque = new System.Windows.Forms.Label();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbControleEstoque
            // 
            this.lbControleEstoque.AutoSize = true;
            this.lbControleEstoque.Font = new System.Drawing.Font("Noto Sans", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbControleEstoque.Location = new System.Drawing.Point(141, 28);
            this.lbControleEstoque.Name = "lbControleEstoque";
            this.lbControleEstoque.Size = new System.Drawing.Size(510, 65);
            this.lbControleEstoque.TabIndex = 0;
            this.lbControleEstoque.Text = "Controle de Estoque";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Location = new System.Drawing.Point(231, 137);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(288, 20);
            this.txtBoxLogin.TabIndex = 1;
            this.txtBoxLogin.TextChanged += new System.EventHandler(this.txtBoxLogin_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(231, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(288, 20);
            this.textBox2.TabIndex = 2;
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBoxLogin);
            this.Controls.Add(this.lbControleEstoque);
            this.Name = "telaLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.telaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbControleEstoque;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.TextBox textBox2;
    }
}