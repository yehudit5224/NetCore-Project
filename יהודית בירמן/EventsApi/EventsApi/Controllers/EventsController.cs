using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public static List<Event> Events=new List<Event> { new Event {  Id = 1,  Title ="Brit", Start=new DateTime(), End=new DateTime() },
                                                           new Event{ Id=2,Title="Bar-Mitzva",Start=new DateTime(),End=new DateTime()} };
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return Events;
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return Events.Find(e=>e.Id==id);
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Event value)
        {
            Events.Add(value);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event value)
        {
            var i=Events.FindIndex(e=>e.Id==id);
            Events[i].Title = value.Title;
            Events[i].Start = value.Start;
            Events[i].End = value.End;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Events.Remove(Events.Find(e=>e.Id==id));
        }
    }
}
