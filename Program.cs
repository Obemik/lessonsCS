//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var random = new Random();
//            Console.WriteLine("Enter the lower bound of the random number: ");
//            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the upper bound of the random number: ");
//            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());

//            if (lowerMaxRandomBound > upperMaxRandomBound)
//            {
//                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
//            }
//            Console.WriteLine("Enter the size of the array: ");
//            int size = Convert.ToInt32(Console.ReadLine());
//            var arr = new int[size];
//            for (int i = 0; i < size; i++)
//            {
//                arr[i] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
//            }

//            Console.WriteLine("The array is: ");
//            foreach (var item in arr)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//            // Sort the array
//            Array.Sort(arr);
//            Console.WriteLine("The sorted array is: ");
//            foreach (var item in arr)
//            {
//                Console.Write(item + " ");
//            }
//            Console.WriteLine();
//            Console.WriteLine($"Max = {arr.Max()}");
//            Console.WriteLine($"Min = {arr.Min()}");
//            Console.WriteLine($"Sum = {arr.Sum()}");
//            Console.WriteLine($"Average = {arr.Average()}");
//        }
//    }
//}

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var random = new Random();
//            Console.WriteLine("Enter the lower bound of the random number: ");
//            var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the upper bound of the random number: ");
//            var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());
//            if (lowerMaxRandomBound > upperMaxRandomBound)
//            {
//                (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
//            }
//            Console.WriteLine("Enter the size of the array: ");
//            int size = Convert.ToInt32(Console.ReadLine());
//            int[,] arr = new int[size, size];
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    arr[i, j] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
//                }
//            }

//            Console.WriteLine("The array is: ");
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    Console.Write(arr[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            int[] temp = new int[size * size];
//            int k = 0;
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    temp[k++] = arr[i, j];
//                }
//            }

//            Array.Sort(temp);



//            Console.WriteLine("The sorted array is: ");
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    Console.Write(arr[i, j] + " ");
//                }
//                Console.WriteLine();
//            }
//            Console.WriteLine();
//            //
//            float sum = 0;
//            float average = 0;
//            float max = arr[0, 0];
//            float min = arr[0, 0];
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    sum += arr[i, j];
//                    if (arr[i, j] > max)
//                    {
//                        max = arr[i, j];
//                    }
//                    if (arr[i, j] < min)
//                    {
//                        min = arr[i, j];
//                    }
//                }
//            }
//            average = sum / (size * size);
//            Console.WriteLine($"Max = {max}");
//            Console.WriteLine($"Min = {min}");
//            Console.WriteLine($"Sum = {sum}");
//            Console.WriteLine($"Average = {average}");
//        }
//    }
//}

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                var random = new Random(DateTime.Now.Microsecond);
//                Console.WriteLine("Enter the lower bound of the random number: ");
//                var lowerMaxRandomBound = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter the upper bound of the random number: ");
//                var upperMaxRandomBound = Convert.ToInt32(Console.ReadLine());
//                if (lowerMaxRandomBound > upperMaxRandomBound)
//                {
//                    (lowerMaxRandomBound, upperMaxRandomBound) = (upperMaxRandomBound, lowerMaxRandomBound);
//                }
//                Console.WriteLine("Enter the size of the array: ");
//                int size = Convert.ToInt32(Console.ReadLine());
//                int[][] arr = new int[size][];
//                for (int i = 0; i < size; i++)
//                {

//                    int innerSize = random.Next(1, 5);
//                    arr[i] = new int[innerSize];
//                    for (int j = 0; j < innerSize; j++)
//                    {
//                        arr[i][j] = random.Next(lowerMaxRandomBound, upperMaxRandomBound);
//                    }

//                }

//                Console.WriteLine("The array is: ");
//                for (int i = 0; i < size; i++)
//                {
//                    for (int j = 0; j < arr[i].LongLength; j++)
//                    {
//                        Console.Write(arr[i][j] + " ");
//                    }
//                    Console.WriteLine();
//                }






//                float sum = 0;

//                float max = arr[0][0];
//                float min = arr[0][0];
//                for (int i = 0; i < size; i++)
//                {
//                    for (int j = 0; j < arr[i].LongLength; j++)
//                    {
//                        sum += arr[i][j];
//                        if (arr[i][j] > max)
//                        {
//                            max = arr[i][j];
//                        }
//                        if (arr[i][j] < min)
//                        {
//                            min = arr[i][j];
//                        }
//                    }
//                }
//                Console.WriteLine($"Max = {max}");
//                Console.WriteLine($"Min = {min}");
//                Console.WriteLine($"Sum = {sum}");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }


//        }
//    }
//}

//using System.Text;

//namespace ConsoleApp2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                string? str = Console.ReadLine();
//                StringBuilder sb = new StringBuilder();
//                sb.Append(str);
//                sb[0] = char.ToUpper(sb[0]);
//                Console.WriteLine(sb);
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}