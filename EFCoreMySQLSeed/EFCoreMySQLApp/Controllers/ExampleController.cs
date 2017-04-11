﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCoreMySQLContext.Models;
using EFCoreMySQLContext.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCoreMySQLApp.Controllers
{
    [Route("api/[controller]")]
    public class ExampleController : Controller
    {
        BaseContext db = BaseContext.Connect(Constants.ConnectionString);

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var example = db.Example;
            return Ok(example);

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
