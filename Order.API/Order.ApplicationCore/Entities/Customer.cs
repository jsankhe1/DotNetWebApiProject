using System.ComponentModel.DataAnnotations.Schema;

namespace Order.ApplicationCore.Entities;

public class Customer
{
    public int Id { get; set; }
    [Column (TypeName = "varchar(50)")]public string? Name { get; set; }
    public string? Address { get; set; }
    
    //Navigation Propertie
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}