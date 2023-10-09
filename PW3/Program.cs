namespace PW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] notes = new int[12];
            Console.WriteLine("Почувствуй себя Моцартом");
            Console.WriteLine("Доступны 2 октавы: F1 - первая отктава, F2 - вторая октава");
            Console.WriteLine("Диез и бемоль ноты на клавиши: Q, W, E, R, T");
            Console.WriteLine("Ноты на клавиши: A, S, D, F, G, H, J");
            Console.WriteLine("Сочини новую симфонию ;) (да, из двух октав, а что? в тяжелые времена живем...)");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey();
                notes = octaves(notes, key);
                output(notes, key);
            } while (true);
        }   
        static int[] octaves(int[] a, ConsoleKeyInfo button)
        {
            int[] oct = new int[12] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
            int[] oct1 = new int[12] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            if (button.Key == ConsoleKey.F1)
            {
                a = oct;
            }
            if (button.Key == ConsoleKey.F2)
            {
                a = oct1;
            }
            return a;
        }
        static void output(int[] a, ConsoleKeyInfo button)
        {
            switch (button.Key)
            {
                case ConsoleKey.Q:
                    Console.Beep(a[1], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.W:
                    Console.Beep(a[3], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.E:
                    Console.Beep(a[5], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.R:
                    Console.Beep(a[7], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.T:
                    Console.Beep(a[10], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.A:
                    Console.Beep(a[0], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.S:
                    Console.Beep(a[2], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.D:
                    Console.Beep(a[4], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.F:
                    Console.Beep(a[6], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.G:
                    Console.Beep(a[8], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.H:
                    Console.Beep(a[9], 100);
                    Console.Clear();
                    break;
                case ConsoleKey.J:
                    Console.Beep(a[11], 100);
                    Console.Clear();
                    break;

            }
        }
    }
}