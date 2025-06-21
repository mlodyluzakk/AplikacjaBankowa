using System;
using System.Windows.Forms;

namespace AplikacjaBankowa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Twoja logika logowania, np. UserService.Login(...)
            MessageBox.Show("Tu powinna być logika logowania", "Logowanie");
        }
    }
}
