using System.Xml.Linq;

namespace ChoosingAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Iteration {0}", i);
            //    switch (Console.ReadLine())
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is red!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is green!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is cyan!");
            //            break;
            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Your color is yellow!");
            //            break;
            //    }
            //    i++;

            //}
            //while (i<4);

            //Console.WriteLine("Write your name");
            //string userName = Console.ReadLine();

            //for (int i = userName.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(userName[i] + " ");
            //}

            //Console.WriteLine("Your name's reverse spalling");
            //foreach (var charUserName in userName)
            //{
            //    Console.Write(charUserName + " ");
            //}
            //Console.Write("The last character of your name is " + userName[userName.Length - 1]);

            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            //for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            //{
            //    for (int j = 0; j < array.GetUpperBound(0) + 1; j++)
            //        Console.Write(array[j, i] + " ");

            //    Console.WriteLine();
            //}

            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            //int sumArray = 0;
            //foreach (int i in arr)
            //{
            //    sumArray += i;
            //}

            //Console.WriteLine(sumArray);

            //int[][] array = new int[3][];

            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };

            //foreach (int[] arr in array)
            //{
            //    foreach (int i in arr)
            //    {
            //        Console.Write(i + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            //int count = 0;
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        count += arr[i, j] > 0 ? 1 : 0;
            //    }
            //}
            //Console.WriteLine(count);

            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            //for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
            //        Console.Write(arr[i, j] + " ");

            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        for(int k = j + 1; k < arr.GetLength(1); k++)
            //        {
            //            if (arr[i, j] > arr[i, k])
            //            {
            //                int temp = arr[i, j];
            //                arr[i, j] = arr[i, k];
            //                arr[i, k] = temp;
            //            }
            //        }
            //    }
            //}

            //for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < arr.GetUpperBound(1) + 1; j++)
            //        Console.Write(arr[i, j] + " ");

            //    Console.WriteLine();
            //}

            //var (name, age) = ("Евгения", 27);
            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);
            //(string name, int age) user;

            //Console.WriteLine("Enter your name ");
            //user.name = Console.ReadLine();
            //Console.WriteLine("Enter your age in number");
            //bool isCorrectAge = int.TryParse(Console.ReadLine(), out user.age);


            //Console.WriteLine("Ваше имя: {0}", user.name);
            //Console.WriteLine("Ваш возраст: {0}", user.age);
            //(string Name, string Type, int Age) Pet;

            (string Name, string Type, double Age, int NameCount) Pet;
            Console.WriteLine("Enter pet's name");
            Pet.Name = Console.ReadLine();
            Console.WriteLine("Enter pet's Type");
            Pet.Type = Console.ReadLine();
            bool isAgeCorrect = double.TryParse(Console.ReadLine(), out Pet.Age);
            Pet.NameCount = Pet.Name.Length;
        }
    }
}
