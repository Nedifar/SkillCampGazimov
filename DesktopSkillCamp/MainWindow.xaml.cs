using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace DesktopSkillCamp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void clLoadData(object sender, RoutedEventArgs e)
        {
            if (int.Parse(tbId.Text) >= 1 && int.Parse(tbId.Text) <= 99)
                using (var http = new HttpClient())
                {
                    var response = await http.GetAsync($"http://localhost:60424/api/stations/getStationInfo?id={int.Parse(tbId.Text)}");
                    response.EnsureSuccessStatusCode();
                    var result = response.Content.ReadAsAsync<Models.GasStation>().Result;
                    Forms.GasStationInfoForm gasStationInfoForm = new Forms.GasStationInfoForm(result);
                    gasStationInfoForm.Show();
                }
            else
                MessageBox.Show("Error");
        }

        private void clZapravka(object sender, RoutedEventArgs e)
        {
            Forms.FilingColumnModuleForm filing = new Forms.FilingColumnModuleForm();
            filing.Show();

        }

        private void clCamera(object sender, RoutedEventArgs e)
        {

        }
    }
}
