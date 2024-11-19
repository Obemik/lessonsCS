using ClassApp.Entities;

namespace ClassApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person(name: null, surname: "Dou", type: PersonType.User);

                Console.WriteLine(person);
                string type = person.Type.ToString();
                Console.WriteLine(type);
                int typeIndex = (int)person.Type;
                Console.WriteLine(typeIndex);
                foreach (var item in Enum.GetValues(typeof(PersonType)))
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}