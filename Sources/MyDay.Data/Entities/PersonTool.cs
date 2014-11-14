namespace MyDay.Data.Entities
{
    public class PersonTool
    {
        public virtual int Id { get; set; }

        public virtual int ToolId { get; set; }

        public virtual int PersonId { get; set; }

        public virtual string Account { get; set; }
    }
}
