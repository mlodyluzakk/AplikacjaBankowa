// Program.cs
using System;
using System.Windows.Forms;

namespace AplikacjaBankowa
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Mo�esz tu wystartowa� od RegisterForm lub LoginForm
            Application.Run(new RegisterForm());
        }
    }
}
