namespace hw_1;

public class PercentageCalculation : Task
{
    public override string Description => "Task 2\nCalculates a specified percentage of a given number.\n";

    public override void Execute()
    {
        if (IOManager.ReportHandler(IOManager.GetValidValue("Enter a number: ", out float number))
            && IOManager.ReportHandler(IOManager.GetValidValue("Enter a percent: ", out int percent, min: 0), incorrectMsg:"Invalid input. Percent value must be between 0 and 100."))
        {
            Console.WriteLine("Result: " + number * percent / 100);
        }
    }
}