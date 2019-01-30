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

namespace Studys.View.Categories
{
    /// <summary>
    /// Interaction logic for CategoriesPage.xaml
    /// </summary>
    public partial class CategoriesPage : Page
    {
        private Frame _categoriesFrame;
        private ListBox _listBox;
        public CategoriesPage(Frame categoriesFrame, ListBox listBox)
        {
            InitializeComponent();
            _categoriesFrame = categoriesFrame;
            _listBox = listBox;
        }

        private void BtnDesignCategory_Click(object sender, RoutedEventArgs e)
        {
            _categoriesFrame.Content = new DesignCategory();
            _listBox.Visibility = Visibility.Visible;
        }
    }
}
