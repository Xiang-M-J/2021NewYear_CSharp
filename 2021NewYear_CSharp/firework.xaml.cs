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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace _2021NewYear_CSharp
{
    /// <summary>
    /// firework.xaml 的交互逻辑
    /// </summary>
    public partial class firework: Window
    {

        
        public firework()
        {
            InitializeComponent();

        }

        
        
        public void timerEvent(object sender, EventArgs e)
        {
            // MediaElement需要先停止播放才能再开始播放，
            // 否则会停在最后一帧不动
            mediaElement.Stop();
            mediaElement.Play();
        }
        private void PlayerPause()
        {
            
            if (playBtn.Content.ToString() == "Play")
            {
                mediaElement.Play();
                playBtn.Content = "Pause";
                

            }
            else
            {
               
                mediaElement.Pause();
                playBtn.Content = "Play";
                
            }
        }
        
        private void PlayBtn_Click(object sender, RoutedEventArgs e)
        {
           
            PlayerPause();
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
            mediaElement.Stop();
            this.Close();
        }

        private void StopBtn_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void ResumeBtn_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            
            mediaElement.Play();
            
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement.Volume = slider.Value;
            
        }

        private void CheckBox1_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                mediaElement.Volume = 0;
            }
            else
            {
                mediaElement.Volume = 50;
            }
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (checkBox1_Copy.IsChecked==true)
            {
                mediaElement.Stop();
                mediaElement.Play();
            }
            else
            {
                mediaElement.Stop();
            }
        }
    }
}
