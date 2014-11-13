namespace MyDay.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using MyDay.Data.Base;
    using MyDay.Data.IO;

    public class Database
    {
        public class Person : BaseTable<Entities.Person>
        {
            public static List<PersonDto> GetPersons()
            {
                return Select().Select(ConvertToPersonDto).ToList();
            }

            private static PersonDto ConvertToPersonDto(Entities.Person entity)
            {
                var dto = new PersonDto()
                              {
                                  Name = entity.Name,
                                  Email = entity.Email,
                              };

                return dto;
            }
        }
    }
}
