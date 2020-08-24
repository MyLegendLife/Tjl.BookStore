using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Tjl.BookStore.Customers;
using Tjl.BookStore.Dtos.Customer;
using Tjl.BookStore.Interfaces;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Tjl.BookStore.Services
{
    public class ACustomerAppService : ApplicationService, IACustomerAppService
    {
        private readonly IRepository<Customer, Guid> _repository;

        public ACustomerAppService(IRepository<Customer, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<List<CustomerDto>> GetAllAsync()
        {
            var list = await _repository.Where(c => true).ToListAsync();

            return list;
        }
    }
}