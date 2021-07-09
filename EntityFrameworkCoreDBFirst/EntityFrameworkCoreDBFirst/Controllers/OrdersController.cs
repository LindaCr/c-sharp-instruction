using EntityFrameworkCoreDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkCoreDBFirst.Controllers
{
    public class OrdersController
    {
        readonly AppDBContext _context;

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Order GetById(int Id)
        {
            return _context.Orders.Find(Id);
        }

        public Order Add(Order order)
        {
            if (order == null)
            {
                return null;
            }
            _context.Orders.Add(order);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                return null;
            }
            return order;
        }

        public bool Update(Order order)
        {
            if (order == null)
            {
                return false;
            }
            _context.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rc = _context.SaveChanges();
            if (rc != 1)
            {
                return false;
            }
            return true;
        }

        public Order Delete(int Id)
        {
            var ord = _context.Orders.Find(Id);
            if (ord == null)
            {
                return null;
            }
            _context.Remove(ord);
            var rc = _context.SaveChanges();
            if (rc != 1)
            {
                return null;
            }
            return ord;

        }



        public OrdersController()
        {
            _context = new AppDBContext();
        }


    }
}
