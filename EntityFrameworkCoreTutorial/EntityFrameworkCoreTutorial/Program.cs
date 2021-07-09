using System;
using System.Linq;
using EntityFrameworkCoreTutorial.Models;

namespace EntityFrameworkCoreTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            var _context = new salesdbContext();


            //method syntax in linq
            var customers = _context.Customers
                            .Where(c => c.City=="Cincinnati" && c.Sales>=50000)
                            .OrderByDescending(c => c.Name)
                            .ToList();

            foreach (var c in customers)
            {
                Console.WriteLine($"{c.Name} | {c.City} | {c.Sales}");
            }


            //query syntax in linq
            var customers2 = from c in _context.Customers
                             where c.City.Equals("Cincinnati") && c.Sales >= 50000
                             orderby c.Name descending
                             select c;



            foreach(var c in customers2)
            {
                Console.WriteLine($"{c.Name} | {c.City} | {c.Sales}");
            }


            //join in query syntax in linq
            var custOrders = from o in _context.Orders
                             join c in _context.Customers
                             on o.CustomerId equals c.Id
                             select new
                             {
                                 o,
                                 c.Name
                             };

            foreach(var oc in custOrders)
            {
                Console.WriteLine($"{oc.o.Description} | {oc.Name}");
            }
        }
    }
}
