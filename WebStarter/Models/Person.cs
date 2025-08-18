namespace WebStarter.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Person()
        {
            
        }

        public Person(int id, string firstname, string lastname, int age)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }
    }
}
