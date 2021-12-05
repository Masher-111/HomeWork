//Задача 0.
//Вывести квадрат числа
// double GetSquare(double number)
// {
//     return Math.Pow(number, 2);
// }
//  Console.WriteLine(GetPow2(5));

//  Console.WriteLine(Math.Pow(8,2));

// Задача 1.
// По двум заданным числам проверять является ли первое квадратом второго
// bool Square (int a, int b)
// {
//    return b*b == a;
// }
// Console.WriteLine(Square( 64, 8));

// Задача 2. 
//Даны два числа. Показать большее и меньшее число
// string  GetMinMax(int a, int b)
// {
//     int minValue = a;
//     int maxValue = b;
//     string result = string.Empty;
//     if (a > b)
//     {
//         minValue = b;
//         maxValue = a;       
//     }
//  return result = $"minValue is {minValue}, maxValue is {maxValue}";
// }
//  Console.WriteLine(GetMinMax(56, 4));


//Задача 3. 
//По заданному номеру дня недели вывести его название
// void DayOfWeek(int numberDay)
// {
//     if (numberDay == 1)
//     {
//         Console.WriteLine("Понедельник");
//     }
//     else if (numberDay == 2)
//     {
//         Console.WriteLine("Вторник");
//     }
//     else if (numberDay == 3)
//     {
//         Console.WriteLine("Среда");
//     }
//     else if (numberDay == 4)
//     {
//         Console.WriteLine("Четверг");
//     }
//     else if (numberDay == 5)
//     {
//         Console.WriteLine("Пятница");
//     }
//     else if (numberDay == 6)
//     {
//         Console.WriteLine("Суббота");
//     }
//     else if (numberDay == 7)
//     {
//         Console.WriteLine("Воскресенье");
//     }
//     else 
//     {
//         Console.WriteLine("Введны некорректные данные");
//     }
// }
// int setNumberDay = int.Parse(Console.ReadLine());
// DayOfWeek(setNumberDay);


//Задача 4. 
//Найти максимальное из трех чисел 
// int GetMaxOfThreeNumber(int a, int b, int c)
// {
//     int result = a;
//     if (b > result) result = b;
//     if (c > result) result = c;
//     return result;
// }
// Console.Write(GetMaxOfThreeNumber(18, 56, 5));

// Задача 5. 
//Написать программу вычисления значения функции y=sin(a) 
// double GetSin(double a)
// {
//     return Math.Sin(a);
// }
// Console.WriteLine(GetSin(6));

// Console.WriteLine(Math.Sin(6));

//Задача 6.
//Выяснить является ли число чётным
// bool IsEven(int value)
// {
//    return value % 2 == 0;
// }
// Console.WriteLine(IsEven(78));

// var IsEven = (int v) => v % 2 == 0;
// Console.WriteLine(IsEven(57));

//Задача 7. 
// Показать числа от -N до N 
// string ShowNumbers (int value)
// {
//     string result = string.Empty;
//     for (int i  = value * -1; i<= value; i ++)
//         {
//         result = result + $"{i}" + " ";
//         }
//       return result;
//  }
// Console.Write(ShowNumbers(4));
