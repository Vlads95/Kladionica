using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Igrac:Osoba
    {

        int iznos;
        Zemlja odabranaZemlja;

        public Igrac(int iznos , Zemlja odabranaZemlja, String ime ,String prezime , DateTime datumRodjenja):base(ime,prezime,datumRodjenja)
        {
            this.iznos = iznos;
            this.odabranaZemlja = odabranaZemlja;
        }

        public int Iznos { get => iznos; set => iznos = value; }
        public Zemlja OdabranaZemlja { get => odabranaZemlja; set => odabranaZemlja = value; }
    }
}
