using System;

namespace First
{
    class MainClass
    {
        private const string Value = "Cin x:";

        public static void Main(string[] args)
        {
          

            void Graphic()
            {
                Console.Clear();
                Console.WriteLine("Select graph type:");

                int top = Console.CursorTop;
                int y = top;

                Console.WriteLine("1: sin");
                Console.WriteLine("2: cos");
                Console.WriteLine("3: tan");
                Console.WriteLine("4: ctg");

                int down = Console.CursorTop;

                Console.CursorSize = 100;
                Console.CursorTop = top;

                ConsoleKey key;

                while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
                {
                    switch (key)
                    {
                        case ConsoleKey.D1:
                            y = top;
                            Console.CursorTop = top;
                            break;
                        case ConsoleKey.D2:
                            y = top + 1;
                            Console.CursorTop = top + 1;
                            break;
                        case ConsoleKey.D3:
                            y = top + 2;
                            Console.CursorTop = top + 2;
                            break;
                        case ConsoleKey.D4:
                            y = top + 3;
                            Console.CursorTop = top + 3;
                            break;
                        default:
                            break;

                    }
                }

                Console.CursorTop = down;
                Fun a = new Fun();
                int ssave = y - top;
                Console.Clear();
                Console.WriteLine("Cin x:");
                a.Funuction(double.Parse(Console.ReadLine()), ssave);
              
            }

            bool Flag = true;

            while (Flag)

            {
                Graphic();
                Console.WriteLine("1 - Again \n Any key - Close");
                if (Console.ReadLine() == "1") continue;
                else
                {
                    Console.WriteLine("Good luck");
                    Flag = false;
                }
            }

            Console.WriteLine("Good luck!");
            Console.ReadLine();
        }

    }
}