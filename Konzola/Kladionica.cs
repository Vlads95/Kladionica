using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteka;
namespace Konzola
{
    class Kladionica
    {


        String takmicenje;
        List<UplatnoMesto> spisakUplatnih;

        public Kladionica(String takmicenje )
        {
            this.takmicenje = takmicenje;
            spisakUplatnih = new List<UplatnoMesto>();
        }

        public string Takmicenje { get => takmicenje; set => takmicenje = value; }
        public List<UplatnoMesto> SpisakUplatnih { get => spisakUplatnih; set => spisakUplatnih = value; }

        static void Main(string[] args)
        {
        }
    }
}
