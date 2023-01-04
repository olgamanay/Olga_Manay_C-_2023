internal class Program
{
    private static void Main(string[] args)
    {
        Main(args, v);
    }

    private static void Main(string[] args, int number1, int square)
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        string str = Console.ReadLine();
        int v = Convert.ToInt32(str);
        square = number1 * number1;
        Console.WriteLine(square);
        Console.WriteLine($"Квадрат числа {number1} = {square}");
    }
}