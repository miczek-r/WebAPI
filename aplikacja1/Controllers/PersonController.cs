using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aplikacja1.Models;
using Microsoft.AspNetCore.Mvc;

namespace aplikacja1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        [HttpGet]
        public IList<Person> Index()
        {
            PersonContext context = HttpContext.RequestServices.GetService(typeof(aplikacja1.Models.PersonContext)) as PersonContext;

            return context.GetAllPerson();
        }
        [HttpGet("{id}")]
        public Person GetPerson(int id)
        {
            PersonContext context = HttpContext.RequestServices.GetService(typeof(aplikacja1.Models.PersonContext)) as PersonContext;

            return context.GetPerson(id);
        }
        [HttpPut]
        public void UpdatePerson(Person person)
        {
            PersonContext context = HttpContext.RequestServices.GetService(typeof(aplikacja1.Models.PersonContext)) as PersonContext;
            context.UpdatePerson(person);
        }
        [HttpPost]
        public void AddPerson(Person person)
        {
            PersonContext context = HttpContext.RequestServices.GetService(typeof(aplikacja1.Models.PersonContext)) as PersonContext;
            context.AddPerson(person);
        }
        [HttpDelete("{id}")]
        public void DeletePerson(int id)
        {
            PersonContext context = HttpContext.RequestServices.GetService(typeof(aplikacja1.Models.PersonContext)) as PersonContext;
            context.DeletePerson(id);
        }

    }
}
