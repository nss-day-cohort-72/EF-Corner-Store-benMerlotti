using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace CornerStore.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string ProductName { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public string Brand { get; set; }
    [Required]
    public int CategoryId { get; set; }

    // NAV PROPERTIES
    public Category Category { get; set; }
    public List<Order> Orders { get; set; }
}