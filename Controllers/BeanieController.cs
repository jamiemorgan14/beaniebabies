using System.Collections.Generic;
using beaniebabies.Models;
using Microsoft.AspNetCore.Mvc;
using beaniebabies.DataBase;

namespace beaniebabies.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class BeanieController : ControllerBase
  {
    //Never do this again
    List<BeanieBaby> Inventory = Data.Inventory;
    //Get all beanies
    [HttpGet]
    public ActionResult<List<BeanieBaby>> Get()
    {
      return Inventory;
    }

    [HttpGet("{id}")]
    public ActionResult<BeanieBaby> GetById(int id)
    {
      BeanieBaby found = Inventory.Find(b => b.Id == id);
      if (found != null)
      {
        return found;
      }
      return NotFound("Not Found");
    }

    [HttpPost]
    public ActionResult<List<BeanieBaby>> Post([FromBody] BeanieBaby value)
    {
      Inventory.Add(value);
      return Inventory;
    }
    [HttpPut("{id}")]
    public ActionResult<BeanieBaby> Put(int id, [FromBody] BeanieBaby newData)
    {
      BeanieBaby oldData = Inventory.Find(b => b.Id == id);
      if (oldData == null) { return BadRequest(); }
      Inventory.Remove(oldData);
      Inventory.Add(newData);
      return newData;
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      BeanieBaby oldData = Inventory.Find(b => b.Id == id);
      if (oldData == null) { return BadRequest(); }
      Inventory.Remove(oldData);
      return Ok();
    }

  }


}