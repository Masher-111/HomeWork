// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// string ShowQuater (int n)
// {
//     if (n >= 1) return ShowQuater (n-1) + $"{n*n} ";
//     else return String.Empty;
// }
// Console.WriteLine (ShowQuater(4));

// 24. Найти кубы чисел от 1 до N
// string ShowCubes (int n)
// {
//     if (n >= 1) return ShowCubes(n-1) + $"{n*n*n} ";
//     else return String.Empty;
// }
// Console.WriteLine (ShowCubes(8));

// 25. Найти сумму чисел от 1 до А
// int FindSum (int a)
// {
//     return (a * (a+1)) / 2;
// }
// Console.WriteLine(FindSum(6));

// 26. Возведите число А в натуральную степень B используя цикл
// int DegreeNumbers (int a, int b)
// {
//     int result = a;
//     for (int i = 2; i <= b; i ++)
//     {
//         result = result * a;
//     }
//     return result;
// }
// Console.WriteLine(DegreeNumber(3, 0));

// 27. Определить количество цифр в числе
// int CountOfDigits(int number)
// {
//     return (int)Math.Log10(number) + 1;
// }
// Console.WriteLine(CountOfDigits(123));
// int CountOfDigits2 (int number)
// {
//     int i = 0;
//     while (number > 0)
//     {
//       number/= 10;
//       i++;   
//     }
//     return i;
// }
// Console.WriteLine(CountOfDigits2(123));

// int CountOfDigits3 (int number)
// {
//     string  result = Convert.ToString(number);
//     return result.Length;
// }
// Console.WriteLine(CountOfDigits3 (123));

// 28. Подсчитать сумму цифр в числе
// int SumOfDigits(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
// return result;
// }
// Console.WriteLine(SumOfDigits(2846));
// 29. Написать программу вычисления произведения чисел от 1 до N
// int MultNumbers(int n)
// {   
//    if (n == 1) return 1;
//    else return n * MultNumbers(n - 1);
// }
// Console.WriteLine(MultNumbers(3));

//  int MultNumbers2 (int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n - 1; i++)
//     {
//         result = result * (i + 1);
//     }
//     return result;
// }
// Console.WriteLine (MultNumbers2 (4));

// 30. Показать кубы чисел, заканчивающихся на четную цифру
// string CubeOfNumbers (int number)
//  {
//      string result = string.Empty;
//      for(int i = 2; i <= number; i = i + 2)
//     {
//         result += $"{i * i * i} "; 
//      }

//   return result;
//  } 
// Console.WriteLine(CubeOfNumbers(6));

// string CubeOfNumbersRec (int number)
//  {
//     if (number%2==0) return CubeOfNumbers(number - 1) + $"{number * number * number} " ;
//     else return String.Empty;
//  } 
// Console.WriteLine(CubeOfNumbersRec(6));


