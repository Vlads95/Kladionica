using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{

    public enum Kontinent { EU, AZ, AF, SA, JA, AU }


    public class Zemlja
    {

        Kontinent kontinent;
        String naziv;
        int kvota;

        public Zemlja(String naziv, int kvota, Kontinent kontinent)
        {
            this.naziv = naziv;
            this.kvota = kvota;
            this.kontinent = kontinent;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public int Kvota { get => kvota; set => kvota = value; }
    }
}
