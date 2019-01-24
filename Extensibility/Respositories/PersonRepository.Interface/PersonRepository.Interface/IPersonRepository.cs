﻿using System;
using System.Collections.Generic;

namespace PersonRepository.Interface
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson();

        void AddPerson(Person newPerson);

        void UpdatePerson(int id, Person updatedPerson);

        void DeletePerson(int id);
    }
}