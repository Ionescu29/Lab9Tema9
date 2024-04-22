using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Tema9
{
    //Contul de investiții este un cont bancar care se comportă precum un cont de
    //economii, cu mențiunea ca extragerea banilor este posibila abia dupa atingerea termenului de extragere
    //La deschiderea unui cont de investitii, ziua termenului de extragere va fi specificat sub forma unui intreg(1-31)
    //Dacă se incearcă extragerea banilor înainte de termen, contul va afișa un mesaj corespunzător iar suma nu va fi extrasa din cont.
    internal class ContDeInvestitii
    {
        private string nume;
        private string tipulContului;
        private int ziuaTermenului;
        private int soldDeInvestitii;
        private int sumaExtrasa;
        private int dataExtragerii;
        public ContDeInvestitii(string nume, string tipulContului, int ziuaTermenului, int soldDeInvestitii, int sumaExtrasa, int dataExtragerii)
        {
            this.nume = nume;
            this.tipulContului = tipulContului;
            this.ziuaTermenului= ziuaTermenului;
            this.soldDeInvestitii = soldDeInvestitii;
            this.sumaExtrasa = sumaExtrasa;
            this.dataEtragerii = dataExtragerii;
        }
        public void ExtragereBani()
        {
            if(dataExtragerii==ziuaTermenlui)
            {
                return sumaExtrasa;
            }
            else(dataExtragerii<ziuaTermenlui )
            {
                Console.WriteLine("Suma nu poate fi extrasa inaintea termenului specificat");
            }
        }
    }
}
