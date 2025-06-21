using System;
using System.Windows.Forms;

namespace AplikacjaBankowa
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string error;
            bool success = UserService.RegisterUser(
                txtUsername.Text.Trim(),
                txtPassword.Text,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                out error
            );

            if (success)
            {
                MessageBox.Show("Rejestracja powiodła się", "Sukces",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                using (var login = new LoginForm())
                    login.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    string.IsNullOrEmpty(error)
                        ? "Rejestracja nie powiodła się"
                        : "Błąd rejestracji: " + error,
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
