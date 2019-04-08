//list of itemId's
//dictionary of id and quantity

using System.Collections.Generic;

namespace beaniebabies.Models
{
  public class Order
  {
    public int Id { get; set; }
    public List<LineItem> Invoice { get; set; } = new List<LineItem>();
  }
}
