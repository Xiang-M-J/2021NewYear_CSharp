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
using System.Threading;
using System.Windows.Threading;

namespace _2021NewYear_CSharp
{
    /// <summary>
    /// clock.xaml 的交互逻辑
    /// </summary>
    public partial class clock : Window
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        public clock()
        {
            InitializeComponent();
            SEC.Angle = DateTime.Now.Second * 6 - 90;
            MIN.Angle = DateTime.Now.Minute * 6 - 90;
            HOU.Angle = DateTime.Now.Hour * 30 + DateTime.Now.Minute * 0.5 - 90;
            textBox.Text = DateTime.Now.ToString("HH:mm:ss");
            mediaElement.Play();
            if (DateTime.Now.Year >= 2022 || DateTime.Now.Month >= 3 || DateTime.Now.Day >= 12)
            {
                textBox2.Text = "新年快乐";
            }
            else
            {
                DateTime startTime = DateTime.Now;
                DateTime endTime = DateTime.Parse("2021-2-12 00:00:00");
                System.TimeSpan ts = endTime - startTime;

                string text = ts.Days + " 天 " + ts.Hours + " 时 " + ts.Minutes + " 分 " + ts.Seconds + " 秒";
                textBox2.Text = text;
                
            }
            if (DateTime.Now.Hour < 12)
            {
                Color backgroundColor = (Color)ColorConverter.ConvertFromString("PeachPuff");
                Border1.Background = new SolidColorBrush(backgroundColor);
            }
            else
            {
                Color backgroundColor = (Color)ColorConverter.ConvertFromString("Orchid");
                Border2.Background = new SolidColorBrush(backgroundColor);
            }
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
        }


        private void player_MediaEnded(object sender, RoutedEventArgs e)
        {
            //设置一下视频进度，确保从头开始播放
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //UI异步更新
            this.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)(() =>
            {
                //秒针转动,秒针绕一圈360度，共60秒，所以1秒转动6度
                SEC.Angle = DateTime.Now.Second * 6-90;
                //分针转动,分针绕一圈360度，共60分，所以1分转动6度
                MIN.Angle = DateTime.Now.Minute * 6-90;
                //时针转动,时针绕一圈360度，共12时，所以1时转动30度。
                //另外同一个小时内，随着分钟数的变化(绕一圈60分钟），时针也在缓慢变化（转动30度，30/60=0.5)
                HOU.Angle = (DateTime.Now.Hour * 30) + (DateTime.Now.Minute * 0.5)-90;
                //更新时间值
                //this.labTime.Content = DateTime.Now.ToString("HH:mm:ss");
                textBox.Text = DateTime.Now.ToString("HH:mm:ss");
                if (DateTime.Now.Year >= 2022 || DateTime.Now.Month >= 3 || DateTime.Now.Day >= 12)
                {
                    textBox2.Text = "新年快乐";
                }
                else
                {
                    DateTime startTime = DateTime.Now;
                    DateTime endTime = DateTime.Parse("2021-2-12 00:00:00");
                    System.TimeSpan ts = endTime - startTime;

                    string text = ts.Days + " 天 " + ts.Hours + " 时 " + ts.Minutes + " 分 " + ts.Seconds + " 秒";
                    textBox2.Text = text;

                }
            }));
        }
        private void Image1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mediaElement.Stop();
            this.Close();
        }
    }
}
