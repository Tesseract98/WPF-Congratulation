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

        bool IsRight(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if(!(str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'А' && str[i] <= 'Я' || str[i] >= 'а' && str[i] <= 'я' || str[i] == 'ё' || str[i] == 'Ё'))
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
    }
}
