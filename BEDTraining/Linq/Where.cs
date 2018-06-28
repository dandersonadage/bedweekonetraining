using BEDTraining.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEDTraining.Linq
{
    public class Where
    {
        public static IEnumerable<Person> WhereForLoop(List<Person> people, string firstName)
        {
            List<Person> ret = new List<Person>();
            foreach(Person person in people)
            {
                if (person.FirstName == firstName)
                {
                    ret.Add(person);
                }
            }
            return ret;
        }

        //Create same function as above using linq where function
        //https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=netframework-4.7.2
        public static IEnumerable<Person> WhereLinq(List<Person> people, string firstName) => null;
    }
}