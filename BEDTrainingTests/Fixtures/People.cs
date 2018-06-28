using BEDTraining.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEDTrainingTests.Fixtures
{
    public class People
    {
        public static List<Person> PeopleList => new List<Person>()
        {
            new Person() { FirstName = "Dan", LastName = "Anderson" },
            new Person() { FirstName = "Jess", LastName = "Brown" },
            new Person() { FirstName = "Drew", LastName = "Smith" },
            new Person() { FirstName = "Spencer", LastName = "Rudnick" },
            new Person() { FirstName = "Watson", LastName = "Zhou" },
            new Person() { FirstName = "Jeff", LastName = "Kolb" }
        };
    }
}