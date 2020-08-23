using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;

namespace Tjl.BookStore.Customers
{
    public class CustomerDto : EntityDto, IHasCreationTime
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string ConnStringName { get; set; }

        public string Ket { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
    }
}