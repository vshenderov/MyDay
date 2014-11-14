namespace MyDay.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using MyDay.Data.Entities;

    public sealed class PersonToolMap : ClassMap<PersonTool>
    {
        public PersonToolMap()
        {
            this.Table("PersonTool");
            this.Id(x => x.Id).GeneratedBy.Identity();
            this.Map(x => x.ToolId).Not.Nullable();
            this.Map(x => x.PersonId).Not.Nullable();
            this.Map(x => x.Account).Length(255).Not.Nullable();
        }
    }
}
