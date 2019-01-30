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
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        private WindowLogin _windowLogin;
        public StartPage(WindowLogin windowLogin)
        {
            InitializeComponent();
            _windowLogin = windowLogin;
        }


        private void StudButton_OnClick(object sender, RoutedEventArgs e)
        {
            _windowLogin.LoginFrame.Content = new StudentLoginPage();
        }

        private void CompButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
