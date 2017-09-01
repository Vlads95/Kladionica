using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class UplatnoMesto
    {

        String adresa;
        String grad;
        List<Igrac> listaIgraca;


        public UplatnoMesto(String adresa, String grad)
        {
            this.adresa = adresa;
            this.grad = grad;
            listaIgraca = new List<Igrac>();
        }

        public string Adresa { get => adresa; set => adresa = value; }
        public string Grad { get => grad; set => grad = value; }
        public List<Igrac> ListaIgraca { get => listaIgraca; set => listaIgraca = value; }


        List<Zemlja> spisakZemalja;
        // = new List<Zemlja>();
        public int brojZemalja()
        {


            foreach (Igrac i in listaIgraca)
            {
                if (!spisakZemalja.Contains(i.OdabranaZemlja)) { spisakZemalja.Add(i.OdabranaZemlja); }

            }



            return spisakZemalja.Count();
        }



        //3. ukupna uplata odredjenog igraca 


        public int ukupnaUplataOdredjenogIgraca(Igrac igrac)
        {
            int br = 0;

            foreach (Igrac i in listaIgraca)
            {
                if (i==igrac)
                {
                    br += i.Iznos;
                }

            }

            return br; 
        }

    }
}
