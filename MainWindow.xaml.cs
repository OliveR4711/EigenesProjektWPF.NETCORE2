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

namespace EigenesProjektWPF.NETCORE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //lblUserFolder.Content = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
        private void btnPageMain_Click(object sender, RoutedEventArgs e)
        { frmContent.NavigationService.Navigate(new PageMain()); }
        private void btnMain_Click(object sender, RoutedEventArgs e)
        {
            MainlblBegruessung.Content = "Netzwerk einrichten!";
        }

        private void AlblBegruessung_MouseEnter(object sender, MouseEventArgs e)

        {
            MainlblBegruessung.Foreground = Brushes.Magenta;
            MainlblBegruessung.Background = Brushes.Azure;
        }

        private void AlblBegruessung_MouseLeave(object sender, MouseEventArgs e)
        {
            MainlblBegruessung.Foreground = Brushes.Black;
            MainlblBegruessung.Background = Brushes.LightGray;
        }

        private void btnPageHelp_Click(object sender, RoutedEventArgs e)
        { frmContent.NavigationService.Navigate(new PageHelp()); }
        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            BlblBegruessung.Content = "Hilfe holen!";
        }

        private void BlblBegruessung_MouseEnter(object sender, MouseEventArgs e)

        {
            BlblBegruessung.Foreground = Brushes.Magenta;
            BlblBegruessung.Background = Brushes.Azure;
        }

        private void BlblBegruessung_MouseLeave(object sender, MouseEventArgs e)
        {
            BlblBegruessung.Foreground = Brushes.Black;
            BlblBegruessung.Background = Brushes.LightGray;
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void ClblBegruessung_MouseEnter(object sender, MouseEventArgs e)

        {
            BlblBegruessung.Foreground = Brushes.Magenta;
            BlblBegruessung.Background = Brushes.Azure;
        }

        private void ClblBegruessung_MouseLeave(object sender, MouseEventArgs e)
        {
            BlblBegruessung.Foreground = Brushes.Black;
            BlblBegruessung.Background = Brushes.LightGray;
        }
    }
}