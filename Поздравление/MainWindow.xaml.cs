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

namespace Поздравление
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Media.SoundPlayer player;
        public MainWindow()
        {
            InitializeComponent();
            LbCongr.FontSize = 25;
            LbName.FontSize = 25;
            player = new System.Media.SoundPlayer(Properties.Resources.Toto___Africa);
            player.PlayLooping();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                LbCongr.FontSize = 20;
                LbName.FontSize = 20;
               // LbCongr.Padding = new Thickness(0, 0, 0, 0);
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                LbCongr.FontSize = 25;
                LbName.FontSize = 25;
                //LbCongr.Padding = new Thickness(0, 0, LbCongr.Width/2, 0);
            }
        }

        private void Image_PreviewMouseUp_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
