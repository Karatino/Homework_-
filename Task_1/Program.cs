// Получения первого числа от пользователя
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

// Получение второго числа от пользователя
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

// Присвоение переменных
int max = number1;
int min = number2;

// Поиск наибольшего числа

  {
    if (max < min) 

       {
            max = number2;
            min = number1;
       }
    else
        {
            max = number1;
            min = number2;
        }
  }

// Вывод на экран
  Console.WriteLine($"Максимальное число {max}");
  Console.WriteLine($"Минимальное число {min}");