namespace hw_1;

public class EvenNumbersIn : Task
{
    public override string Description => "Task 7\nDisplays even numbers within a given range, normalizing the bounds if needed.\n";

    public override void Execute()
    {
        if(IOManager.ReportHandler(IOManager.GetValidValue("Enter first number: ", out int firstNumber))
           && IOManager.ReportHandler(IOManager.GetValidValue("Enter second number: ", out int secondNumber)))
        {
            List<int> odds = AllOdds(firstNumber, secondNumber);
        
            for (int i = 0; i < odds.Count; i++)
            {
                Console.Write(odds[i] + " ");
            }
        }
    }
    
    private static List<int> AllOdds(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            (firstNumber, secondNumber) = (secondNumber, firstNumber);
        }
        
        List<int> result = new List<int>();
        
        if (firstNumber % 2 != 0) firstNumber++;
        
        while(firstNumber <= secondNumber)
        {
            result.Add(firstNumber);
            firstNumber += 2;
        }
        
        return result;
    }
}