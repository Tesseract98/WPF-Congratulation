using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Поздравление
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        bool IsEnglishLetter(char symb)
        {
            return symb >= 'A' && symb <= 'Z' || symb >= 'a' && symb <= 'z';
        }

        bool IsRussianLetter(char symb)
        {
            return symb >= 'А' && symb <= 'Я' || symb >= 'а' && symb <= 'я' || symb == 'ё' || symb == 'Ё';
        }

        bool IsRight(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!(IsEnglishLetter(str[i]) || IsRussianLetter(str[i])))
                {
                    return false;
                }
            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = TxtBx.Text;
            if (IsRight(str) && str.Length > 2)
            {
                string NewStr = str.ToUpper();
                MainWindow mw = new MainWindow(NewStr);
                mw.Show();
                this.Close();
            }
            else
            {
                ErrorLbl.Content = "Вы ввели неправильное имя";
            }
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var str = TxtBx.Text;
                if (IsRight(str) && str.Length >= 2)
                {
                    var NewStr = str.ToUpper();
                    var mw = new MainWindow(NewStr);
                    mw.Show();
                    this.Close();
                }
                else
                {
                    ErrorLbl.Content = "Вы ввели неправильное имя";
                }
            }
        }
    }
}
