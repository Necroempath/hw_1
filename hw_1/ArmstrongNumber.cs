namespace hw_1;

public class ArmstrongNumber : Task
{
    public override string Description => "Task 8\nChecks if the number is an Armstrong number.\n";

    public override void Execute()
    {
        if (IOManager.ReportHandler(IOManager.GetValidValue("Enter positive number: ", out int result, min: 1)))
        {
            bool isArmstrong = IsArmstrong(result);
            string msg = isArmstrong ? "Armstrong number" : "not Armstrong number";

            Console.WriteLine($"{result} is {msg}");
        }
    }
    
    private static bool IsArmstrong(int result)
    {
        int RaiseToPower(int value, int degree)
        {
            int temp = value;
            
            for (int i = 0; i < degree - 1; i++)
            {
                value *= temp;
            }
            
            return value;
        }
        
        int buffer = result;
        
        var digits = new List<int>();
        
        while (buffer > 0)
        {
            digits.Add(buffer % 10);
            buffer = buffer / 10;
        }
    
        int power = digits.Count;
    
        for (int i = 0; i < power; i++)
        {
            buffer += RaiseToPower(digits[i], power);
        }
        
        return buffer == result;
    }
}