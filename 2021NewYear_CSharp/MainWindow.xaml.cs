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


namespace _2021NewYear_CSharp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void Image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            firework window = new firework
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.Show();
        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            clock window = new clock
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.Show();
        }

        private void Button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Event window = new Event
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.Show();
       
        }

        private void Button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            WishWall window = new WishWall
            {
                WindowStartupLocation=WindowStartupLocation.CenterScreen
            };
            window.Show();
        }

        

        private void Image8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            About window = new About
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            window.Show();
        }
    }
}
