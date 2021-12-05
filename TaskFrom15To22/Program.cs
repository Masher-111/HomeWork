//15. Дано число. Проверить кратно ли оно 7 и 23
// bool IfMultiplicity (int number)
// {
//    return number % 7 == 0 && number % 23 ==0;  
// }
// Console.WriteLine(IfMultiplicity(161));

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// bool IsWeekend(int day)
// {
//     return day == 6 || day == 7;
// }
// Console.WriteLine($"{(IsWeekend(3) ? "выходной" : "рабочий")}");

// 17. По двум заданным числам проверять является ли одно квадратом другого
// bool IsSquare(int number1, int number2)
// {
//     return number1*number1 == number2 || number2*number2 == number1;
// }
// int a = 16, b = 4;
// Console.WriteLine(IsSquare(a, b));

// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// bool ZakonDeMorgana (bool X, bool Y)
// {
//     return (! (X || Y)) ==  (!X && !Y);
// }
// Console.WriteLine (ZakonDeMorgana(true, true));
// Console.WriteLine (ZakonDeMorgana(false, true));
// Console.WriteLine (ZakonDeMorgana(true, false));
// Console.WriteLine (ZakonDeMorgana(false, false));

//19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int FindQuarterOfPoint(int vertical, int horizontal)
//  {
//     if ( vertical> 0 && horizontal > 0) return 1;
//     if (vertical < 0 && horizontal > 0) return 2;
//     if (vertical < 0 && horizontal < 0) return 3;
//     return 4;
// }    
// int x = 5, y = -4;
// Console.WriteLine($"Номер четверти для x={x}, y={y} : {FindQuarterOfPoint(x, y)}");

// 20. Задать номер четверти, показать диапазоны для возможных координат
// string[] ShowRange(int numberOfQuarter)
// {
//     return (numberOfQuarter == 1) ?  new string[]{"(0;+∞)","(0;+∞)"} :
//      ( (numberOfQuarter == 2 ? new string[]{"(-∞;0)","(0;+∞)"} :
//      ( (numberOfQuarter == 3 ? new string[]{"(-∞;0)","(-∞;0)"} : 
//      new string[]{"(0;+∞)","(-∞;0)"}))));
//  }
  
// int a = 4;
// string[] range = ShowRange(a);
// Console.WriteLine($"х = {range[0]}, y = {range[1]}");

// 21. Программа проверяет пятизначное число на палиндромом.
//  bool IsPalindrom(int number)
// {
//     string figure = Convert.ToString(number);
//     return (figure[0] == figure[4]) && (figure[1] == figure[3]);
// }

// Console.WriteLine(IsPalindrom(28823));


// 22. Найти расстояние между точками в пространстве 2D/3D
//  double FindDistance2D (double [] point1, double [] point2)
// {
//     return Math.Sqrt(Math.Pow((point2[0] - point1[0]), 2) 
//                      + Math.Pow((point2[1] - point1[1]), 2));
// }
// double [] A = {2, 1};
// double [] B = {5, 1};
// Console.WriteLine (FindDistance2D(A, B));

// double FindDistance3D (double [] point1, double [] point2)
// {
//     return Math.Sqrt(Math.Pow((point2[0] - point1[0]), 2) 
//                      + Math.Pow((point2[1] - point1[1]), 2) 
//                      + Math.Pow((point2[2] - point1[2]), 2));
// }
// double [] A = {2, 1, 4};
// double [] B = {5, 1, 4};
// Console.WriteLine (FindDistance3D(A, B));

