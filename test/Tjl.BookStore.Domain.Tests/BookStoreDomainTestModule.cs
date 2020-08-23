using Tjl.BookStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tjl.BookStore
{
    [DependsOn(
        typeof(BookStoreEntityFrameworkCoreTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}