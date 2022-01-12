// Почувствуй себя сеньором
// 31. Задать массив из 8 элементов и вывести их на экран 
// void CreateArray (int [] array)
// {
//     int index = array.Length;
//     for (int i = 0; i < index; i ++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
// }
 void PrintArray (int [] array)
{
    int index = array.Length;
    for (int i = 0; i < index; i ++)
    {
        Console.Write (array [i] + " ");
    }
} 
// int [] arrayNumbers = new int [8];
// CreateArray(arrayNumbers);
// PrintArray(arrayNumbers);

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 
// void CreateArray (int [] array)
// {
//     int index = array.Length;
//     for (int i = 0; i < index; i ++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
// }
// int [] arrayDigits = new int [8];
// CreateArray(arrayDigits);
// PrintArray(arrayDigits);
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
// void CreateArray (int [] array)
// {
//     int index = array.Length;
//     for (int i = 0; i < index; i ++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
// }
// int [] arrayOfDigits = new int [12];
// CreateArray(arrayOfDigits);
// PrintArray(arrayOfDigits);
// int FindSumPositive (int [] array)
// {
//     int result = 0;
//     int index = array.Length;
//     for (int i = 0; i < index; i ++)
//     {
//         if (array[i] >= 0)
//         {
//              result += array[i];
//         }
//     }
// return result;
// }
// Console.WriteLine();
// Console.WriteLine(FindSumPositive(arrayOfDigits));
// int FindSumNegative (int [] array)
// {
//     int result = 0;
//     int index = array.Length;
//     for (int i = 0; i < index; i ++)
//     {
//         if (array[i] < 0)
//         {
//              result += array[i];
//         }
//     }
// return result;
// }
// Console.WriteLine(FindSumNegative(arrayOfDigits));

// 34. Написать программу замену элементов массива на противоположные
 /*int [] CreateArray (int [] array)
 {
     int index = array.Length;
     for (int i = 0; i < index; i ++)
     {
         array[i] = new Random().Next(-100, 100);
     }
 return array;
 }
int [] ChangeOpposite (int [] array)
{
    int size = array.Length;
    for (int index = 0; index < size; index++)
    {
        array[index] = array[index] * -1;
    }
    return array;
}
int [] arrayOfNumbers = new int [10];
CreateArray(arrayOfNumbers);
PrintArray(arrayOfNumbers);
Console.WriteLine();
ChangeOpposite(arrayOfNumbers);
PrintArray(arrayOfNumbers);
*/
// 35. Определить, присутствует ли в заданном массиве, некоторое число 
/*int [] CreateArray (int [] array)
 {
     int index = array.Length;
     for (int i = 0; i < index; i ++)
     {
         array[i] = new Random().Next(-10, 10);
     }
 return array;
 }
 bool FindNumber (int [] array, int number)
 {
     int size = array.Length;
     for (int index = 0; index < size; index++)
     {
         if (array[index] == number) return true;
     }
return false;
 }
 int [] arrayOfNumbers = new int [10];
 CreateArray(arrayOfNumbers);
PrintArray(arrayOfNumbers);
Console.WriteLine(FindNumber(arrayOfNumbers, 0));
*/
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
/*int [] CreateArray (int [] array)
 {
     int index = array.Length;
     for (int i = 0; i < index; i ++)
     {
         array[i] = new Random().Next(-999, 1000);
     }
 return array;
 }
  string CountOddAndEvenNumbers (int [] array)
 {
     int size = array.Length;
     string result = string.Empty;
     int Odd = 0;
     int Even = 0;
     for (int index = 0; index < size; index++)
     {         if (array[index] % 2 == 0)
        {
            Even ++;
        }
         if (array[index] % 2 !=0)
         {
            Odd ++;
        }
     }
 return $"Число четных чисел в массиве: {Even}, число нечетных чисел в массиве: {Odd}";
 }
 int [] arrayOfNumbers = new int [10];
 CreateArray (arrayOfNumbers);
 PrintArray (arrayOfNumbers);
 Console.WriteLine ();
 Console.WriteLine(CountOddAndEvenNumbers (arrayOfNumbers));
 */
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
/*int [] CreateArray (int [] array)
 {
     int index = array.Length;
     for (int i = 0; i < index; i ++)
     {
         array[i] = new Random().Next(-100, 100);
     }
 return array;
 }

 int CountOfNumbers (int [] array, int firstElement, int lastElement)
 {
     int count = array.Length;
     int result = 0;
     for (int index =0; index < count; index++)
     {
         if (array[index] >= firstElement && array[index] <= lastElement)
         result ++;
     }
     return result;
 }
 int [] arrayOfNumbers = new int [123];
 CreateArray (arrayOfNumbers);
 Console.Write (CountOfNumbers (arrayOfNumbers, 10, 99));
 */
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
/*int [] CreateArray (int [] array)
 {
     int index = array.Length;
     for (int i = 0; i < index; i ++)
     {
         array[i] = new Random().Next(-10, 10);
     }
 return array;
 }
 int SumOfOddElementsOfArray (int [] array)
 {
     int size = array.Length;
     int SumResult = 0;
     for (int count=1; count < size; count= count +2)
     { 
         SumResult += array[count];        
     }
  return SumResult;
 }
 int [] arrayOfNumbers = new int [10];
 CreateArray (arrayOfNumbers);
 PrintArray (arrayOfNumbers);
 Console.WriteLine();
 Console.WriteLine (SumOfOddElementsOfArray(arrayOfNumbers));
*/
// 39. Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
/* int [] CreateArray (int [] array)
 {
     int index = array.Length;
     for (int i = 0; i < index; i ++)
     {
         array[i] = new Random().Next(-10, 10);
     }
 return array;
 }
 string MultOfАPairOfNumbers (int [] collection)
 {
     string result = string.Empty;
     int count = collection.Length;
     {
         for (int i =0; i < count/2; i++) 
         {
           result += $"{collection [i] * collection [count - 1 - i]}, ";
         }
     }
     return result;
 }
 int [] arrayOfNumbers = new int [10];
 CreateArray (arrayOfNumbers);
 PrintArray (arrayOfNumbers);
 Console.WriteLine();
 Console.WriteLine(MultOfАPairOfNumbers (arrayOfNumbers));
 */
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
/* double [] CreateArray (double [] array)
 {
     int count = array.Length;
     for (int index = 0; index < count; index++)
     {
        array [index] = new Random().NextDouble();
     }
     return array;
  }
 void PrintingArray (double [] array)
  {
      int size = array.Length;
      for (int i = 0; i < size; i++)
      {
          Console.Write (array [i] + " " );
      }
  }
 double DifferentFromMaxAndMin (double [] array)
 {
     double maxValue = array[0];
     double minValue = array[0];
     int count = array.Length;
     for (int i = 1; i < count; i++)
     {
         if (array[i] < minValue) minValue = array[i];
         if (array[i] > maxValue) maxValue = array[i];
     }
     return maxValue - minValue;
 }
 double [] arrayOfNumbers = new double [7];
 CreateArray (arrayOfNumbers);
 PrintingArray (arrayOfNumbers);
 Console.WriteLine();
 Console.WriteLine (DifferentFromMaxAndMin (arrayOfNumbers));
/*
