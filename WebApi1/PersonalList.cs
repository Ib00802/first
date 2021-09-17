using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi1.Models;

namespace WebApi1
{
    public class PersonalList
    {
        public static List<Personal> pers = new List<Personal>
    {
        new Personal
        {id=1000,
            name="Ferid",
            surname="Hesenov",
            birth_place="Goranboy",
            age=20,
            salary=1500

        },
        new Personal
        {   id=1001,
            name="Ehtiram",
            surname="Osmanov",
            birth_place="Qazax",
            age=32,
            salary=1800

        },
        new Personal
        {
            id=1002,
            name="Rehime",
            surname="Ehmedova",
            birth_place="Baku",
            age=20,
            salary=2000
        }
    };
   }
}