using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Interfaces;
using Movie.Models;


namespace Movie.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        
        private readonly ICustomerRepository _repository;

        public CustomersController(ICustomerRepository repository) 
        {
            _repository = repository;
        }


        public IEnumerable<Customer> Get()
        {
            PopilateCustomerIfNoneExist();

            return  _repository.ListAll();
        }

        private void PopilateCustomerIfNoneExist()
        {
            if (!_repository.ListAll().Any())
            {
                _repository.Add(new Customer() { Name = "Customer1" });
                _repository.Add(new Customer() { Name = "Customer2" });
                _repository.Add(new Customer() { Name = "Customer3" });

            }
        }


    }
}
