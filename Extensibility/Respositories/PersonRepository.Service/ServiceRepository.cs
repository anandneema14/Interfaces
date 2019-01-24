using Newtonsoft.Json;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Net;

namespace PersonRepository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        WebClient client = new WebClient();
        string baseURI = "http://localhost:63269/api/Values/";

        public void AddPerson(Person newPerson)
        {
            
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            string result = client.DownloadString(baseURI + "Get");
            IEnumerable<Person> people = JsonConvert.DeserializeObject<IEnumerable<Person>>(result);
            return people;
        }

        public Person GetPerson()
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
