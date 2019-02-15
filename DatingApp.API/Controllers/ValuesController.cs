using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        readonly DataContext _context;

        #region Properties

        DataContext Context { get; }
        #endregion

        #region Constructors
        public ValuesController(DataContext context)
        {
            Context = context;
        }
        #endregion

        #region REST Conventions
        // GET api/values
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await Context.Values.FirstOrDefaultAsync(v => v.Id == id);
            return Ok(value);
        }

        // GET api/values/5
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GeValues()
        {
            var values = await Context.Values.ToListAsync();
            return Ok(values);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
        #endregion
        
    }
}
