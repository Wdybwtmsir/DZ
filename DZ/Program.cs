
    {
        Console.Write("Введите число A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число B: ");
        int B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Целые числа в диапазоне от A до B:");
        int k = 0;
        for (int i = A; i <= B; i++)
        {
            Console.WriteLine(i);
            k++;
        }
        Console.WriteLine($"Количество чисел в диапазоне: {k}");
    }
