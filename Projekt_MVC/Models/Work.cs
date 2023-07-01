namespace Projekt_MVC.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Task { get; set; }

        public DateTime  When { get; set; }

        public int IdKid { get; set; }
    }
}
