using System.ComponentModel.DataAnnotations;

namespace beaniebabies.Models
{
  public class BeanieBaby
  {
    [Required]
    [Range(1, 1999999)]
    public int Id { get; set; }
    [Required]
    [MinLength(4)]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }

    public decimal Price { get; set; }
    public BeanieBaby(int id, string name, string description, decimal price)
    {
      Id = id;
      Name = name;
      Description = description;
      Price = price;
    }
  }

}