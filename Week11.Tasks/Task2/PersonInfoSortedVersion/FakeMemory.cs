using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfoSortedVersion
{
     class FakeMemory
    {
        private static readonly List<Person> People;

        static FakeMemory()
        {
            People = new List<Person>();
        }

        public static List<Person> FetchPeople()
        {
            for (int i = 1; i < 1000; i++)
            {
                Person person = new Person
                {
                    Id = i,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Country = FakeData.PlaceData.GetCountry(),
                    City = FakeData.PlaceData.GetCity(),
                    Phone = FakeData.PhoneNumberData.GetPhoneNumber(),
                    Birthdate = FakeData.DateTimeData.GetDatetime(new DateTime(1960, 12, 12), new DateTime(2020, 12, 12)),
                    Profession = FakeData.NameData.GetCompanyName()
                };

                person.Email = $"{person.Name}.{person.Surname}@{FakeData.NetworkData.GetDomain()}";
                People.Add(person);
            }
            return People;
        }
    }
}
