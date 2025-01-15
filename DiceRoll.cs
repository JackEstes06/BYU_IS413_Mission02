namespace Mission02;

public class DiceRoll
{
    // Simulates the rolls of 2 dice
    public static int[] RollSimulator(int numRolls)
    {
        Random dice1 = new Random();
        Random dice2 = new Random();
        int[] output = new int[numRolls];
        
        for (int i = 0; i < numRolls; i++)
        {
            output[i] = dice1.Next(1,7) + dice2.Next(1,7);
        }

        return output;
    }
}