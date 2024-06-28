namespace MyFirstWebApp.Models.Entities
{
    public class Athlete
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Injured { get; set; }   
    }
}
