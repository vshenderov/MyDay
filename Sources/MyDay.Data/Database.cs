namespace MyDay.Data
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using FluentNHibernate.Utils;

    using MyDay.Data.Base;
    using MyDay.Data.Config;
    using MyDay.Data.IO;
    using NHibernate;
    using NHibernate.Criterion;

    public class Database
    {
        private static ISession Session
        {
            get
            {
                var session = NHibernateHelper.CurrentSession;
                return session;
            }
        }

        public class Activity : BaseTable<Entities.Activity>
        {
            public static List<Entities.Activity> GetActivities(int personId)
            {
                return Session.CreateCriteria(typeof(Entities.Activity))
                    .Add(Restrictions.Eq(Projections.Property<Entities.Activity>(x => x.PersonId), personId))
                                            .List<Entities.Activity>()
                        .ToList();
            }
        }

        public class PersonTool : BaseTable<Entities.PersonTool>
        {
            public static Entities.PersonTool GetPersonToolByAccount(Entities.Tool tool, string account)
            {
                if (tool != null && !string.IsNullOrEmpty(account))
                {
                    var pt = Session.CreateCriteria(typeof(Entities.PersonTool))
                    .Add(Restrictions.Eq(Projections.Property<Entities.PersonTool>(x => x.ToolId), tool.Id))
                    .Add(Restrictions.Eq(Projections.Property<Entities.PersonTool>(x => x.Account), account))
                    .UniqueResult<Entities.PersonTool>();

                    if (pt != null)
                    {
                        return pt;
                    }
                }

                return null;
            }

            public static List<string> GetLoginsByTool(Entities.Tool tool)
            {
                var result = new List<string>();
                if (tool != null)
                {
                    var personTools = Session.CreateCriteria(typeof(Entities.PersonTool))
                        .Add(Restrictions.Eq(Projections.Property<Entities.PersonTool>(x => x.ToolId), tool.Id))
                        .List<Entities.PersonTool>()
                        .ToList();

                    if (personTools != null)
                    {
                        foreach (var pt in personTools)
                        {
                            result.Add(pt.Account);
                        }
                    }
                }

                return result;
            }
        }

        public class Tool : BaseTable<Entities.Tool>
        {
            public static Entities.Tool GetToolByName(string name)
            {
                if (string.IsNullOrEmpty(name))
                {
                    return null;
                }

                return Session.CreateCriteria(typeof(Entities.Tool))
                    .Add(Restrictions.Eq(Projections.Property<Entities.Tool>(x => x.Name), name))
                    .UniqueResult<Entities.Tool>();
            }
        }

        public class Person : BaseTable<Entities.Person>
        {
            public static List<PersonDto> GetPersons()
            {
                return Select().Select(ConvertToPersonDto).ToList();
            }

            private static PersonDto ConvertToPersonDto(Entities.Person entity)
            {
                var dto = new PersonDto
                              {
                                  Id = entity.Id,
                                  Name = entity.Name,
                                  Email = entity.Email,
                              };

                return dto;
            }
        }
    }
}
