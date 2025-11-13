using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spielcharakter.Model
{
    //Basisklasse
    public class Basisklasse
    {

        public string Name { get; set; }
        public int Lebenspunkte { get; set; }
        public string Ruestung { get; set; }
        public int Heiltraenke { get; set; }
        public Basisklasse(string name, int lebenspunkte, string ruestung, int heiltraenke)
        {
            Name = name;
            Lebenspunkte = lebenspunkte;
            Ruestung = ruestung;
            Heiltraenke = heiltraenke;
        }
        public virtual string Action()
            {
            return $"Der Charakter {Name} führt eine allgemeine Aktion aus.";
            }
        }
    }

