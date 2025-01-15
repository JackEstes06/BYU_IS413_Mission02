// See https://aka.ms/new-console-template for more information
using Mission02;

internal class Program
{
    private static void Main(string[] args)
    {
        int numDiceRolls = 0;
        System.Console.WriteLine(
            "Welcome to the dice throwing simulator!" +
            "\nHow many dice rolls would you like to simulate? "
        );
        numDiceRolls = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine(
            "\nDICE ROLLING SIMULATION RESULTS" +
            "\nEach \"*\" represents 1% of the total number of rolls." +
            "\nTotal Number of Rolls = " + numDiceRolls + "\n"   
        );
        
        // SIMULATE DICE ROLLS
        int[] rollArray = DiceRoll.RollSimulator(numDiceRolls);
        printAsteriskVisual(rollArray);
        
        System.Console.WriteLine(
            "\nThank you for using the dice throwing simulator. Goodbye!\n"   
        );
    }

    private static void printAsteriskVisual(int[] rollArray)
    {
        var possibleValues = Enumerable.Range(2, 11);
        var groups = rollArray
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());
        var completeGroups = possibleValues
            .Select(value => new { Value = value, Count = groups.ContainsKey(value) ? groups[value] : 0 })
            .OrderBy(x => x.Value);
        
        // Output or use completeGroups as needed
        foreach (var group in completeGroups)
        {
            int numStars = (int)((group.Count / (double) rollArray.Length) * 100);
            System.Console.Write($"{group.Value}: ");
            for (int i = 0; i < numStars; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}