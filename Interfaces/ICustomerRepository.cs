using System;
using System.Collections.Generic;
using Movie.Models;

namespace Movie.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> ListAll();

        void Add(Customer customer);
    }
}
