namespace Hosein_Amini_hw08_Maktab71.Models
{
    public class PersonRepository
    {
        private static List<PersonModel> personList = new()
        {
            new PersonModel() { PersonId = Guid.NewGuid(), PersonFirstName = "حسین", PersonLastName = "امینی", PersonDateOfBirth = new DateTime(1997, 5, 6), PersonPhoneNumber = "+989152204349" },
            new PersonModel() { PersonId = Guid.NewGuid(), PersonFirstName = "علی", PersonLastName = "امیری", PersonDateOfBirth = new DateTime(1990, 5, 6), PersonPhoneNumber = "+989152424349" },
            new PersonModel() { PersonId = Guid.NewGuid(), PersonFirstName = "مهدی", PersonLastName = "طاهری", PersonDateOfBirth = new DateTime(1987, 5, 6), PersonPhoneNumber = "+989153204349" },
            new PersonModel() { PersonId = Guid.NewGuid(), PersonFirstName = "جواد", PersonLastName = "امینی", PersonDateOfBirth = new DateTime(1597, 5, 6), PersonPhoneNumber = "+989155204349" },
            new PersonModel() { PersonId = Guid.NewGuid(), PersonFirstName = "پوجا", PersonLastName = "اصلانی", PersonDateOfBirth = new DateTime(1097, 5, 6), PersonPhoneNumber = "+989159204349" }
        };


        public static List<PersonModel> GetAllPerson()
        {
            return personList;
        }
        public static bool Delete(Guid id)
        {
            var person = personList.FirstOrDefault(x=>x.PersonId==id);
            return personList.Remove(person);
        }
        public static PersonModel GetById(Guid id)
        {
            return personList.SingleOrDefault(t => t.PersonId == id);
        }
        public static void Edit(PersonModel person)
        {
            var index = personList.FindIndex(x => x.PersonId == person.PersonId);
            personList[index] = person;
        }
    }
}
