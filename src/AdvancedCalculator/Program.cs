using System;
using AdvancedCalculatorLib;

// Добавляем класс и метод Main
public class Program 
{
    public static void Main() 
    {
        var calculator = new Calculator();
        var stats = new StatisticsCalculator();

        Console.WriteLine("=== Продвинутый Калькулятор ===");
        Console.WriteLine($"5 + 3 = {calculator.Add(5, 3)}");
        Console.WriteLine($"2^4 = {calculator.Power(2, 4)}");
        Console.WriteLine($"5! = {calculator.Factorial(5)}");
        Console.WriteLine($"17 простое число? {calculator.IsPrime(17)}");
        Console.WriteLine($"Среднее [1,2,3,4,5] = {stats.CalculateAverage(1, 2, 3, 4, 5)}");
        Console.WriteLine($"Максимум [1,5,3,9,2] = {stats.FindMax(1, 5, 3, 9, 2)}");
        Console.WriteLine("\nВсе операции выполнены успешно!");
    }
}