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

            int[,] array = { 
                { 1, 2, 3},
                { 1, 2, 3 },
                { 1, 2, 3 },
                { 5, 6, 7 } 
            };
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)//Столбцы
            {
                for (int k = 0; k < array.GetUpperBound(1) + 1; k++)//Строки
                    Console.Write(array[i, k] + " ");

                Console.WriteLine();
            }


        }
    }
}
