namespace hw_1;

public class NumberFormation : Task
{
    public override string Description => "Task 3\nCreates a number from four entered digits.\n";

    public override void Execute()
    {
        string result = "";

        for (int i = 0; i < 4; i++)
        {
            if (IOManager.ReportHandler(IOManager.GetValidValue("Enter a digit [0-9]: ", out int digit, 
                    min: 0, max: 9)))
            {
                result += digit.ToString();
            }
            else
            {
                return;
            }
        }
        
        Console.WriteLine("result: " + result);
    }
}