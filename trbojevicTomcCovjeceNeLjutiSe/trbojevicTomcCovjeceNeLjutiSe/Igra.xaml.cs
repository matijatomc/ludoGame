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

        private void btnBaciKocku_Click(object sender, RoutedEventArgs e)
        {
            Random random= new Random();
            int brojNaKocki = random.Next(1, 7);

            BitmapImage slikaKocke = new BitmapImage();
            ImageBrush imageBrush = new ImageBrush();


            switch (brojNaKocki)
            {
                case 1:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri("/Slike/Kocka/1.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    kocka.Source = slikaKocke;
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    
                    break;
                case 2:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri("/Slike/Kocka/2.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    kocka.Source = slikaKocke;
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    break;
                case 3:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri("/Slike/Kocka/3.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    kocka.Source = slikaKocke;
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    break;
                case 4:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri("/Slike/Kocka/4.png", UriKind.RelativeOrAbsolute);    
                    slikaKocke.EndInit();
                    kocka.Source = slikaKocke;
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    break;
                case 5:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri("/Slike/Kocka/5.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    kocka.Source = slikaKocke;
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    break;
                case 6:
                    slikaKocke.BeginInit();
                    slikaKocke.UriSource = new Uri("/Slike/Kocka/6.png", UriKind.RelativeOrAbsolute);
                    slikaKocke.EndInit();
                    kocka.Source = slikaKocke;
                    imageBrush.ImageSource = slikaKocke;
                    btnBaciKocku.Background = imageBrush;
                    break;
            }
            txt.Text = Convert.ToString(brojNaKocki);
        }
    }
}
