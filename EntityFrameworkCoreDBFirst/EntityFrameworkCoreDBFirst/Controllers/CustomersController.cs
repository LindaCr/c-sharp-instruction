using EntityFrameworkCoreDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkCoreDBFirst.Controllers
{
    public class CustomersController
    {
        readonly AppDBContext _context;

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetById(int Id)
        {
            return _context.Customers.Find(Id);
        }

        public CustomersController()
        {
            _context = new AppDBContext();
        }


        public Customer Add(Customer customer)
        {
            if (customer == null)
            {
                return null;
            }
            _context.Customers.Add(customer);
            var rowsAffected= _context.SaveChanges();
            if (rowsAffected != 1)
            {
                return null;
            }
            return customer;
        }

        public bool Update(Customer customer)
        {
            if (customer == null)
            {
                return false;
            }
            _context.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var rc= _context.SaveChanges();
            if (rc!=1)
            {
                return false;
            }
            return true;
        }

        public Customer Delete(int Id)
        {
            var cust = _context.Customers.Find(Id);
            if (cust == null)
            {
                return null;
            }
            _context.Remove(cust);
            var rc = _context.SaveChanges();
            if (rc!=1)
            {
                return null;
            }
            return cust;
                
        }


    }
}
