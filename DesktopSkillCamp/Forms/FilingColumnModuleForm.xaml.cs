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
    /// Логика взаимодействия для FilingColumnModuleForm.xaml
    /// </summary>
    public partial class FilingColumnModuleForm : Window
    {
        Models.GasStation gas;
        public FilingColumnModuleForm()
        {
            InitializeComponent();
            cbMode.ItemsSource = new string[] { "Фиксированный объем", "Фиксированная цена", "До полного бака с ограничением по объему" };
            cbPayment.ItemsSource = new string[] { "Накопительная карта", "Кредитная карта", "Банковская карта" };
        }

        private async void clBegin(object sender, RoutedEventArgs e)
        {
            using (var http = new HttpClient())
            {
                var response = await http.GetAsync($"http://localhost:60424/api/stations/getStationInfo?id={int.Parse(tbAZS.Text)}");
                response.EnsureSuccessStatusCode();
                gas = response.Content.ReadAsAsync<Models.GasStation>().Result;
                cbViewT.ItemsSource = gas.CarFillingStations.ToList();
            }
        }

        private async void clPayment(object sender, RoutedEventArgs e)
        {
            using (var http = new HttpClient())
            {
                switch (cbPayment.SelectedIndex)
                {
                    case 0:
                        {
                            var response = await http.GetAsync($"http://localhost:60424/api/stations/getLoaylityBalance/{tbName.Text}");
                            response.EnsureSuccessStatusCode();
                            var result = response.Content.ReadAsAsync<Models.LoyaltyCard>();
                            var carFillSel = cbViewT.SelectedItem as Models.CarFillingStation;
                            if (cbMode.SelectedIndex == 0)
                            {
                                if (double.Parse(tbLitr.Text) * carFillSel.Price < result.Result.Balance)
                                {
                                    MessageBox.Show("Оплата завершена");
                                    result.Result.Balance -= double.Parse(tbLitr.Text) * carFillSel.Price;
                                    var response1 = await http.PostAsync("http://localhost:60424/api/stations/getLoaylityBalanceModify", result.Result, new JsonMediaTypeFormatter());
                                    response1.EnsureSuccessStatusCode();
                                }
                                else
                                {
                                    MessageBox.Show("Недостаточно средств");
                                }
                            }
                            else if (cbMode.SelectedIndex == 1)
                            {
                                if (double.Parse(tbPrice.Text) < result.Result.Balance)
                                {
                                    MessageBox.Show("Оплата завершена");
                                    result.Result.Balance -= double.Parse(tbPrice.Text);
                                    var response2 = await http.PostAsync("http://localhost:60424/api/stations/getLoaylityBalanceModify", result.Result, new JsonMediaTypeFormatter());
                                    response2.EnsureSuccessStatusCode();
                                }
                                else
                                {
                                    MessageBox.Show("Недостаточно средств");
                                }
                            }
                            break;
                        }
                    case 1:
                        {

                            var response = await http.GetAsync($"http://localhost:60424/api/stations/getDepositBalance?loal={tbName.Text}");
                            response.EnsureSuccessStatusCode();
                            var result = response.Content.ReadAsAsync<Models.DepositCard>();
                            var carFillSel = cbViewT.SelectedItem as Models.CarFillingStation;
                            if (cbMode.SelectedIndex == 0)
                            {
                                if (double.Parse(tbLitr.Text) * carFillSel.Price < result.Result.Balance)
                                {
                                    MessageBox.Show("Оплата завершена");
                                    result.Result.Balance -= double.Parse(tbLitr.Text) * carFillSel.Price;
                                    var response1 = await http.PostAsync("http://localhost:60424/api/stations/getDepositBalanceModify", result.Result, new JsonMediaTypeFormatter());
                                    response1.EnsureSuccessStatusCode();
                                }
                                else
                                {
                                    MessageBox.Show("Недостаточно средств");
                                }
                            }
                            else if (cbMode.SelectedIndex == 1)
                            {
                                if (double.Parse(tbPrice.Text) < result.Result.Balance)
                                {
                                    MessageBox.Show("Оплата завершена");
                                    result.Result.Balance -= double.Parse(tbPrice.Text);
                                    var response2 = await http.PostAsync("http://localhost:60424/api/stations/getDepositBalanceModify", result.Result, new JsonMediaTypeFormatter());
                                    response2.EnsureSuccessStatusCode();
                                }
                                else
                                {
                                    MessageBox.Show("Недостаточно средств");
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            var carFillSel = cbViewT.SelectedItem as Models.CarFillingStation;
                            double price = 0;
                            if (cbMode.SelectedIndex == 0)
                            {
                                price = double.Parse(tbLitr.Text) * carFillSel.Price;
                            }
                            else if(cbMode.SelectedIndex == 1)
                            {
                                price = double.Parse(tbPrice.Text);
                                tbLitr.Text = (price / carFillSel.Price).ToString();
                            }
                            Models.Pay pay = new Models.Pay
                            {
                                CardNumber = tbNumberCard.Text,
                                CardHolder = tbPerson.Text,
                                Code = "000",
                                Price = price,
                                OrganizationName = "Сбербанк",
                                idStation = gas.idStation,
                                key = Models.Session.sessionKey.ToString()
                            };
                            var response4 = await http.PostAsync("http://localhost:60424/api/stations/pay", pay, new JsonMediaTypeFormatter());
                            response4.EnsureSuccessStatusCode();
                            if(response4.Content.ReadAsStringAsync().Result.Contains("Одобрено"))
                            {
                                Models.Purchase purchase = new Models.Purchase
                                {
                                    CardHolder = tbPerson.Text,
                                    PurchaseDate = DateTime.Now,
                                    idStation = gas.idStation,
                                    FuelType = carFillSel.Name,
                                    Value = double.Parse(tbLitr.Text),
                                    Cost = price,
                                    PaymentType = cbMode.Text
                                };
                                var response5 = await http.PostAsync("http://localhost:60424/api/stations/purchase", purchase, new JsonMediaTypeFormatter());
                                response5.EnsureSuccessStatusCode();
                            }

                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void selChang(object sender, SelectionChangedEventArgs e)
        {
            if (cbPayment.SelectedIndex == 2)
                spPoKarte.Visibility = Visibility.Visible;
        }

        private void cbMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbMode.SelectedIndex == 0)
            {
                spC.Visibility = Visibility.Visible;
                spPrice.Visibility = Visibility.Collapsed;

            }
            else if (cbMode.SelectedIndex == 1)
            {
                spPrice.Visibility = Visibility.Visible;
                spC.Visibility = Visibility.Collapsed;
            }
        }
    }
}
