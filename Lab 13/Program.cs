using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building("ул Рентгена", 20, 30, 20);
            Console.WriteLine(house.Info());
            
            MultiBuilding skyscraper = new MultiBuilding("ул Ленина", 40, 50, 60, 50);
            Console.WriteLine(skyscraper.Info());
            Console.ReadKey();
        }
    }
}
