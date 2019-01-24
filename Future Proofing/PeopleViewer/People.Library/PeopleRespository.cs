using Common;
using System;
using System.Collections.Generic;

namespace People.Library
{
    public class PeopleRespository
    {
        public Person[] GetPeople()
        {
            List<Person> persons = new List<Person>();
            return persons.ToArray();
        }

        public Person GetPerson(int id)
        {
            Person p = new Person();
            return p;
        }
    }
}
