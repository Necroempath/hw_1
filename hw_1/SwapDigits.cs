namespace hw_1;

public class SwapDigits : Task
{
    public override string Description => "Task 4\nSwaps specified digits in a six-digit number.\n";

    public override void Execute()
    {
        if (IOManager.ReportHandler(IOManager.GetValidValue("Enter a six-digit number: ", out int value, 100000, 999999))
            && IOManager.ReportHandler(IOManager.GetValidValue("Enter position of first number: ", out int firstPos, 1, 6), invalidMsg: "Invalid input. Position must be between 1 and 6")
            && IOManager.ReportHandler(IOManager.GetValidValue("Enter position of first number: ", out int secondPos, 1, 6), invalidMsg: "Invalid input. Position must be between 1 and 6"))
        {
            char[] result = value.ToString().ToCharArray();
            (result[firstPos - 1], result[secondPos - 1]) = (result[secondPos - 1], result[firstPos - 1]);

            Console.WriteLine("Result: " + result);
        }
    }
}
