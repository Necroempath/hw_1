namespace hw_1;

class Program
{
    static void Main(string[] args)
    {
        var tasks = new List<Task>
        {
            new FizzBuzz(),
            new PercentageCalculation(),
            new NumberFormation(),
            new SwapDigits(),
            new DateToSeasonAndWeekday(),
            new TemperatureConversion(),
            new EvenNumbersIn(),
            new ArmstrongNumber(),
            new PerfectNumber()
        };

            IOManager.DisplayTasks(tasks);
        
            if (IOManager.ReportHandler(IOManager.GetValidValue("Choose task by corresponding number: ", out int option,
                    min: 1, max: tasks.Count + 1)))
            {
                Console.Clear();
                
                tasks[option - 1].Execute();
            }
    }
}