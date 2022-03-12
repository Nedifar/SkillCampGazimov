using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
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

namespace DesktopSkillCamp.Forms
{
    /// <summary>
    /// Логика взаимодействия для GasStationInfoForm.xaml
    /// </summary>
    public partial class GasStationInfoForm : Window
    {
        int selectedId;
        Models.GasStation selectedGasStation = new Models.GasStation();
        public GasStationInfoForm(Models.GasStation gasStation, int id)
        {
            InitializeComponent();
            selectedId = id;
            if(gasStation !=null)
            {
                selectedGasStation = gasStation;
                try
                {
                    price92.Text = gasStation.CarFillingStations.Where(p => p.Name == "92").FirstOrDefault().Price.ToString();
                    ostalos92.Text = gasStation.CarFillingStations.Where(p => p.Name == "92").FirstOrDefault().AmountOfFuel.ToString();
                }
                catch { }
                try
                {
                    price95.Text = gasStation.CarFillingStations.Where(p => p.Name == "95").FirstOrDefault().Price.ToString();
                    ostalos95.Text = gasStation.CarFillingStations.Where(p => p.Name == "95").FirstOrDefault().AmountOfFuel.ToString();
                }
                catch { }
                try
                {
                    price98.Text = gasStation.CarFillingStations.Where(p => p.Name == "98").FirstOrDefault().Price.ToString();
                    ostalos98.Text = gasStation.CarFillingStations.Where(p => p.Name == "98").FirstOrDefault().AmountOfFuel.ToString();
                }
                catch { }
                try
                {
                    priceDT.Text = gasStation.CarFillingStations.Where(p => p.Name == "Disel Fuel").FirstOrDefault().Price.ToString();
                    ostalosDT.Text = gasStation.CarFillingStations.Where(p => p.Name == "Disel Fuel").FirstOrDefault().AmountOfFuel.ToString();
                }
                catch { }
            }
            DataContext = selectedGasStation;
        }

        private async void clSave(object sender, RoutedEventArgs e)
        {
            try
            {
                selectedGasStation.CarFillingStations.Where(p => p.Name == "92").FirstOrDefault().Price = float.Parse(price92.Text);
                selectedGasStation.CarFillingStations.Where(p => p.Name == "92").FirstOrDefault().AmountOfFuel = int.Parse(ostalos92.Text);
            }
            catch
            {
                if (price92.Text != "" && ostalos92.Text != "")
                {
                    selectedGasStation.CarFillingStations.Add(new Models.CarFillingStation { Name = "92", AmountOfFuel = int.Parse(ostalos92.Text), Price = float.Parse(price92.Text) });
                }
            }
            try
            {
                selectedGasStation.CarFillingStations.Where(p => p.Name == "95").FirstOrDefault().Price = float.Parse(price95.Text);
                selectedGasStation.CarFillingStations.Where(p => p.Name == "95").FirstOrDefault().AmountOfFuel = int.Parse(ostalos95.Text);
            }
            catch
            {
                if (price95.Text != "" && ostalos95.Text != "")
                {
                    selectedGasStation.CarFillingStations.Add(new Models.CarFillingStation { Name = "95", AmountOfFuel = int.Parse(ostalos95.Text), Price = float.Parse(price95.Text) });
                }
            }
            try
            {
                selectedGasStation.CarFillingStations.Where(p => p.Name == "98").FirstOrDefault().Price = float.Parse(price98.Text);
                selectedGasStation.CarFillingStations.Where(p => p.Name == "98").FirstOrDefault().AmountOfFuel = int.Parse(ostalos98.Text);
            }
            catch
            {
                if (price98.Text != "" && ostalos98.Text != "")
                {
                    selectedGasStation.CarFillingStations.Add(new Models.CarFillingStation { Name = "98", AmountOfFuel = int.Parse(ostalos98.Text), Price = float.Parse(price98.Text) });
                }
            }
            try
            {
                selectedGasStation.CarFillingStations.Where(p => p.Name == "Disel Fuel").FirstOrDefault().Price = float.Parse(priceDT.Text);
                selectedGasStation.CarFillingStations.Where(p => p.Name == "Disel Fuel").FirstOrDefault().AmountOfFuel = int.Parse(ostalosDT.Text);
            }
            catch 
            {
                if(priceDT.Text!="" && ostalosDT.Text !="")
                {
                    selectedGasStation.CarFillingStations.Add(new Models.CarFillingStation { Name = "Disel Fuel", AmountOfFuel = int.Parse(ostalosDT.Text), Price = float.Parse(priceDT.Text) });
                }
            }
            if (selectedGasStation.idStation == 0)
            {
                selectedGasStation.idStation = selectedId;
            }
                using(var http = new HttpClient())
                {
                    var response = await http.PostAsync("http://localhost:60424/api/stations", selectedGasStation, new JsonMediaTypeFormatter());
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show("Сохранено успешно");
                    Close();
                }
            
        }
    }
}
