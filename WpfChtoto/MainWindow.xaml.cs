using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfChtoto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        HttpClient httpClient=new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("http://localhost:5095/api/");
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private async void CreatePassportButtom_Click(object sender, RoutedEventArgs e)
        {
            var passport = new
            {
                FirstName = Passport_FirstnameTextbox.Text,
                LastName = Passport_LastnameTextbox.Text,
                IssueDate = Passport_IssueDateTextbox.Text,
                ROVD = Passport_ROVDTextbox.Text,
                SeriesAndNumber = Passport_SeriesAndNumberTextbox.Text
            };
           
        }
    }
}