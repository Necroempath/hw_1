namespace hw_1;

public class PerfectNumber : Task
{
    public override string Description => "Task 9\nChecks if the number is a perfect number.\n";

    public override void Execute()
    {
        if (IOManager.ReportHandler(IOManager.GetValidValue("Enter number, greater than 1: ", out int result, min: 2)))
        {
            bool isPerfect = IsPerfect(result);
            string msg = isPerfect ? "is Perfect number" : "is not Perfect number";
        
            Console.WriteLine($"{result} {msg}");
        }
    }
    
    private static bool IsPerfect(int value)
    {
        int result = 0;

        for (int i = 1; i <= value / 2; i++)
        {
            if (value % i == 0)
            {
                result += i;
            }
        }

        return value == result;           
    }
}