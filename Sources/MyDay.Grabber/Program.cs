namespace MyDay.Grabber
{
    using MyDay.Data;
    using MyDay.Data.Entities;

    public class Program
    {
        public static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Test from Task";
            p.Email = "Test from Task";

            Database.Person.Save(p);
        }
    }
}
