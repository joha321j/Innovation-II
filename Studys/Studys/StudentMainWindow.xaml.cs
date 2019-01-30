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
using Studys.View.Categories;

namespace Studys.View
{
    /// <summary>
    /// Interaction logic for StudentMainWindow.xaml
    /// </summary>
    public partial class StudentMainWindow : Window
    {
        public StudentMainWindow()
        {
            InitializeComponent();
        }


        // Button Projects - Click
        private void BtnProjects_Click(object sender, RoutedEventArgs e)
        {
            if (CategoriesFrame.Content == string.Empty)
            {
                CategoriesFrame.Content = new CategoriesPage(CategoriesFrame, listBox);
            }
            else
            {
                CategoriesFrame.Content = string.Empty;
            }
        }

        // Button FrontPage - Click
        //--- Show all projects
        private void BtnFrontPage_Click(object sender, RoutedEventArgs e)
        {
            GridMessages.Visibility = Visibility.Hidden;
            listBoxMyProjects.Visibility = Visibility.Hidden;
            GridProjectDescription.Visibility = Visibility.Hidden;

            listBox.Visibility = Visibility.Visible;
        }

        // Button Read more - click
        //--- Add 'tab' button
        private void BtnReadMore_Click(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button.Name = "BtnProjectTab";
            button.Background = null;
            button.Width = 75;
            button.FontFamily = new FontFamily("Rockwell");
            button.Content = "Opslag";
            button.Click += Button_Click;

            //Width="75" FontFamily="Rockwell" Background="White"

            StackTabs.Children.Add(button);
        }

        // 'tab' button click
        //--- Hide all projects, show clicked project description
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Visibility = Visibility.Hidden;
            listBoxMyProjects.Visibility = Visibility.Hidden;
            GridMessages.Visibility = Visibility.Hidden;

            GridProjectDescription.Visibility = Visibility.Visible;
        }



        // BtnMyProjects - Click
        private void BtnMyProjects_Click(object sender, RoutedEventArgs e)
        {
            listBox.Visibility = Visibility.Hidden;
            GridProjectDescription.Visibility = Visibility.Hidden;
            GridMessages.Visibility = Visibility.Hidden;

            listBoxMyProjects.Visibility = Visibility.Visible;
        }

        // BtnMessages - click
        private void BtnMessages_Click(object sender, RoutedEventArgs e)
        {
            listBox.Visibility = Visibility.Hidden;
            GridProjectDescription.Visibility = Visibility.Hidden;
            listBoxMyProjects.Visibility = Visibility.Hidden;

            GridMessages.Visibility = Visibility.Visible;
        }


        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        //--- Drag window
        private void mainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        

    }
}
