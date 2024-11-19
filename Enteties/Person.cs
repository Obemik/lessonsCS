using System.Xml.Linq;

namespace ClassApp.Entities
{
    enum PersonType
    {
        Admin,
        User,
        Guest
    }
    internal partial class Person
    {
        private string? _name;
        public string? Surname { set; get; }

        public PersonType Type { get; set; }


        public Person()
        {
            Name = "Empty";
            Surname = "Empty";
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name, string surname) : this(name)
        {
            Surname = surname;
        }
        public Person(string name, string surname, PersonType type) : this(name, surname)
        {
            Type = type;
        }



    }
}