using BEDTraining.Classes;
using System.Collections.Generic;
using System.Linq;

namespace BEDTraining.Linq
{
    public class Any
    {
        //
        public static bool? AnyPersonWithFirstNameForLoop(List<Person> people, string name)
        {
            foreach(var person in people)
            {
                if (person.FirstName == name)
                {
                    return true;
                }
            }
            return false;
        }

        //rewrite using linq syntax
        //Any Documentation: https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any?view=netframework-4.7.2
        public static bool? AnyPersonWithFirstNameLinq(List<Person> people, string name) => null; 
    }
}