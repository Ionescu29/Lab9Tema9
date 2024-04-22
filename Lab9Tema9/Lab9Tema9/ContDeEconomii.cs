using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Tema9
{
    //Este carecterizat de o rata a dobanzii.
    internal class ContDeEconomii
    {
        private string nume;
        private string tipulContului;
        private int valoareSold;
        private int rataDobanzii;
        public ContDeEconomii(string nume, string tipulContului, int valoareSold, int rataDobanzii)
        {
            this.nume = nume;
            this.tipulContului = tipulContului;
            this.valoareSold = valoareSold;
            this.rataDobanzii = rataDobanzii;
        }
        //Dupa fiecare depunere, soldul contului de economii va fi reactualizat tinandu-se cont de rata
        //dobanzii :
        public void Depunere()
        {
            if (rataDobanzii!=0)
            {
                valoareSold = valoareSold * (1 + rataDobanzii);
            }
        }
    }
}
