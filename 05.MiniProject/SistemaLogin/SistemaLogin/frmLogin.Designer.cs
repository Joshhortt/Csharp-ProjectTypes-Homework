namespace SistemaLogin
{
    partial class frmLogin
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
            this.cmd_entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_utilizador = new System.Windows.Forms.TextBox();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check_visualizar_password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmd_entrar
            // 
            this.cmd_entrar.Location = new System.Drawing.Point(93, 159);
            this.cmd_entrar.Name = "cmd_entrar";
            this.cmd_entrar.Size = new System.Drawing.Size(75, 23);
            this.cmd_entrar.TabIndex = 0;
            this.cmd_entrar.Text = "Entrar";
            this.cmd_entrar.UseVisualStyleBackColor = true;
            this.cmd_entrar.Click += new System.EventHandler(this.cmd_entrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilizador:";
            // 
            // text_utilizador
            // 
            this.text_utilizador.Location = new System.Drawing.Point(12, 42);
            this.text_utilizador.MaxLength = 30;
            this.text_utilizador.Name = "text_utilizador";
            this.text_utilizador.Size = new System.Drawing.Size(156, 20);
            this.text_utilizador.TabIndex = 2;
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.Location = new System.Drawing.Point(12, 159);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(75, 23);
            this.cmd_cancelar.TabIndex = 3;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = true;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            // 
            // text_password
            // 
            this.text_password.Location = new System.Drawing.Point(12, 80);
            this.text_password.MaxLength = 30;
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(136, 20);
            this.text_password.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // check_visualizar_password
            // 
            this.check_visualizar_password.AutoSize = true;
            this.check_visualizar_password.Location = new System.Drawing.Point(154, 83);
            this.check_visualizar_password.Name = "check_visualizar_password";
            this.check_visualizar_password.Size = new System.Drawing.Size(15, 14);
            this.check_visualizar_password.TabIndex = 6;
            this.check_visualizar_password.UseVisualStyleBackColor = true;
            this.check_visualizar_password.CheckedChanged += new System.EventHandler(this.check_visualizar_password_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 194);
            this.Controls.Add(this.check_visualizar_password);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.text_utilizador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_entrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_utilizador;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_visualizar_password;
    }
}