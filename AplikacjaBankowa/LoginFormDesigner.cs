using System.Windows.Forms;

namespace AplikacjaBankowa
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components;
        private Label lblUser;
        private TextBox txtUsername;
        private Label lblPass;
        private TextBox txtPassword;
        private Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUser = new Label();
            this.txtUsername = new TextBox();
            this.lblPass = new Label();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(30, 30);
            this.lblUser.Text = "Nazwa użytkownika:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(30, 55);
            this.txtUsername.Size = new System.Drawing.Size(200, 23);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(30, 95);
            this.lblPass.Text = "Hasło:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(30, 120);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(30, 165);
            this.btnLogin.Size = new System.Drawing.Size(200, 30);
            this.btnLogin.Text = "Zaloguj";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 230);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginForm";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
