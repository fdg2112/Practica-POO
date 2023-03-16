using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace POO
{
    /// <summary>
    /// Lógica de interacción para BusesWindow.xaml
    /// </summary>
    public partial class BusesWindow : Window
    {
        public ObservableCollection<Bus> Buses { get; set; }
        public int PassengersNumberTextBox { get; set; }
        public BusesWindow()
        {
            InitializeComponent();
            Buses = new ObservableCollection<Bus>();
            BusesList.ItemsSource = Buses;
            this.DataContext = this;
            BusNumber.Text = "Colectivo N° 1";
        }

        private void ValidateText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(PassengersNumber.Text) >= 0 && Convert.ToInt32(PassengersNumber.Text) <= 99)
                {
                    Bus newBus = new Bus(PassengersNumberTextBox);
                    Buses.Add(newBus);
                    BusNumber.Text = ("Colectivo N° " + (Buses.Count + 1).ToString());
                    PassengersNumber.Text = "0";
                }
                else MessageBox.Show("El número de pasajeros debe ser entre 0 y 99");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido cargar... Detalle del error: " + ex.Message); ;
            }
        }

        private void Button_Move(object sender, RoutedEventArgs e)
        {
            if (BusesList.SelectedItem != null)
            {
                Bus selected = BusesList.SelectedItem as Bus;
                MessageBox.Show(selected.Move());
            }
            else MessageBox.Show("Selecciona algún colectivo para que avance...");
        }

        private void Button_Stop(object sender, RoutedEventArgs e)
        {
            if (BusesList.SelectedItem != null)
            {
                Bus selected = BusesList.SelectedItem as Bus;
                MessageBox.Show(selected.Stop());
            }
            else MessageBox.Show("Selecciona algún colectivo para que se detenga...");
        }
    }
}
