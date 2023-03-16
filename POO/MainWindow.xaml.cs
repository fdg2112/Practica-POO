using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace POO
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<PublicTransport> Transportes { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Transportes = new ObservableCollection<PublicTransport>();
            this.DataContext = this;
        }

        private void Button_BusMenu(object sender, RoutedEventArgs e)
        {
            BusesWindow busesWindow = new BusesWindow();
            busesWindow.ShowDialog();

        }

        private void Button_TaxiMenu(object sender, RoutedEventArgs e)
        {
            TaxisWindow taxisWindow = new TaxisWindow();
            taxisWindow.ShowDialog();
        }
    }
}
