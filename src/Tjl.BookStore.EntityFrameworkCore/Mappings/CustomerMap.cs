using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tjl.BookStore.BookStore.Customer;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Tjl.BookStore.Mappings
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(BookStoreConsts.DbTablePrefix + "Customers");

            builder.ConfigureByConvention();

            builder.Property(x => x.Code).IsRequired().HasMaxLength(20);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.Property(x => x.ConnStringName).IsRequired().HasMaxLength(500);

            builder.Property(x => x.Ket).IsRequired().HasMaxLength(20);

            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
        }
    }
}