using System.ComponentModel.DataAnnotations;

namespace PizzariaNET.Models;

public class Pizza
{
    [Key]
    public long Id { get; set; }
    public string Nome { get; set; } = String.Empty;
    public decimal Preco { get; set; }
    
}