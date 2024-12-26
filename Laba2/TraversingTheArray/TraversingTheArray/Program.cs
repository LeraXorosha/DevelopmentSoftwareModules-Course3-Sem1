using Calculator;
using TraversingTheArray;

internal class Program
{
    private static void Main(string[] args)
    {
        task2();
    }


    static void task1()
    {
        Console.Write("Введите размерность массива --> ");
        int n = Convert.ToInt32(Console.ReadLine());


        double[] mas = new double[n];
        for (int i = 0; i < n; i++)
        {
            mas[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"Минимальное значение: {mas.FindMinimum()}");
        Console.WriteLine($"Минимальное значение: {mas.FindMinimum()}");
        Console.WriteLine($"Максимальное значение: {mas.FindMaximum()}");
        Console.WriteLine($"Медиана: {mas.FindMedian()}");
        Console.WriteLine($"Среднее арифметическое: {mas.FindAverage()}");
        Console.WriteLine($"Среднее геометриеское: {mas.FindGeometricAverage()}");

    }
    static void task2()
    {
        Console.Write("Введите арифметическое выражение --> ");
        string expression = Console.ReadLine();
        Console.WriteLine($"Ответ: {Calculator.Calculator.Calculate(expression)}");
        
    }

}



