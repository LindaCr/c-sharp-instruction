using EntityFrameworkCoreDBFirst.Controllers;
using EntityFrameworkCoreDBFirst.Models;
using System;
using System.Linq;

namespace EntityFrameworkCoreDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var _context = new AppDBContext();

            //print out list of customers
            // foreach(var c in _context.Customers.ToList())
            //{
            //    Console.WriteLine($"{c.Id} | {c.Name} | {c.Sales} | {c.State}");
            // }

            // var custCtrl = new CustomersController();

            //get all
            // var customers = custCtrl.GetAll();

            // foreach(var c in customers)
            //{
            //   Console.WriteLine($"{c.Id} | {c.Name} | {c.Sales} | {c.State}");
            // }


            //get by id
            //var cust = custCtrl.GetById();
            // Console.WriteLine($"{cust.Id} | {cust.Name} | {cust.Sales} | {cust.State}");


            //add method
            //var newCust = new Customer()
            // {
            //   Id = 0,
            //   Name = "Meijer",
            //   State = "Minnesota",
            //   Sales = 1000000,
            //   Active = true
            // };
            // var rc = custCtrl.Add(newCust);


            //update
            // var cust1 = custCtrl.GetById(4);
            //cust1.Sales = 99999;
            // var rc = custCtrl.Update(cust1);
            // cust1 = custCtrl.GetById(4);
            // Console.WriteLine($"{cust1.Id} | {cust1.Name} | {cust1.Sales} | {cust1.State}");
            // var rmCust = custCtrl.Delete(cust.Id);
            //Console.WriteLine($"Deleted {rmCust.Id} | {rmCust.Name} | {rmCust.Sales} | {rmCust.State}");


            var ordCtrl = new OrdersController();

            var orders = ordCtrl.GetAll();
            foreach (var o in orders)
            {
                Console.WriteLine($"{o.Id}, {o.CustomerId}, {o.Date}, {o.Description}");
            }


            var order = ordCtrl.GetById(1);
            Console.WriteLine($"{order.Id}, {order.CustomerId}, {order.Date}, {order.Description}");


           // var newOrder = new Order()
           // {
            //    Id = 0,
            //    CustomerId = 3,
            //    Date = (2021 / 07 / 07),
            //    Description = "lots of things"
           // };
           // var rc = ordCtrl.Add(newOrder);

            var order1 = ordCtrl.GetById(1);
            order1.Description = "need new stuff";
            var rc1 = ordCtrl.Update(order1);

            var rmOrder = ordCtrl.Delete(order.Id);



        }
        
    }
}
