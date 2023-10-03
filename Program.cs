namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            string sel;
            int[,] tabl = new int[9,9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    tabl[i, j] = (i+1) * (j+1);
                }
            }
            do
            {
                Console.WriteLine("Выберите программу, которую хотите использовать \n1. Угадай число \n2. Таблица умножения \n3. Вывод делителей числа \n4. Закрыть программу");
                sel = Console.ReadLine();
                if (sel == "1")
                {
                    Randomizer();
                }
                if (sel == "2")
                {
                    Table(tabl);
                }
                if (sel == "3")
                {
                    Del();
                }

            } while (sel != "4");
        }
        static void Randomizer()
        {
            int inp;
            int num = new Random().Next(1, 101);
            Console.WriteLine("Угадай число от 1 до 100");
            do
            {
                inp = Convert.ToInt32(Console.ReadLine());
                if (inp > num)
                {
                    Console.WriteLine("Надо меньше<");
                }
                else if (inp < num)
                {
                    Console.WriteLine("Надо больше>");
                }
            } while (inp != num);
            Console.WriteLine("Ты угадал");
        }
        static void Table(int[,] tabl)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(Convert.ToString(tabl[i,j]) + "\t");
                }
            }
            Console.WriteLine("");
        }
        static void Del()
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}