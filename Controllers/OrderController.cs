using beaniebabies.Models;
using Microsoft.AspNetCore.Mvc;

namespace beaniebabies.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class OrderController : ControllerBase
  {
    [HttpPost]
    public ActionResult<Receipt> NewOrder([FromBody] Order order)
    //beckend check inventory blah blah blah
    {
      return new Receipt(order);

    }
  }
}