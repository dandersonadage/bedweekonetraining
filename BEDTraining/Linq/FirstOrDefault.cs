using BEDTraining.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEDTraining.Linq
{
    public class FirstOrDefault
    {
        public static Person FirstOrDefaultForLoop(List<Person> people, string firstName)
        {
            foreach (Person person in people)
            {
                if (person.FirstName == firstName)
                {
                    return person;
                }
            }
            return null;
        }

        //first or default documentation: https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault?view=netframework-4.7.2
        public static Person FirstOrDefaultLinq(List<Person> people, string firstName) => new Person() { FirstName = "" };
    }
}