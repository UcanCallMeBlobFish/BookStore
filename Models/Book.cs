using System.ComponentModel.DataAnnotations;

namespace bookstore.Models;

public class Book
{
    [Required] public string Name { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public int Capacity { get; set; }
    public int Price { get; set; }
}