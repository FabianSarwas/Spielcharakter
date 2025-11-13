using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spielcharakter.Model;

namespace Spielcharakter.View
{

    public class CharakterView
    {

        public void DisplayAction(string actionMessage)
        {
            Console.WriteLine(actionMessage);
        }

        public void DisplayCharakter(Basisklasse basisklasse)
        {
            Console.WriteLine($"Name: {basisklasse.Name}, " +
                              $"Lebenspunkte: {basisklasse.Lebenspunkte}, " +
                              $"Rüstung: {basisklasse.Ruestung}, " +
                              $"Heiltränke: {basisklasse.Heiltraenke}");
        }
    }
}
