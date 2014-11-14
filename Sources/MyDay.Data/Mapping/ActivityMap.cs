namespace MyDay.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using MyDay.Data.Entities;

    public sealed class ActivityMap : ClassMap<Activity>
    {
        public ActivityMap()
        {
            this.Table("Activity");
            this.Id(x => x.Id).GeneratedBy.Identity();
            this.Map(x => x.PersonId).Not.Nullable();
            this.Map(x => x.ToolId).Not.Nullable();
            this.Map(x => x.Date).Not.Nullable();
            this.Map(x => x.Content).Length(10000).Not.Nullable();
        }
    }
}
