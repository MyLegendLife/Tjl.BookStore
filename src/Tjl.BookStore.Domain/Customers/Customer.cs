using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace Tjl.BookStore.Customers
{
    public class Customer : Entity<Guid>, IHasCreationTime
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string ConnStringName { get; set; }

        public string Ket { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }

        //public List<AppUser> Users { get; protected set; }

        protected Customer()
        {

        }

        public Customer(
            Guid id,
            [NotNull] string code,
            [NotNull] string name,
            [NotNull] string connStringName,
            string ket,
            string description)
        : base(id)
        {
            Id = id;
            Code = Check.NotNullOrWhiteSpace(code, nameof(code));
            Name = Check.NotNullOrWhiteSpace(name, nameof(name));
            ConnStringName = Check.NotNullOrWhiteSpace(connStringName, nameof(connStringName));
            Ket = ket;
            Description = description;
            //Users = new List<AppUser>();
        }

        //public void AddUser(AppUser user)
        //{
        //    if (Users.Any(u => u.Id == user.Id))
        //    {
        //        return;
        //    }
        //    Users.Add(user);
        //}
    }
}