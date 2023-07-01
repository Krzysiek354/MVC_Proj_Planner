namespace Projekt_MVC.Models
{
    public class Person
    {
        public int Id { get; set; }

        public  string Name { get; set; }

        public IEnumerable<School> School { get; set; }

        public IEnumerable<Shop> Shop { get; set; }

        public IEnumerable<Work> Work { get; set; }

        public IEnumerable<Enjoy> Enjoy { get; set; }

        public IEnumerable<Message> Message { get; set; }

    }
}
