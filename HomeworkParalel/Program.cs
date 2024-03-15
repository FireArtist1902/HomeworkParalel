namespace HomeworkParalel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWork = true;
            while (isWork)
            {
                Console.Clear();
                Console.WriteLine("0.Вихід");
                Console.WriteLine("1.Факторіал числа");
                Console.WriteLine("2.Таблиця множення в діапазоні");

                int.TryParse(Console.ReadLine(), out int choice);

                switch (choice)
                {
                    case 0:
                        isWork = false;
                        break;
                    case 1:
                        Console.Clear ();
                        Console.WriteLine("Введіть число: ");
                        int.TryParse(Console.ReadLine(), out int num);
                        int result = 1;
                        Parallel.For(0, num, i =>
                        {
                            i++;
                            result *= i;
                        });

                        Thread.Sleep(1000);
                        Console.WriteLine($"Результат: {result}");
                        Console.WriteLine("Для продовження натисніть ENTER");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Початок діапазону");
                        int.TryParse(Console.ReadLine(), out int start);
                        Console.WriteLine("Кінець діапазону") ;
                        int.TryParse (Console.ReadLine(), out int end);
                        Parallel.For(start, end, i =>
                        {
                            for(int j = 1; j <= 10; j++)
                            {
                                Console.WriteLine($"{i} * {j} = {i * j}");
                            }
                            i++;
                        });
                        Thread.Sleep(1000);
                        Console.WriteLine("Для продовження натисніть ENTER");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}