namespace BlazorLabb.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public Adress? Adress { get; set; } = new Adress();
        public Company? Company { get; set; } = new Company();
    }
}
