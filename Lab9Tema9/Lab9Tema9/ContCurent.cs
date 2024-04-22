using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Tema9
{

    internal class ContCurent
    {
        private string nume;
        private string tipulContului;
        private int soldCurent;
        private int sumaExtrasa;
        private int limitaPlafonului;
        public ContCurent (string nume, string tipulContului, int soldCurent,  int sumaExtrasa, int limitaPlafonului)
        {
            this.nume = nume;
            this.tipulContului = tipulContului;
            this.soldCurent = soldCurent;
            this.sumaExtrasa = sumaExtrasa;
            this.limitaPlafonului = limitaPlafonului;
        }
        //La extragerea numerarului dintr-un cont curent, in cazul in care suma extrasa este mai mare
        //decat cea disponibila in cont, contul va permite descoperirea de cont in limita plafonului de 5000ron.
        public void ExtragereNumerar()
        {
            if (sumaExtrasa>soldCurent)
            {
                Console.WriteLine($"Contul permite descoperirea pana la suma de 5000RON");
            } 
            //Daca suma ceruta depaseste plafonul descoperirii de cont, atunci pe ecran va fi afișat un mesaj
            //corespunzator iar suma nu va fi extrasa.
            if(sumaExtrasa>limitaPlafonului)
            {
                Console.WriteLine($"Suma nu poate fi extrasa");
            }
        }
       

    }
}
