namespace hw_1;

public class FizzBuzz : Task
{
    public override string Description => "Task 1\nDetermines if a number is divisible by 3 and/or 5 and prints Fizz, Buzz, or Fizz Buzz.\n";

    public override void Execute()
    { 
        if(IOManager.ReportHandler(IOManager.GetValidValue("Enter a number: ", out int number)))
        {
            string result = number.ToString();
            
            if(number % 3 == 0 && number % 5 == 0) result = "Fizz Buzz";
        
            else if(number % 3 == 0) result = "Fizz";
        
            else if(number % 5 == 0) result = "Buzz";

            Console.WriteLine("Result: " + result);
        }
    }
}