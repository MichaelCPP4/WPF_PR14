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

namespace WPF_PR13
{
    /// <summary>
    /// Логика взаимодействия для WindowPassword.xaml
    /// </summary>
    public partial class WindowPassword : Window
    {
        public WindowPassword()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            password.Focus();
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (password.Password == "123") Close();
            else
            {
                MessageBox.Show("Пароль не подходит","Защита");
                password.Focus();
            }
        }

        private void Escape_Click(object sender, RoutedEventArgs e)
        {
            Owner.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (password.Password != "123") e.Cancel = true;
        }
    }
}
