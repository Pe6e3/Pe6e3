static void Main(string[] args)
        {

            Console.WriteLine($"Введите любое число");
            Console.WriteLine($"Enter any number");
            Console.WriteLine();

            int count = int.Parse(Console.ReadLine());
            int k = 0;
            int nechet = 0;
            int chet = 0;
            while (k < count)
            {
                k++;
                if (k % 2 == 0) chet++;
                if (k % 2 == 1) nechet++;
            }
            Console.WriteLine($"от 0 до {k} \nчетных чисел: {chet}\nнечетных чисел: {nechet}");
            Console.WriteLine();
            Console.WriteLine($"from 0 to {k} \neven numbers: {chet}\nodd numbers: {nechet}");
        }
