using EntityFrameworkCoreDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkCoreDBFirst.Controllers
{
    public class OrderlinesController
    {

        readonly AppDBContext _context;

        public List<Orderline> GetAll()
        {
            return _context.Orderlines.ToList();
        }

        public Orderline GetById(int Id)
        {
            return _context.Orderlines.Find(Id);
        }

        public Orderline Add(Orderline orderline)
        {
            if (orderline == null)
            {
                return null;
            }
            _context.Orderlines.Add(orderline);
            var rowsAffected = _context.SaveChanges();
            if (rowsAffected != 1)
            {
                return null;
            }
            return orderline;
        }

        public bool Update(Orderline orderline)
        {
            if (orderline == null)
            {
                return false;
            }
            _context.Entry(orderline).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rc = _context.SaveChanges();
            if (rc != 1)
            {
                return false;
            }
            return true;
        }

        public Orderline Delete(int Id)
        {
            var ordline = _context.Orderlines.Find(Id);
            if (ordline == null)
            {
                return null;
            }
            _context.Remove(ordline);
            var rc = _context.SaveChanges();
            if (rc != 1)
            {
                return null;
            }
            return ordline;

        }

       // public Orderline CalculateTotal(decimal Price, int Quantity)
       // {
        //    var total = Price * Quantity;
        //    total = _context.SaveChanges();
        //    return 
       // }


        public OrderlinesController()
        {
            _context = new AppDBContext();
        }


    }
}
