using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tjl.BookStore.Dtos.Customer;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Tjl.BookStore.Interfaces
{
    public interface IACustomerAppService : IApplicationService
    {
        Task<List<CustomerDto>> GetAllAsync();
    }
}