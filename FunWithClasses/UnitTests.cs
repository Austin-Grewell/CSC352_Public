using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace FunWithClasses
{

    [TestFixture]
    class UnitTests
    {
        [TestCase("ace", "Ace")]
        public void TestFirstNameProperty(string input, string expected)
        {
            //Arrange
            Person person = new Person();

            //Act
            person.FirstName = input;

            //Assert
            Assert.That(person.FirstName, Is.EqualTo(expected));
        }

        [TestCaseSource(typeof(EqualityTests))]
        public void TestEquality(Person a, Person b, bool expected)
        {
            bool actual = a.Equals(b);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestDictionary()
        {
            IEnumerable<Person> personToInsert =
                new Person[]
                {
                        new Person()
                    {
                        FirstName = "Ace",
                        LastName = "O",
                        BirthDate = new DateTime(1988, 03, 31)
                    },
                    new Person()
                    {
                        FirstName = "Ace",
                        LastName = "S",
                        BirthDate = new DateTime(1990, 03, 31)
                    }
                };

            Dictionary<Person, int> personDictionary = new Dictionary<Person, int>();

            foreach (Person person in personToInsert)
            {
                personDictionary.Add(person, 1);
            }

            bool containsPerson = personDictionary.ContainsKey(
                new Person()
                {
                    FirstName = "Ace",
                    LastName = "O",
                    BirthDate = new DateTime(1988, 03, 31)
                });

            Assert.IsTrue(containsPerson);
        }
    }

    internal class EqualityTests : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new TestCaseData(
                new Person()
                {
                    FirstName = "Ace",
                    LastName = "O",
                    BirthDate = new DateTime(1988, 03, 31)
                },
                new Person()
                {
                    FirstName = "Ace",
                    LastName = "S",
                    BirthDate = new DateTime(1990, 03, 31)
                },
                false);

            yield return new TestCaseData(
                new Person()
                {
                    FirstName = "Ace",
                    LastName = "O",
                    BirthDate = new DateTime(1988, 03, 31)
                },
                new Person()
                {
                    FirstName = "Ace",
                    LastName = "O",
                    BirthDate = new DateTime(1988, 03, 31)
                },
                true);
        }
    }
}
