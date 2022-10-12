using System.Runtime.CompilerServices;

namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доступные операции:" +
                "\n 1 - Угадай число" +
                "\n 2 - Таблица умножения" +
                "\n 3 - Вывод делителей числа" +
                "\n 4 - Выход");

            Console.WriteLine("\n Выберите операцию: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            while (operation != 4)
            {
                switch (operation)
                {
                    case 1:
                        rnd();
                        break;
                    case 2:
                        Console.WriteLine();
                        table();
                        break;
                    case 3:
                        divisor();
                        break;
                }
                Console.WriteLine("\nВыберите операцию: ");
                int operation_1 = Convert.ToInt32(Console.ReadLine());

                operation = operation_1;
            }
        }

        static void rnd()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);

            Console.WriteLine("Угадайте число: ");
            int val = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (val == value)
                {
                    Console.WriteLine("Вы угадали!");
                }
                else if (val > value)
                {
                    Console.WriteLine("Надо меньше");
                }
                else
                {
                    Console.WriteLine("Надо больше");
                }
                int val_1 = Convert.ToInt32(Console.ReadLine());
                if (val_1 == value)
                {
                    Console.WriteLine("Вы угадали!");
                }
                val = val_1;
            }
            while (val != value);
        }

        static void table()
        {
            int[,] table = new int[10, 10];
            for (int ryad = 1; ryad < 10; ryad++)
            {
                for (int stolb = 1; stolb < 10; stolb++)
                {
                    table[ryad, stolb] = ryad * stolb;
                }    
            }
            for (int ryad = 1; ryad < table.GetLength(0); ryad++)
            {
                for (int stolb = 1; stolb < table.GetLength(1); stolb++)
                {
                    Console.Write(table[ryad, stolb]  + "\t");
                }
                Console.WriteLine();
            }

        }

        static void divisor()
        {
            Console.WriteLine("Введите число: ");
            int val = Convert.ToInt32(Console.ReadLine());

            List<int> delitel = new List<int>();

            int del = val;

            while (del > 0)
            {
                if (val % del == 0)
                {
                    delitel.Add(del);
                    del--;
                }
                else
                {
                    del--;
                }
            }

            delitel.Sort();
            Console.WriteLine("Число {0}, делиться без остатка на: ", val);

            foreach (int num in delitel)
            {
                Console.Write(num + "\t");
            }
        }
    }
}