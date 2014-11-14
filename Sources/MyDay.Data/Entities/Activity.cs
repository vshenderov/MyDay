namespace MyDay.Data.Entities
{
    using System;

    public class Activity
    {
        public virtual int Id { get; set; }

        public virtual int PersonId { get; set; }

        public virtual int ToolId { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual string Title { get; set; }

        public virtual string Content { get; set; }
    }
}
