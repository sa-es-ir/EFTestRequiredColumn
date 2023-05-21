using System.ComponentModel.DataAnnotations;

namespace EFTestRequiredColumn;

public class Customer
{
    [Key]
    public long CustomerKey { get; set; }

    [Required]
    [MaxLength(20)]
    public string CustomerId { get; set; }
}
