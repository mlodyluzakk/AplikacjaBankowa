using System.Windows.Forms;

namespace AplikacjaBankowa
{
    partial class RegisterForm : Form
    {
       
        private System.ComponentModel.IContainer components = new System.ComponentModel.Container();
      

        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(20, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(114, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nazwa użytkownika:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(20, 45);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(200, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(20, 85);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(40, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Hasło:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(20, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(200, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(20, 150);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(33, 15);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "Imię:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new System.Drawing.Point(20, 175);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(200, 23);
            txtFirstName.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(20, 215);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(60, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "Nazwisko:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(20, 240);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(200, 23);
            txtLastName.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(20, 285);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(200, 30);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Zarejestruj";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(250, 340);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(btnRegister);
            Name = "RegisterForm";
            Text = "Rejestracja";
            //
            // Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
