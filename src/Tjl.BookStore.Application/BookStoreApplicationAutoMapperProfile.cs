using AutoMapper;
using JetBrains.Annotations;
using Tjl.BookStore.Customers;
using Tjl.BookStore.Dtos.Customer;

namespace Tjl.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Customer, CustomerDto>();
            CreateMap<CreateUpdateCustomerDto, Customer>();
        }
    }
}
