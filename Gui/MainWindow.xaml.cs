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
using DataAccess;
using Entities;
using Services;

namespace Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Repository repo;
        public MainWindow()
        {
            InitializeComponent();
            WeatherService weatherService = new();
            string weather = weatherService.GetWeather();
            try
            {
                repo = new();
            }
            catch (Exception e)
            {

                MessageBox.Show($"Fejl under tilgang til data: {e.Message}", "Opstartsfejl", MessageBoxButton.OK, MessageBoxImage.Error);
                Close();
            }
            List<ContactInformation> contactInformation = repo.GetAllContactInformations();
            GridListPeople.ItemsSource = repo.GetAllPersons();
            GridListAddresses.ItemsSource = repo.GetAllAddresses();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Mock input data:
            string mail = "person@gmail.com";
            string phoneNumberInput = "52534513";

            //Make object to send to repository:
            ContactInformation contactInformation = new()
            {
                Mail = mail,
                PhoneNumber = phoneNumberInput
            };

            //Call the repository:
            repo.AddNewContactInformation(contactInformation);
        }
    }
}