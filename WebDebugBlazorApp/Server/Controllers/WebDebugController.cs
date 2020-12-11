
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDebugBlazorApp.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebDebugBlazorApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebDebugController : ControllerBase
    {
        private readonly IHubContext<WebDebugHub> _hubContext;
        public WebDebugController(IHubContext<WebDebugHub> hubContext)
        {
            _hubContext = hubContext;
        }
        // GET: api/<WebDebugController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WebDebugController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WebDebugController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
             _hubContext.Clients.All.SendAsync("ReceiveMessage", value,value);
        }

        // PUT api/<WebDebugController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WebDebugController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
