using System.Media;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Поздравление
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SoundPlayer player;
        public MainWindow(string str)
        {
            InitializeComponent();
            player = new SoundPlayer(Properties.Resources.Toto___Africa);
            player.Load();
            LbName.Content = str;
            LbCongr.FontSize = 30;
            LbName.FontSize = 30;
            player.PlayLooping();
        }

        private long counter = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
            {
                player.Stop();
                PLayBtn.Content = "Воспроизвести";
                PLayBtn.ToolTip = "Воспроизвести музыку";
            }
            else
            {
                player.PlayLooping();
                PLayBtn.Content = "Остановить";
                PLayBtn.ToolTip = "Остановить музыку";
            }
            counter++;
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
                LbCongr.HorizontalContentAlignment = HorizontalAlignment.Left;
                LbCongr.FontSize = 20;
                LbName.FontSize = 21;
                // LbCongr.Padding = new Thickness(0, 0, 0, 0);
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                LbCongr.HorizontalContentAlignment = HorizontalAlignment.Center;
                LbCongr.FontSize = 30;
                LbName.FontSize = 30;
                //LbCongr.Padding = new Thickness(0, 0, LbCongr.Width/2, 0);
            }
        }

        private void Image_PreviewMouseUp_1(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            PLayBtn.Background = Brushes.BlanchedAlmond;
            PLayBtn.Foreground = Brushes.BlueViolet;
            PLayBtn.BorderBrush = Brushes.Aqua;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            PLayBtn.Background = Brushes.SeaShell;
            PLayBtn.Foreground = Brushes.Blue;
            PLayBtn.BorderBrush = Brushes.RoyalBlue;
        }
    }
}
