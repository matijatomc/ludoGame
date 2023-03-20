using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace trbojevicTomcCovjeceNeLjutiSe
{
    class Igrac
    {
        string boja;
        Thickness[] pocetnaPozicija;
        Thickness[] pozicijeNaPloci;
        int[] trenutnaPozicija;
        int brojFiguraUKucici;
        bool[] figuraNaPloci;

        public Igrac()
        {
            trenutnaPozicija = new int[4] {0, 0, 0, 0};
            figuraNaPloci = new bool[4] {false, false, false, false};
            brojFiguraUKucici = 0;
        }

        public string Boja { get => boja; set => boja = value; }
        public Thickness[] PocetnaPozicija { get => pocetnaPozicija; set => pocetnaPozicija = value; }
        public Thickness[] PozicijeNaPloci { get => pozicijeNaPloci; set => pozicijeNaPloci = value; }
        public int[] TrenutnaPozicija { get => trenutnaPozicija; set => trenutnaPozicija = value; }
        public int BrojFiguraUKucici { get => brojFiguraUKucici; set => brojFiguraUKucici = value; }
        public bool[] FiguraNaPloci { get => figuraNaPloci; set => figuraNaPloci = value; }

        public bool ProvjeraFigura()
        {
            int brojFiguraNaPloci = 0;

            for (int i = 0; i < 4; i++)
            {
                if (figuraNaPloci[i]) { brojFiguraNaPloci++; }
            }

            if (brojFiguraNaPloci > 0)
            {
                return true;
            }
            else { return false; }
        }

        public Thickness IzlazNaPlocu(int figura, int brojNaKocki)
        {
            if (brojNaKocki == 6)
            {
                return PozicijeNaPloci[trenutnaPozicija[figura]];
            }
            else
            {
                return PocetnaPozicija[figura];
            }
        }

        public Thickness VrecanjeUKucicu(int figura)
        {
            FiguraNaPloci[figura] = false;
            return PocetnaPozicija[figura];
        }
    }
}
