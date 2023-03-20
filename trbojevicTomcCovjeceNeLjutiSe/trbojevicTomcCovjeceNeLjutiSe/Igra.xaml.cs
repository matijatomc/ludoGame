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

        Igrac igracZe, igracZu, igracP, igracC;

        int brojNaKocki = 0;
        int brojIgraca = 0;
        int igracNaPotezu = 1;

        private void PostaviIgrace(int brojIgraca)
        {
            igracZe = new Igrac();
            igracZe.Boja = "Zelena";
            igracZe.PocetnaPozicija = new Thickness[4] { new Thickness(85, 114, 0, 0), new Thickness(122, 80, 0, 0), new Thickness(159, 114, 0, 0), new Thickness(122, 149, 0, 0) };
            igracZe.PozicijeNaPloci = new Thickness[57] { new Thickness(65, 240, 0, 0), new Thickness(102, 240, 0, 0), new Thickness(138, 240, 0, 0), new Thickness(176, 240, 0, 0), new Thickness(213, 240, 0, 0), new Thickness(251, 204, 0, 0), new Thickness(251, 168, 0, 0), new Thickness(251, 133, 0, 0), new Thickness(251, 98, 0, 0), new Thickness(251, 63, 0, 0), new Thickness(251, 28, 0, 0), new Thickness(288, 28, 0, 0), new Thickness(324, 28, 0, 0), new Thickness(324, 63, 0, 0), new Thickness(324, 98, 0, 0), new Thickness(324, 133, 0, 0), new Thickness(324, 168, 0, 0), new Thickness(324, 204, 0, 0), new Thickness(361, 240, 0, 0), new Thickness(400, 240, 0, 0), new Thickness(436, 240, 0, 0), new Thickness(472, 240, 0, 0), new Thickness(510, 240, 0, 0), new Thickness(546, 240, 0, 0), new Thickness(546, 275, 0, 0), new Thickness(548, 309, 0, 0), new Thickness(510, 309, 0, 0), new Thickness(472, 309, 0, 0), new Thickness(436, 309, 0, 0), new Thickness(400, 309, 0, 0), new Thickness(361, 309, 0, 0), new Thickness(324, 346, 0, 0), new Thickness(324, 381, 0, 0), new Thickness(324, 416, 0, 0), new Thickness(324, 451, 0, 0), new Thickness(324, 486, 0, 0), new Thickness(324, 522, 0, 0), new Thickness(288, 522, 0, 0), new Thickness(251, 522, 0, 0), new Thickness(251, 486, 0, 0), new Thickness(251, 451, 0, 0), new Thickness(251, 416, 0, 0), new Thickness(251, 381, 0, 0), new Thickness(251, 346, 0, 0), new Thickness(213, 309, 0, 0), new Thickness(176, 309, 0, 0), new Thickness(138, 309, 0, 0), new Thickness(102, 309, 0, 0), new Thickness(65, 309, 0, 0), new Thickness(29, 309, 0, 0), new Thickness(29, 274, 0, 0), new Thickness(65, 274, 0, 0), new Thickness(102, 274, 0, 0), new Thickness(138, 274, 0, 0), new Thickness(176, 274, 0, 0), new Thickness(205, 274, 0, 0), new Thickness(251, 274, 0, 0) };

            igracZu = new Igrac();
            igracZu.Boja = "Zuta";
            igracZu.PocetnaPozicija = new Thickness[4] { new Thickness(418, 115, 0, 0), new Thickness(455, 80, 0, 0), new Thickness(492, 115, 0, 0), new Thickness(455, 150, 0, 0) };
            igracZu.PozicijeNaPloci = new Thickness[57] { new Thickness(324, 63, 0, 0), new Thickness(324, 98, 0, 0), new Thickness(324, 133, 0, 0), new Thickness(324, 168, 0, 0), new Thickness(324, 204, 0, 0), new Thickness(361, 240, 0, 0), new Thickness(400, 240, 0, 0), new Thickness(436, 240, 0, 0), new Thickness(472, 240, 0, 0), new Thickness(510, 240, 0, 0), new Thickness(546, 240, 0, 0), new Thickness(546, 275, 0, 0), new Thickness(548, 309, 0, 0), new Thickness(510, 309, 0, 0), new Thickness(472, 309, 0, 0), new Thickness(436, 309, 0, 0), new Thickness(400, 309, 0, 0), new Thickness(361, 309, 0, 0), new Thickness(324, 346, 0, 0), new Thickness(324, 381, 0, 0), new Thickness(324, 416, 0, 0), new Thickness(324, 451, 0, 0), new Thickness(324, 486, 0, 0), new Thickness(324, 522, 0, 0), new Thickness(288, 522, 0, 0), new Thickness(251, 522, 0, 0), new Thickness(251, 486, 0, 0), new Thickness(251, 451, 0, 0), new Thickness(251, 416, 0, 0), new Thickness(251, 381, 0, 0), new Thickness(251, 346, 0, 0), new Thickness(213, 309, 0, 0), new Thickness(176, 309, 0, 0), new Thickness(138, 309, 0, 0), new Thickness(102, 309, 0, 0), new Thickness(65, 309, 0, 0), new Thickness(29, 309, 0, 0), new Thickness(29, 274, 0, 0), new Thickness(29, 240, 0, 0), new Thickness(65, 240, 0, 0), new Thickness(102, 240, 0, 0), new Thickness(138, 240, 0, 0), new Thickness(176, 240, 0, 0), new Thickness(213, 240, 0, 0), new Thickness(251, 204, 0, 0), new Thickness(251, 168, 0, 0), new Thickness(251, 133, 0, 0), new Thickness(251, 98, 0, 0), new Thickness(251, 63, 0, 0), new Thickness(251, 28, 0, 0), new Thickness(288, 28, 0, 0), new Thickness(288, 62, 0, 0), new Thickness(288, 98, 0, 0), new Thickness(288, 134, 0, 0), new Thickness(288, 168, 0, 0), new Thickness(288, 204, 0, 0), new Thickness(288, 240, 0, 0) };

            if (brojIgraca >= 3)
            {
                igracP = new Igrac();
                igracP.Boja = "Plava";
                igracP.PocetnaPozicija = new Thickness[4] { new Thickness(418, 432, 0, 0), new Thickness(455, 396, 0, 0), new Thickness(492, 432, 0, 0), new Thickness(455, 467, 0, 0) };
                igracP.PozicijeNaPloci = new Thickness[57] { new Thickness(510, 309, 0, 0), new Thickness(472, 309, 0, 0), new Thickness(436, 309, 0, 0), new Thickness(400, 309, 0, 0), new Thickness(361, 309, 0, 0), new Thickness(324, 346, 0, 0), new Thickness(324, 381, 0, 0), new Thickness(324, 416, 0, 0), new Thickness(324, 451, 0, 0), new Thickness(324, 486, 0, 0), new Thickness(324, 522, 0, 0), new Thickness(288, 522, 0, 0), new Thickness(251, 522, 0, 0), new Thickness(251, 486, 0, 0), new Thickness(251, 451, 0, 0), new Thickness(251, 416, 0, 0), new Thickness(251, 381, 0, 0), new Thickness(251, 346, 0, 0), new Thickness(213, 309, 0, 0), new Thickness(176, 309, 0, 0), new Thickness(138, 309, 0, 0), new Thickness(102, 309, 0, 0), new Thickness(65, 309, 0, 0), new Thickness(29, 309, 0, 0), new Thickness(29, 274, 0, 0), new Thickness(29, 240, 0, 0), new Thickness(65, 240, 0, 0), new Thickness(102, 240, 0, 0), new Thickness(138, 240, 0, 0), new Thickness(176, 240, 0, 0), new Thickness(213, 240, 0, 0), new Thickness(251, 204, 0, 0), new Thickness(251, 168, 0, 0), new Thickness(251, 133, 0, 0), new Thickness(251, 98, 0, 0), new Thickness(251, 63, 0, 0), new Thickness(251, 28, 0, 0), new Thickness(288, 28, 0, 0), new Thickness(324, 28, 0, 0), new Thickness(324, 63, 0, 0), new Thickness(324, 98, 0, 0), new Thickness(324, 133, 0, 0), new Thickness(324, 168, 0, 0), new Thickness(324, 204, 0, 0), new Thickness(361, 240, 0, 0), new Thickness(400, 240, 0, 0), new Thickness(436, 240, 0, 0), new Thickness(472, 240, 0, 0), new Thickness(510, 240, 0, 0), new Thickness(546, 240, 0, 0), new Thickness(546, 275, 0, 0), new Thickness(510, 275, 0, 0), new Thickness(475, 275, 0, 0), new Thickness(436, 275, 0, 0), new Thickness(400, 275, 0, 0), new Thickness(361, 275, 0, 0), new Thickness(325, 275, 0, 0) };
            }
            if (brojIgraca == 4)
            {
                igracC = new Igrac();
                igracC.Boja = "Crvena";
                igracC.PocetnaPozicija = new Thickness[4] { new Thickness(85, 432, 0, 0), new Thickness(122, 397, 0, 0), new Thickness(159, 432, 0, 0), new Thickness(122, 467, 0, 0) };
                igracC.PozicijeNaPloci = new Thickness[57] { new Thickness(251, 486, 0, 0), new Thickness(251, 451, 0, 0), new Thickness(251, 416, 0, 0), new Thickness(251, 381, 0, 0), new Thickness(251, 346, 0, 0), new Thickness(213, 309, 0, 0), new Thickness(176, 309, 0, 0), new Thickness(138, 309, 0, 0), new Thickness(102, 309, 0, 0), new Thickness(65, 309, 0, 0), new Thickness(29, 309, 0, 0), new Thickness(29, 274, 0, 0), new Thickness(29, 240, 0, 0), new Thickness(65, 240, 0, 0), new Thickness(102, 240, 0, 0), new Thickness(138, 240, 0, 0), new Thickness(176, 240, 0, 0), new Thickness(213, 240, 0, 0), new Thickness(251, 204, 0, 0), new Thickness(251, 168, 0, 0), new Thickness(251, 133, 0, 0), new Thickness(251, 98, 0, 0), new Thickness(251, 63, 0, 0), new Thickness(251, 28, 0, 0), new Thickness(288, 28, 0, 0), new Thickness(324, 28, 0, 0), new Thickness(324, 63, 0, 0), new Thickness(324, 98, 0, 0), new Thickness(324, 133, 0, 0), new Thickness(324, 168, 0, 0), new Thickness(324, 204, 0, 0), new Thickness(361, 240, 0, 0), new Thickness(400, 240, 0, 0), new Thickness(436, 240, 0, 0), new Thickness(472, 240, 0, 0), new Thickness(510, 240, 0, 0), new Thickness(546, 240, 0, 0), new Thickness(546, 275, 0, 0), new Thickness(548, 309, 0, 0), new Thickness(510, 309, 0, 0), new Thickness(472, 309, 0, 0), new Thickness(436, 309, 0, 0), new Thickness(400, 309, 0, 0), new Thickness(361, 309, 0, 0), new Thickness(324, 346, 0, 0), new Thickness(324, 381, 0, 0), new Thickness(324, 416, 0, 0), new Thickness(324, 451, 0, 0), new Thickness(324, 486, 0, 0), new Thickness(324, 522, 0, 0), new Thickness(288, 522, 0, 0), new Thickness(288, 486, 0, 0), new Thickness(288, 451, 0, 0), new Thickness(288, 416, 0, 0), new Thickness(288, 381, 0, 0), new Thickness(288, 346, 0, 0), new Thickness(288, 309, 0, 0) };
            }
        }

        private bool AktiviranjeFigure()
        {   
            bool provjera = false;

            switch (igracNaPotezu)
            {
                case 1:
                    if (igracZe.ProvjeraFigura() || brojNaKocki == 6)
                    {
                        if (igracZe.FiguraNaPloci[0] || brojNaKocki == 6) { btnZeleni1.IsHitTestVisible = true; }
                        if (igracZe.FiguraNaPloci[1] || brojNaKocki == 6) { btnZeleni2.IsHitTestVisible = true; }
                        if (igracZe.FiguraNaPloci[2] || brojNaKocki == 6) { btnZeleni3.IsHitTestVisible = true; }
                        if (igracZe.FiguraNaPloci[3] || brojNaKocki == 6) { btnZeleni4.IsHitTestVisible = true; }
                        provjera = true;
                    }
                    break;
                case 2:
                    if (igracZu.ProvjeraFigura() || brojNaKocki == 6)
                    {
                        if (igracZu.FiguraNaPloci[0] || brojNaKocki == 6) { btnZuti1.IsHitTestVisible = true; }
                        if (igracZu.FiguraNaPloci[1] || brojNaKocki == 6) { btnZuti2.IsHitTestVisible = true; }
                        if (igracZu.FiguraNaPloci[2] || brojNaKocki == 6) { btnZuti3.IsHitTestVisible = true; }
                        if (igracZu.FiguraNaPloci[3] || brojNaKocki == 6) { btnZuti4.IsHitTestVisible = true; }
                        provjera = true;
                    }
                    break;
                case 3:
                    if (igracP.ProvjeraFigura() || brojNaKocki == 6)
                    {
                        if (igracP.FiguraNaPloci[0] || brojNaKocki == 6) { btnPlavi1.IsHitTestVisible = true; }
                        if (igracP.FiguraNaPloci[1] || brojNaKocki == 6) { btnPlavi2.IsHitTestVisible = true; }
                        if (igracP.FiguraNaPloci[2] || brojNaKocki == 6) { btnPlavi3.IsHitTestVisible = true; }
                        if (igracP.FiguraNaPloci[3] || brojNaKocki == 6) { btnPlavi4.IsHitTestVisible = true; }
                        provjera = true;
                    }
                    break;
                case 4:
                    if (igracC.ProvjeraFigura() || brojNaKocki == 6)
                    {
                        if (igracC.FiguraNaPloci[0] || brojNaKocki == 6) { btnCrveni1.IsHitTestVisible = true; }
                        if (igracC.FiguraNaPloci[1] || brojNaKocki == 6) { btnCrveni2.IsHitTestVisible = true; }
                        if (igracC.FiguraNaPloci[2] || brojNaKocki == 6) { btnCrveni3.IsHitTestVisible = true; }
                        if (igracC.FiguraNaPloci[3] || brojNaKocki == 6) { btnCrveni4.IsHitTestVisible = true; }
                        provjera = true;
                    }
                    break;
            }

            return provjera;
        }
        private void DeaktiviranjeFigure()
        {
            switch (igracNaPotezu)
            {
                case 1:
                    btnZeleni1.IsHitTestVisible = false;
                    btnZeleni2.IsHitTestVisible = false;
                    btnZeleni3.IsHitTestVisible = false;
                    btnZeleni4.IsHitTestVisible = false;
                    break;
                case 2:
                    btnZuti1.IsHitTestVisible = false;
                    btnZuti2.IsHitTestVisible = false;
                    btnZuti3.IsHitTestVisible = false;
                    btnZuti4.IsHitTestVisible = false;
                    break;
                case 3:
                    btnPlavi1.IsHitTestVisible = false;
                    btnPlavi2.IsHitTestVisible = false;
                    btnPlavi3.IsHitTestVisible = false;
                    btnPlavi4.IsHitTestVisible = false;
                    break;
                case 4:
                    btnCrveni1.IsHitTestVisible = false;
                    btnCrveni2.IsHitTestVisible = false;
                    btnCrveni3.IsHitTestVisible = false;
                    btnCrveni4.IsHitTestVisible = false;
                    break;
            }

            btnBaciKocku.IsHitTestVisible = true;

            if (brojNaKocki != 6)
            {
                ++igracNaPotezu;
                if (igracNaPotezu > brojIgraca) { igracNaPotezu = 1; }

                switch (igracNaPotezu)
                {
                    case 1:
                        txtBox.Text = "Zeleni";
                        txtBox.Background = Brushes.Green;
                        break;
                    case 2:
                        txtBox.Text = "Žuti";
                        txtBox.Background = Brushes.Yellow;
                        break;
                    case 3:
                        txtBox.Text = "Plavi";
                        txtBox.Background = Brushes.Blue;
                        break;
                    case 4:
                        txtBox.Text = "Crveni";
                        txtBox.Background = Brushes.Red;
                        break;
                }
            }
        }

        private Thickness PomicanjeFigura(Igrac igrac, int figura, int pomak)
        {
            Thickness novaPozicija = igrac.PozicijeNaPloci[igrac.TrenutnaPozicija[figura]];
            if (igrac.TrenutnaPozicija[figura] + pomak < 56)
            {
                novaPozicija = igrac.PozicijeNaPloci[igrac.TrenutnaPozicija[figura] + pomak];
                igrac.TrenutnaPozicija[figura] += pomak;
            }
            else if (igrac.TrenutnaPozicija[figura] + pomak == 56)
            {
                ++igrac.BrojFiguraUKucici;
                novaPozicija = igrac.PozicijeNaPloci[igrac.TrenutnaPozicija[figura] + pomak];
                igrac.TrenutnaPozicija[figura] += pomak;

                if (igrac.BrojFiguraUKucici == 4) { Pobjeda(igrac); }
            }
            return novaPozicija;
        }

        private void Pobjeda(Igrac igrac)
        {
            MessageBoxResult result = MessageBoxResult.No;
            switch (igrac.Boja)
            {
                case "Zelena":
                    result = MessageBox.Show("Pobjetnik je Zeleni! Želite li igrat ispočetka?", "Kraj igre", MessageBoxButton.YesNo);
                    break;
                case "Zuta":
                    result = MessageBox.Show("Pobjetnik je Žuti! Želite li igrat ispočetka?", "Kraj igre", MessageBoxButton.YesNo);
                    break;
                case "Plava":
                    result = MessageBox.Show("Pobjetnik je Plavi! Želite li igrat ispočetka?", "Kraj igre", MessageBoxButton.YesNo);
                    break;
                case "Crvena":
                    result = MessageBox.Show("Pobjetnik je Crveni! Želite li igrat ispočetka?", "Kraj igre", MessageBoxButton.YesNo);
                    break;
            }

            if (result == MessageBoxResult.Yes)
            {
                Igra igra = new Igra();
                this.Close();
                igra.ShowDialog();
            }
            else if (result == MessageBoxResult.No)
            {
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OdabirIgraca OdabirIgraca = new OdabirIgraca();
            OdabirIgraca.ShowDialog();
            brojIgraca = OdabirIgraca.brojIgraca;

            if (OdabirIgraca.odustao)
            {
                this.Close();
            }

            PostaviIgrace(brojIgraca);

            txtBox.Text = "Zeleni";
            txtBox.Background = Brushes.Green;
        }

        private void btnBaciKocku_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            brojNaKocki = random.Next(1, 7);

            btnBaciKocku.Content = new Image
            {
                Source = new BitmapImage(new Uri($"/Slike/Kocka/{brojNaKocki}.png", UriKind.Relative)),
            };

            if (AktiviranjeFigure())
            {
                btnBaciKocku.IsHitTestVisible = false;
            }
            else
            {
                DeaktiviranjeFigure();
            }
        }

        private void btnZeleni1_Click(object sender, RoutedEventArgs e)
        {
            if (igracZe.FiguraNaPloci[0])
            {
                btnZeleni1.Margin = PomicanjeFigura(igracZe, 0, brojNaKocki);
                DeaktiviranjeFigure();
            }else
            {
                btnZeleni1.Margin = igracZe.PozicijeNaPloci[0];
                igracZe.FiguraNaPloci[0] = true;
                DeaktiviranjeFigure();
            }
        }
        private void btnZeleni2_Click(object sender, RoutedEventArgs e)
        {
            if (igracZe.FiguraNaPloci[1])
            {
                btnZeleni2.Margin = PomicanjeFigura(igracZe, 1, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnZeleni2.Margin = igracZe.PozicijeNaPloci[0];
                igracZe.FiguraNaPloci[1] = true;
                DeaktiviranjeFigure();
            }
        }
        private void btnZeleni3_Click(object sender, RoutedEventArgs e)
        {
            if (igracZe.FiguraNaPloci[2])
            {
                btnZeleni3.Margin = PomicanjeFigura(igracZe, 2, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnZeleni3.Margin = igracZe.PozicijeNaPloci[0];
                igracZe.FiguraNaPloci[2] = true;
                DeaktiviranjeFigure();
            }
        }
        private void btnZeleni4_Click(object sender, RoutedEventArgs e)
        {
            if (igracZe.FiguraNaPloci[3])
            {
                btnZeleni4.Margin = PomicanjeFigura(igracZe, 3, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnZeleni4.Margin = igracZe.PozicijeNaPloci[0];
                igracZe.FiguraNaPloci[3] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnZuti1_Click(object sender, RoutedEventArgs e)
        {
            if (igracZu.FiguraNaPloci[0])
            {
                btnZuti1.Margin = PomicanjeFigura(igracZu, 0, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnZuti1.Margin = igracZu.PozicijeNaPloci[0];
                igracZu.FiguraNaPloci[0] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnZuti2_Click(object sender, RoutedEventArgs e)
        {
            if (igracZu.FiguraNaPloci[1])
            {
                btnZuti2.Margin = PomicanjeFigura(igracZu, 1, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnZuti2.Margin = igracZu.PozicijeNaPloci[0];
                igracZu.FiguraNaPloci[1] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnZuti3_Click(object sender, RoutedEventArgs e)
        {
            if (igracZu.FiguraNaPloci[2])
            {
                btnZuti3.Margin = PomicanjeFigura(igracZu, 2, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnZuti3.Margin = igracZu.PozicijeNaPloci[0];
                igracZu.FiguraNaPloci[2] = true;
                DeaktiviranjeFigure();
            }
        }
        private void btnZuti4_Click(object sender, RoutedEventArgs e)
        {
            if (igracZu.FiguraNaPloci[3])
            {
                btnZuti4.Margin = PomicanjeFigura(igracZu, 3, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnZuti4.Margin = igracZu.PozicijeNaPloci[0];
                igracZu.FiguraNaPloci[3] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnPlavi1_Click(object sender, RoutedEventArgs e)
        {
            if (igracP.FiguraNaPloci[0])
            {
                btnPlavi1.Margin = PomicanjeFigura(igracP, 0, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnPlavi1.Margin = igracP.PozicijeNaPloci[0];
                igracP.FiguraNaPloci[0] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnPlavi2_Click(object sender, RoutedEventArgs e)
        {
            if (igracP.FiguraNaPloci[1])
            {
                btnPlavi2.Margin = PomicanjeFigura(igracP, 1, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnPlavi2.Margin = igracP.PozicijeNaPloci[0];
                igracP.FiguraNaPloci[1] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnPlavi3_Click(object sender, RoutedEventArgs e)
        {
            if (igracP.FiguraNaPloci[2])
            {
                btnPlavi3.Margin = PomicanjeFigura(igracP, 2, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnPlavi3.Margin = igracP.PozicijeNaPloci[0];
                igracP.FiguraNaPloci[2] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnPlavi4_Click(object sender, RoutedEventArgs e)
        {
            if (igracP.FiguraNaPloci[3])
            {
                btnPlavi4.Margin = PomicanjeFigura(igracP, 3, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnPlavi4.Margin = igracP.PozicijeNaPloci[0];
                igracP.FiguraNaPloci[3] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnCrveni1_Click(object sender, RoutedEventArgs e)
        {
            if (igracC.FiguraNaPloci[0])
            {
                btnCrveni1.Margin = PomicanjeFigura(igracC, 0, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnCrveni1.Margin = igracC.PozicijeNaPloci[0];
                igracC.FiguraNaPloci[0] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnCrveni2_Click(object sender, RoutedEventArgs e)
        {
            if (igracC.FiguraNaPloci[1])
            {
                btnCrveni2.Margin = PomicanjeFigura(igracC, 1, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnCrveni2.Margin = igracC.PozicijeNaPloci[0];
                igracC.FiguraNaPloci[1] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnCrveni3_Click(object sender, RoutedEventArgs e)
        {
            if (igracC.FiguraNaPloci[2])
            {
                btnCrveni3.Margin = PomicanjeFigura(igracC, 2, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnCrveni3.Margin = igracC.PozicijeNaPloci[0];
                igracC.FiguraNaPloci[2] = true;
                DeaktiviranjeFigure();
            }
        }

        private void btnCrveni4_Click(object sender, RoutedEventArgs e)
        {
            if (igracC.FiguraNaPloci[3])
            {
                btnCrveni4.Margin = PomicanjeFigura(igracC, 3, brojNaKocki);
                DeaktiviranjeFigure();
            }
            else
            {
                btnCrveni4.Margin = igracC.PozicijeNaPloci[0];
                igracC.FiguraNaPloci[3] = true;
                DeaktiviranjeFigure();
            }
        }
    }
}
