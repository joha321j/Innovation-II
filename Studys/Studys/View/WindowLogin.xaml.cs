using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Studys.View
{
    /// <summary>
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        MainWindow mainWindow;

        public WindowLogin(MainWindow instance)
        {
            InitializeComponent();

            mainWindow = instance;

        }

        

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Is student - true (Disable "Opret Projekt"
            mainWindow.Visibility = Visibility.Visible;
            mainWindow.BtnOpretProjekt.Opacity = 1;
            mainWindow.ImageOpretProjekt.Opacity = 0.25;
            this.Visibility = Visibility.Hidden;

            


        }

        




        //--- Close / Minimize window
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        //--- Get / Lost focus
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

        //--- Drag window
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
