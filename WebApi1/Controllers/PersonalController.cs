using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi1.Models;

namespace WebApi1.Controllers
{
    public class PersonalController : ApiController
    {
        [HttpGet]
        public List<Personal> Personals()
        {
            return PersonalList.pers;
        }
        public Personal GetPersonal(int id)
        {
            Personal ishci = PersonalList.pers.Find(o => o.id == id);
            return ishci;
        }
    }
}
