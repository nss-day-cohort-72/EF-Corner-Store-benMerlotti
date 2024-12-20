using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CornerStore.Models;

public class Cashier
{
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";

    // NAV PROPS
    public List<Order> Orders { get; set; } = new List<Order>();
}