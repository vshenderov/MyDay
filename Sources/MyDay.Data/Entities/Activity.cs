namespace MyDay.Data.Entities
{
    using System;

    public class Activity
    {
        public virtual int Id { get; set; }

        public virtual int PersonToolId { get; set; }

        public virtual DateTime Date { get; set; }

        public virtual string Content { get; set; }
    }
}
