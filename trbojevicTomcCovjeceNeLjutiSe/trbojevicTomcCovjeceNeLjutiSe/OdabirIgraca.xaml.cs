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
    /// Interaction logic for OdabirIgraca.xaml
    /// </summary>
    public partial class OdabirIgraca : Window
    {
        public OdabirIgraca()
        {
            InitializeComponent();
        }

        public int brojIgraca = 0;

        private void btnUredu_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtIgraci.Text, out brojIgraca) && brojIgraca > 1 && brojIgraca < 5) { this.Close(); }
            else { MessageBox.Show("Unesite točan broj."); }
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
