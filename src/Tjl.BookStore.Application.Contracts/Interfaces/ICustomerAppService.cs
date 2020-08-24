using System;
using Tjl.BookStore.Dtos.Customer;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Tjl.BookStore.Interfaces
{
    public interface ICustomerAppService : ICrudAppService<
        CustomerDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateCustomerDto,
        CreateUpdateCustomerDto>
    {

    }
}