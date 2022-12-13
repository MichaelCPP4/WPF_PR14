using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void SaveSettings_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int rowCount = Int32.Parse(textBoxrowCount.Text);
                int columnCount = Int32.Parse(textBoxColumnCount.Text);
                int minValue = Int32.Parse(diapozonMin.Text);
                int maxValue = Int32.Parse(diapozon.Text);

                StreamWriter streamWriter = new StreamWriter("config.ini");
                using (streamWriter)
                {
                    streamWriter.WriteLine(rowCount);
                    streamWriter.WriteLine(columnCount);
                    streamWriter.WriteLine(minValue);
                    streamWriter.WriteLine(maxValue);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите значения", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
