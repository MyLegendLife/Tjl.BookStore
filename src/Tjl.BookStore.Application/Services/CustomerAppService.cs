using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tjl.BookStore.Customers;
using Tjl.BookStore.Dtos.Customer;
using Tjl.BookStore.Interfaces;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Tjl.BookStore.Services
{
    public class CustomerAppService : CrudAppService<
        Customer,
        CustomerDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerDto,
        CreateUpdateCustomerDto>,
        ICustomerAppService
    {
        public CustomerAppService(IRepository<Customer, Guid> repository)
            : base(repository)
        {

        }
    }
}