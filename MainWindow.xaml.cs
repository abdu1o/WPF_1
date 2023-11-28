using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPF_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley") { UseShellExecute = true });

            if (count == 1) 
            {
                MessageBox.Show("Button pressed: " + count + " time");
            }
            else
            {
                MessageBox.Show("Button pressed: " + count + " times");
            }
        }
    }
}
