using System.Threading.Tasks;

namespace Tjl.BookStore.Data
{
    public interface IBookStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
