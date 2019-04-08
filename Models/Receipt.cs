

//list itemId & total for that item
//int total

using System.Collections.Generic;

namespace beaniebabies.Models
{
  public class Receipt
  {
    public Dictionary<int, decimal> ItemTotals { get; set; }
    public decimal Total { get; set; }


    public Receipt(Order order)
    {
      Total = 0;
      ItemTotals = new Dictionary<int, decimal>();
      foreach (var lineItem in order.Invoice)
      {
        var bb = DataBase.Data.Inventory.Find(b => b.Id == lineItem.Id);
        if (bb == null) continue;
        decimal subTotal = lineItem.Quantity;
        Total += subTotal;
        ItemTotals.Add(bb.Id, subTotal);
      }
    }
  }
}