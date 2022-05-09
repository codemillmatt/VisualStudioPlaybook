using Microsoft.AspNetCore.Mvc;
using VSPlaybook.Models;

namespace VSPlaybook.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPeople")]
        public IEnumerable<Person> Get()
        {
            return Enumerable.Range(1, 5).Select(index =>
            {
                return new Person { FirstName = "Matt", LastName = "Soucoup" };
            })
            .ToArray();
        }
    }
}