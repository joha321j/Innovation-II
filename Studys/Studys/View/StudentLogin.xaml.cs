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
    /// Interaction logic for StudentLoginPage.xaml
    /// </summary>
    public partial class StudentLoginPage : Page
    {
        private WindowLogin _windowLogin;
        private StudentMainWindow studentMainWindow;
        public StudentLoginPage(WindowLogin windowLogin)
        {
            InitializeComponent();
            studentMainWindow = new StudentMainWindow();
            _windowLogin = windowLogin;
        }


        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Is student - true (Disable "Opret Projekt"
            studentMainWindow.Show();
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
