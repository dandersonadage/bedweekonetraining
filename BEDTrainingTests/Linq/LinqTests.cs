using BEDTraining.Linq;
using BEDTrainingTests.Fixtures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BEDTrainingTests.Linq
{
    [TestFixture]
    public class LinqTests
    {
        [Test]
        [Category("Linq")]
        public void AnyTestPositive()
        {
            Assert.AreEqual(Any.AnyPersonWithFirstNameForLoop(People.PeopleList, "Dan"), Any.AnyPersonWithFirstNameLinq(People.PeopleList, "Dan"));
        }

        [Test]
        [Category("Linq")]
        public void AnyTestNegative()
        {
            Assert.AreEqual(Any.AnyPersonWithFirstNameForLoop(People.PeopleList, "George"), Any.AnyPersonWithFirstNameLinq(People.PeopleList, "George"));
        }

        [Test]
        [Category("Linq")]
        public void WhereTestPositive()
        {
            Assert.AreEqual(Where.WhereForLoop(People.PeopleList, "Dan").Count(), Where.WhereLinq(People.PeopleList, "Dan").Count());
        }

        [Test]
        [Category("Linq")]
        public void WhereTestNegative()
        {
            Assert.AreEqual(Where.WhereForLoop(People.PeopleList, "George").Count(), Where.WhereLinq(People.PeopleList, "George").Count());
        }

        [Test]
        [Category("Linq")]
        public void FirstOrDefaultTestPositive()
        {
            Assert.AreEqual(FirstOrDefault.FirstOrDefaultForLoop(People.PeopleList, "Dan")?.FirstName, FirstOrDefault.FirstOrDefaultLinq(People.PeopleList, "Dan")?.FirstName);
        }

        [Test]
        [Category("Linq")]
        public void FirstOrDefaultTestNegative()
        {
            Assert.AreEqual(FirstOrDefault.FirstOrDefaultForLoop(People.PeopleList, "George")?.FirstName, FirstOrDefault.FirstOrDefaultLinq(People.PeopleList, "George")?.FirstName);
        }
    }
}