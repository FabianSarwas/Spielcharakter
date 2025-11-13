using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielcharakter.Model
{
    public class Magierklasse : Basisklasse
    {

        public int Mana { get; set; }

        public int Manatraenke { get; set; }

        public Magierklasse(string name, int lebenspunkte, string ruestung, int heiltraenke, int mana, int manatraenke)
            : base(name, lebenspunkte, ruestung, heiltraenke)
        {
            Mana = mana;
            Manatraenke = manatraenke;
        }
    }
}