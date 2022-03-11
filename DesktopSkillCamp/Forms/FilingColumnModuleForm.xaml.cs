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
using System.Windows.Shapes;

namespace DesktopSkillCamp.Forms
{
    /// <summary>
    /// Логика взаимодействия для FilingColumnModuleForm.xaml
    /// </summary>
    public partial class FilingColumnModuleForm : Window
    {
        public FilingColumnModuleForm()
        {
            InitializeComponent();
            cbMode.ItemsSource = new string[] { "Фиксированный объем", "Фиксированная цена", "До полного бака с ограничением по объему" };
            cbPayment.ItemsSource = new string[] { "Накопительная карта", "Кредитная карта", "Банковская карта" };
            cbViewT.ItemsSource = new string[] { "92", "95", "98", "ДТ" };
        }

        private void clBegin(object sender, RoutedEventArgs e)
        {
            //if()
        }

        private void clPayment(object sender, RoutedEventArgs e)
        {

        }
    }
}
