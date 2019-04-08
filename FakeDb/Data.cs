using System.Collections.Generic;
using beaniebabies.Models;

namespace beaniebabies.DataBase
{

  public static class Data
  {
    public static List<BeanieBaby> Inventory = new List<BeanieBaby>()
    {
      new BeanieBaby(20193, "John Snow", "#Adorable, #KnowsNothing", 5.84m),
      new BeanieBaby(22312, "White Rabbit", "Follow him!!!!", 6.78m),
      new BeanieBaby(43214, "Rubble", "He'll be there on the double! No job to big no pup too small.", 12.59m)
    };
  }
}