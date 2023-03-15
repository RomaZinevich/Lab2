using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_SOLID
{
    public class Reporting
    {
        private List<string> reports = new List<string>();

        public Reporting() { }

        public void AddReport(Warehouse warehouse, string action=null, int count=0)
        {
            if (action == "add" || action == "Add")
                reports.Add($"На склад доданто товар {warehouse.Product.Name} в кiлькостi {count} {warehouse.Units}");
            else if (action == "remove" || action == "Remove")
                reports.Add($"Зi складу було продано товар {warehouse.Product.Name} в кiлькостi {count} по цiнi {warehouse.Product.Price.Whole_part_maney},{warehouse.Product.Price.Coins} грн");
            else
                reports.Add($"На склад було завезено новий товар {warehouse.Product.Name} в кiлькостi {warehouse.Count} {warehouse.Units}");
        }

        public void PrintReport()
        {
            Console.WriteLine("Inventory Report");
            foreach(string report in reports)
            {
                Console.WriteLine(report);
            }
        }
       
    }
}
