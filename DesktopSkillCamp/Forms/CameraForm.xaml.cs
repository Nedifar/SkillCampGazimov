using Microsoft.Win32;
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
    /// Логика взаимодействия для CameraForm.xaml
    /// </summary>
    public partial class CameraForm : Window
    {
        public CameraForm()
        {
            InitializeComponent();
        }

        private void clSelectPhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if(fileDialog.ShowDialog() == true)
            {
                img.Source = new BitmapImage(new Uri(fileDialog.FileName));
            }
        }

        private void clAccept(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
