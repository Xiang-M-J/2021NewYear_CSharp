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
using System.Windows.Shapes;
using System.Collections;
using Microsoft.Win32;
using System.IO;

namespace _2021NewYear_CSharp
{
    /// <summary>
    /// WishWall.xaml 的交互逻辑
    /// </summary>
    public partial class WishWall : Window
    {
        public WishWall()
        {
            InitializeComponent();
        }

        private string[] Image = new string[] {
            "pack://application:,,,/resources/WishWall/N1.png",
            "pack://application:,,,/resources/WishWall/N2.png",
            "pack://application:,,,/resources/WishWall/N3.png",
            "pack://application:,,,/resources/WishWall/N4.png",
            "pack://application:,,,/resources/WishWall/RR1.png",
            "pack://application:,,,/resources/WishWall/RR2.png",
            "pack://application:,,,/resources/WishWall/RR3.png",
            "pack://application:,,,/resources/WishWall/RR4.png",
            "pack://application:,,,/resources/WishWall/RRN1.png",
            "pack://application:,,,/resources/WishWall/RRN2.png",
            "pack://application:,,,/resources/WishWall/RRN3.png",
            "pack://application:,,,/resources/WishWall/RRN4.png",
            "pack://application:,,,/resources/WishWall/RRRR1.png",
            "pack://application:,,,/resources/WishWall/RRRR2.png",
            "pack://application:,,,/resources/WishWall/RRRR3.png",
            "pack://application:,,,/resources/WishWall/RRRR4.png"
        };
        private int num = -1;
        private int count = 0;
        ArrayList list = new ArrayList();
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

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (num >= 0 && num <= 15)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Image Files (*.bmp, *.png, *.jpg)|*.bmp;*.png;*.jpg | All Files | *.*";
                sfd.RestoreDirectory = true;//保存对话框是否记忆上次打开的目录
                if (sfd.ShowDialog() == true)
                {
                    var encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create((BitmapSource)this.image2.Source));
                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        encoder.Save(stream);
                }
            }
            else
            {
                MessageBox.Show("You haven't chosen your wish");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            Random r = new Random();
            num = r.Next(0, 16);//生成一个随机数，0-9
            if (count <= 4){
                while (list.Contains(num))//判断集合中有没有生成的随机数，如果有，则重新生成一个随机数，直到生成的随机数list集合中没有才退出循环
                {
                    num = r.Next(0, 16);
                }
                list.Add(num);//将生成的随机数添加到集合对象中
                image2.Source = new BitmapImage(new Uri(Image[num]));
            }
            else
            {
                num = 5;
                image2.Source = new BitmapImage(new Uri("pack://application:,,,/resources/Nomore.png"));
                MessageBox.Show("The opportunity has run out this time");
            }
           

        }
    }
}
