using System.Text;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main()
        {
            int padding = Console.BufferWidth / 3;
            int lineNumber = 13;
            try
            {

                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;

                Console.ForegroundColor = ConsoleColor.Green;

                Console.SetCursorPosition(padding, lineNumber++);
                Console.Write("Введіть ім'я: ");
                string? name = Console.ReadLine();
                Console.SetCursorPosition(padding, lineNumber++);
                Console.Write("Введіть вік: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.SetCursorPosition(padding, lineNumber++);
                Console.WriteLine($"Привіт, {name}!");
                Console.SetCursorPosition(padding, lineNumber++);
                Console.WriteLine($"Тобі {age} років.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Шось пішло не так... : {ex.Message}");
            }
            Console.Clear();
        }
    }
}
//using System.Text;

//namespace ConsoleApp1
//{

//    public class Program
//    {
//        static void Main()
//        {
//            var list = new List<string>()
//           {
//               "Hello",
//               "World!,"
//           };
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Hello World!");
//            }
//            foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}