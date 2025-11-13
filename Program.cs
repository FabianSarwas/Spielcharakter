using System;
using Spielcharakter.Model;       
using Spielcharakter.View;        
using Spielcharakter.Controllers; 

namespace Spielcharakter          
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            var view = new CharakterView();

            
            var controller = new CharakterController(view);

            
            Basisklasse Abenteurer = new Basisklasse("Arthos", 100, "Leder", 3);
            Magierklasse zauberer = new Magierklasse("Gandalf", 80, "Stoff", 2, 120, 3);
            Kriegerklasse kaempfer = new Kriegerklasse("Olaf", 120, "Platte", 5, 50);

            
            controller.ShowCharakter(Abenteurer);
            controller.PerformAction(Abenteurer);
            Console.WriteLine();


            controller.ShowCharakter(zauberer);
            controller.PerformAction(zauberer);
            Console.WriteLine();

  
            controller.ShowCharakter(kaempfer);
            controller.PerformAction(kaempfer);
            Console.WriteLine();

            Console.WriteLine("Fertig – beliebige Taste zum Beenden...");
        }
    }
}