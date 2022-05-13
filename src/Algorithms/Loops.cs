// Add list of names and iterate through it.

public class Loops
{
    public Loops()
    {
        Console.Clear();
        Console.WriteLine("Printing array of names Loop Example:");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        var names = new[] { "Doris Molina", "Melissa Hendrix", "Isa Young", "Iolo Odling", "Nada Rodgers",
        "Evalyn Tierney", "Amani Bassett", "Manveer Clemons", "Katlyn Gutierrez", "Ruben Mcpherson"};

        Console.WriteLine("Without loop:");
        Console.WriteLine("===========");
        Console.WriteLine("Name:" + names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);
        Console.WriteLine(names[3]);
        Console.WriteLine(names[4]);
        Console.WriteLine(names[5]);
        Console.WriteLine(names[6]);
        Console.WriteLine(names[7]);
        Console.WriteLine(names[8]);
        Console.WriteLine(names[9]);

        Console.WriteLine();
        NamesLoop(names);
    }

    private void NamesLoop(string[] names)
    {
        Console.WriteLine("Using loop:");
        Console.WriteLine("===========");
        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine("Name:" + names[i]);
        }
        Console.WriteLine();
    }
}