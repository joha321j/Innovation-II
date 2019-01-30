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
        private StudentMainWindow studentMainWindow;
        public StudentLoginPage()
        {
            InitializeComponent();
            studentMainWindow = new StudentMainWindow();
        }


        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Is student - true (Disable "Opret Projekt"
            studentMainWindow.Visibility = Visibility.Visible;
            studentMainWindow.BtnOpretProjekt.Opacity = 1;
            studentMainWindow.ImageOpretProjekt.Opacity = 0.25;
            this.Visibility = Visibility.Hidden;
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
