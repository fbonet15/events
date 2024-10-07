using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Boto_2(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has clickat el botó 2!!" + e.OriginalSource.ToString());
            MessageBox.Show("Has clickat el botó 2!!" + e.OriginalSource.ToString());
            e.Handled = true;
        }

        private void PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Has clicat l'Stack");
        }

        private void Panel_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has clicat l'Stack!");
        }

        private void Boto_1(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has apretat el botó 1!!! " + e.OriginalSource.ToString());
            MessageBox.Show("Has clickat el botó 1!!! " + e.OriginalSource.ToString());
            e.Handled = true;
        }

        private void Boto_3(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Has apretat el botó 3!!" + e.OriginalSource.ToString());
            MessageBox.Show("Has apretat el botó 3!!" + e.OriginalSource.ToString());
            e.Handled = true;
        }
    }
}