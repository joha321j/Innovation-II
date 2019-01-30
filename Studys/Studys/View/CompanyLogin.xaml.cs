using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Studys.View
{
    /// <summary>
    /// Interaction logic for CompanyLogin.xaml
    /// </summary>
    public partial class CompanyLogin : Page
    {
        private WindowLogin _windowLogin;
        private CompanyMainWindow companyMainWindow; 
        public CompanyLogin(WindowLogin windowLogin)
        {
            InitializeComponent();
            companyMainWindow = new CompanyMainWindow();
            _windowLogin = windowLogin;
        }


        private void BtnLogin_Click(object sender, RoutedEventArgs e) 
        {
            companyMainWindow.Show();
            _windowLogin.Close();
        }


        private void TbEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbEmail.Text == "Email")
            {
                TbEmail.Text = string.Empty;
            }
        }

        private void TbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbEmail.Text == string.Empty)
            {
                TbEmail.Text = "Email";
            }
        }

        private void TbPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TbPassword.Password == "Password")
            {
                TbPassword.Password = string.Empty;
            }
        }

        private void TbPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TbPassword.Password == string.Empty)
            {
                TbPassword.Password = "Password";
            }
        }
    }
}

