// 66. Показать натуральные числа от 1 до N, N задано
// string ShowNumbers (int n)
// { 
    
//     if (n >= 1) return ShowNumbers(n-1) + $"{n} "; 
//     else return String.Empty;
// }
// Console.WriteLine(ShowNumbers(6));
// 67. Показать натуральные числа от N до 1, N задано
// string ShowNumbers (int n)
// { 
    
//     if (n >= 1) return  $"{n} "  + ShowNumbers(n-1); 
//     else return String.Empty;
// }
// Console.WriteLine(ShowNumbers(6));

// 68. Показать натуральные числа от M до N, N и M заданы
// string ShowNumbers (int m, int n)
// { 
    
//     if (m <= n) return  $"{m} "  + ShowNumbers(m+1, n); 
//     else return String.Empty;
// }
// Console.WriteLine(ShowNumbers(6, 10));
// 69. Найти сумму элементов от M до N, N и M заданы
// int SumNumbers (int m, int n)
// { 
//     if (m==n) return m;
//     else return m + SumNumbers(m+1, n);
// }
// Console.WriteLine(SumNumbers(1, 2));
//70. Найти сумму цифр числа
// int SumDigit (int n)
// {
//    if ( n==0) return 0;
//    return n % 10 + SumDigit(n/10);
// }
//  Console.WriteLine(SumDigit(1023));
// 71. Написать программу вычисления функции Аккермана
// int Accerman (int m, int n)
// {
//     if (m==0) return n + 1;
//     else  if (m > 0 && n == 0) return Accerman(m-1, 1);
//     return Accerman(m-1, Accerman(m, n-1));
// }
// Console.WriteLine(Accerman(3, 5));
// 72. Написать программу возведения числа А в целую стень B
// int Power (int a, int b)
// {
//     if (b == 0) return 1;
//     return a * Power (a, b-1);
// }
// Console.WriteLine(Power(4, 0));
// 73. Написать программу показывающие первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
// string ShowNumbers (int a, int b, int n)
// {
//         if (n > 0) return  $"{a} " + ShowNumbers(b, a+b, n-1);
//         return string.Empty;
// }
// Console.WriteLine(ShowNumbers(100, 200, 4));
// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
//  int n =1;
//  void FindWorlds (string alphabet, char [] word,int length = 0)
//  {
//      if (length == word.Length)
//      {
//          Console.WriteLine($"{n++} {new String(word)}"); return;
//        }
//        for (int i = 0; i < alphabet.Length; i ++)
//        {
//            word[length] = alphabet[i];
//            FindWorlds(alphabet, word, length+1);
//        }
//  }
// FindWorlds ("aисв", new char[3]);