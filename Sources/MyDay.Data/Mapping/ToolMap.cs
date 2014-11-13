namespace MyDay.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using MyDay.Data.Entities;

    public sealed class ToolMap : ClassMap<Tool>
    {
        public ToolMap()
        {
            this.Table("Tool");
            this.Id(x => x.Id).GeneratedBy.Identity();
            this.Map(x => x.Name).Length(255).Not.Nullable();
        }
    }
}
