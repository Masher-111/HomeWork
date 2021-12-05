//Задача 8.
//Показать четные числа от 1 до N
// string ShowEvenNumbers (int value)
// {
//     string result = string.Empty;
//     for (int i = 0; i <= value; i = i+2)
//     {
//        result += $"{i}" + " ";
//     }
//     return result;
// }
// Console.WriteLine (ShowEvenNumbers(15));

// Задача 9.
//  Показать последнюю цифру трёхзначного числа
// double ShowThirdFigure(int value)
// {
//     return value % 10;
// }
// Console.WriteLine(ShowThirdFigure(582));

// Задача 10. Показать вторую цифру трёхзначного числа

// int ShowSecondFigure(int value)
// {
//     return (value/10) % 10;
// }
// Console.WriteLine(ShowSecondFigure(582));

// Задача 11.
//  Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// int MaxFigure(int value)
// {
//      int secondFigure = value % 10;
//     int firstFigure = (value - secondFigure) / 10;
//     int maxValue = firstFigure;
//     if (secondFigure > maxValue) maxValue = secondFigure;
//     return maxValue;
// }
// int number = new Random().Next (10, 100);
// Console.WriteLine(number); 
// Console.Write(MaxFigure(number));

// Задача 12.
// Удалить вторую цифру трёхзначного числа
// int DeleteSecondFigure(int value)
// {
//     int firstFigure = (value - value % 100) / 10;
//     int secondFigure = value % 10;
//     int result = firstFigure + secondFigure;
//     return result;
// }
// int number = new Random().Next (100, 1000);
// Console.WriteLine(number); 
//  Console.WriteLine(DeleteSecondFigure(number));

// Задача 13.
// Выяснить, кратно ли число заданному, если нет, вывести остаток.
//Console.WriteLine(Math.DivRem(18, 4));

// Задача 14
// Найти третью цифру числа или сообщить, что её нет
// bool GetThirdFigure (int value)
// {
//     int result = (value - (value / 100)) / 100;
//     Console.WriteLine (result);
//     return result>=1;
// }
// Console.WriteLine(GetThirdFigure (154));
