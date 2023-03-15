namespace Prelab5.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int BirthYear { get; set; }

        public int Age => DateTime.Now.Year - BirthYear;
    }
}
