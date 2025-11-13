using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielcharakter.Model
{
    public class Kriegerklasse : Basisklasse
    {

        public int Wut { get; set; }

        public Kriegerklasse(string name, int lebenspunkte, string ruestung, int heiltraenke, int wut)
            : base(name, lebenspunkte, ruestung, heiltraenke)
        {
            Wut = wut;
        }
    }
}