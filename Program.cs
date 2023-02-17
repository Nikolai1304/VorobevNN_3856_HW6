// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


 
//  double Argument(string number)
// {
//     Console.Write($"Enter {number}: ");
//     double num = Convert.ToDouble(Console.ReadLine());
//     return num;
// }

    
//     double [] CreateArray(double size, double minValue, double maxValue)
// {
//     double [] res = new double[size];

//     for (double i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }


// double ArraySize = Argument("Enter array size");
// double minValue = Argument("Enter minValue for array");
// double maxValue = Argument("Enter maxValue for array");
// Console.WriteLine();

// double [] numbers = CreateArray(ArraySize, minValue, maxValue);
// Console.WriteLine(String.Join(" ", numbers));

// void moreThenZero (double[]Argument)
// {
//     double result =0;
//     for (double i = 0; i < numbers.Length; i++) 
//     { 
//         if (numbers[i]>0) 
//         {result++;}
//     }
// System.Console.WriteLine(result);
// }
// moreThenZero(numbers);





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Argument(string number)
{
    Console.Write($"Введите число {number}: ");
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}
double k1 = Argument(" k1");
double b1 = Argument(" b2");
double k2 = Argument(" k2");
double b2 = Argument(" b2");

double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;

System.Console.WriteLine();
System.Console.WriteLine("Координаты точки пересечения двух прямых,");
System.Console.Write("заданных уравнениями y=k1*x+b1 и y=k2*x+b2 :  ");
System.Console.Write("(" + Math.Round(x, 2)+ "; ");
System.Console.Write(Math.Round(y, 2)+")");
System.Console.WriteLine();

// System.Console.Write("Введите значение k1  ");
// double k1 = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите значение b1  ");
// double b1 = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите значение k2  ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Введите значение b2  ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// Задача 44:выведите первые N чисел  Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8


int Fibonacci (int n)
{
    if (n == 1 || n ==2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 50; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}