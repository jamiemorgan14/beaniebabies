﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beaniebabies.Models;
using Microsoft.AspNetCore.Mvc;

namespace beaniebabies.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return new string[] { "value1", "value2", "value3" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      ActionResult<string> res = new ActionResult<string>("response");
      return "value";
    }

    // POST api/values
    [HttpPost]
    public ActionResult<BeanieBaby> Post([FromBody] BeanieBaby value)
    {
      return value;
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
