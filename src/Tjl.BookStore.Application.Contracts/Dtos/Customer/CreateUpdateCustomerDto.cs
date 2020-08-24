using System.ComponentModel.DataAnnotations;

namespace Tjl.BookStore.Dtos.Customer
{
    public class CreateUpdateCustomerDto
    {
        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string ConnStringName { get; set; }

        public string Ket { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
