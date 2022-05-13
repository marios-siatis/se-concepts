// In this example I will assume user is passing positive number

public class Recursion
{
    public Recursion()
    {
        Console.Clear();
        Console.WriteLine("Factorial Calculator");
        Console.WriteLine("====================");
        Console.WriteLine();
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Factorial Loop:      " + FactorialLoop(num));
        Console.WriteLine("Factorial Recursion: " + FactorialRecursion(num));
    }


    private int FactorialLoop(int num)
    {
        var result = 1;
        while (num > 0)
        {
            result = result * num; // 1*6*5*4*....
            num--;
        }
        return result;
    }

    private int FactorialRecursion(int num)
    {
        if (num == 0 || num == 1)
            return 1;
        return num * FactorialRecursion(num - 1);
    }
}