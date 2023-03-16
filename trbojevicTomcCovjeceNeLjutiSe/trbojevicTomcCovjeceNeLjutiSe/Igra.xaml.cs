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

namespace trbojevicTomcCovjeceNeLjutiSe
{
    /// <summary>
    /// Interaction logic for Igra.xaml
    /// </summary>
    public partial class Igra : Window
    {
        public Igra()
        {
            InitializeComponent();
        }

        int brojNaKocki = 0;
        int brojIgraca = 0;
        bool izacNaPlocu = false;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OdabirIgraca OdabirIgraca = new OdabirIgraca();
            OdabirIgraca.ShowDialog();
            brojIgraca = OdabirIgraca.brojIgraca;
            txtBox.Text = Convert.ToString(brojIgraca);

            switch (brojIgraca)
            {
                case 2:
                    pijunCrveni1.IsEnabled= false;
                    pijunCrveni2.IsEnabled= false;
                    pijunCrveni3.IsEnabled= false;
                    pijunCrveni4.IsEnabled= false;
                    pijunPlavi1.IsEnabled= false;
                    pijunPlavi2.IsEnabled= false;
                    pijunPlavi3.IsEnabled = false;
                    pijunPlavi4.IsEnabled = false;
                    break;
                case 3:
                    pijunPlavi1.IsEnabled = false;
                    pijunPlavi2.IsEnabled = false;
                    pijunPlavi3.IsEnabled = false;
                    pijunPlavi4.IsEnabled = false;
                    break;
            }
        }

        private void btnBaciKocku_Click(object sender, RoutedEventArgs e)
        {
            Random random= new Random();
            brojNaKocki = random.Next(1, 7);

            BitmapImage slikaKocke = new BitmapImage();
            ImageBrush imageBrush = new ImageBrush();

            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            switch (brojNaKocki)
            {
                case 1:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri(projectDirectory + "/Slike/Kocka/1.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    izacNaPlocu = false;
                    break;
                case 2:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri(projectDirectory + "/Slike/Kocka/2.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    izacNaPlocu = false;
                    break;
                case 3:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri(projectDirectory + "/Slike/Kocka/3.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    izacNaPlocu = false;
                    break;
                case 4:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri(projectDirectory + "/Slike/Kocka/4.png", UriKind.RelativeOrAbsolute);    
                    slikaKocke.EndInit();
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    izacNaPlocu = false;
                    break;
                case 5:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri(projectDirectory + "/Slike/Kocka/5.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    izacNaPlocu = false;
                    break;
                case 6:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri(projectDirectory + "/Slike/Kocka/6.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    izacNaPlocu = true;
                    break;
            }
        }

        private void pijunZeleni1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
