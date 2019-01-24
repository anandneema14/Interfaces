using Common;
using People.Library;
using System;
using System.Collections.Generic;

namespace PeopleViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleRespository repository = new PeopleRespository();

            //Concrete Approach
            //This code needs to be change if the underlayingtype is changed
            Person[] people = repository.GetPeople();
            List<Person> p = new List<Person>();
            foreach (var person in people)
            {
                p.Add(person);
            }

            //Abstract Approach
            //This code will remain intact as far as our return type has IEnumerable implemented
            IEnumerable<Person> per = repository.GetPeople();
        }
    }
}
