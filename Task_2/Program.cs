// Получения первого числа от пользователя
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

// Получение второго числа от пользователя
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

// Получение третьего числа от пользователя
Console.Write("Введите второе число: ");
int number3 = int.Parse(Console.ReadLine());

// Присвоение переменных
int max = number1;

// Поиск наибольшего числа

if (number2 > number1)
    max = number2;
if (number3 > max)
    max = number3;

// Вывод на экран
  Console.WriteLine($"Максимальное число {max}");