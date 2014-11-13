namespace MyDay.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using MyDay.Data.Entities;

    public sealed class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            this.Table("Person");
            this.Id(x => x.Id).GeneratedBy.Identity();
            this.Map(x => x.Name).Length(255).Not.Nullable();
            this.Map(x => x.Email).Length(255).Not.Nullable();
        }
    }
}
