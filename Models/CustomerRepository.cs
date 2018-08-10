using System;
using System.Collections.Generic;
using System.Linq;
using Movie.Interfaces;

namespace Movie.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Customer> ListAll()
        {
            return _dbContext.Customers.AsEnumerable();
        }

        public void Add(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }
    }
}
