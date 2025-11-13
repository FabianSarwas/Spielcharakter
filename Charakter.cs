using System;

namespace SpielcharakterMVC
{
    //Basisklasse
    public class Charakter
    {

        public string Name { get; set; }
        public int Lebenspunkte { get; set; }

        public string Ruestung { get; set; }

        public int Heiltraenke { get; set; }

        public Charakter(string name, int lebenspunkte, string ruestung, int heiltraenke)
        {
            Name = name; 
            Lebenspunkte = lebenspunkte; 
            Ruestung = ruestung; 
            Heiltraenke = heiltraenke;
            Hallo= hallo;
        }
        public virtual void Action()
        {
            Console.WriteLine($"Der Charakter {Name} führt eine allgemeine Aktion aus.");
        }
    }

    //Unterklasse
    public class Magier : Charakter
    {
        public int Mana { get; set; }
        public int Manatraenke { get; set; }

        public Magier(string name, int lebenspunkte, string ruestung, int heiltraenke, int mana, int manatraenke)
        : base(name, lebenspunkte, ruestung, heiltraenke)
        {
            Mana = mana;
            Manatraenke = manatraenke;
        }
        public override void Action()
        {
            Console.WriteLine($"Der Magier {Name} wirkt einen Feuerball!");
        }
    }
    public class Krieger : Charakter
    {
        public int Wut { get; set; }

        public Krieger(string name, int lebenspunkte, string ruestung, int heiltraenke, int wut)
        : base(name, lebenspunkte, ruestung, heiltraenke)
        {
            Wut = wut;
        }
        public override void Action()
        {
            Console.WriteLine($"Der Krieger {Name} schläft noch...!");
        }
    }

}

