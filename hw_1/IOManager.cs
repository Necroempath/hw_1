namespace hw_1;

public class IOManager
{
     public enum ReportCode
    {
        Success = 1,
        InvalidData = 0,
        IncorrectData = -1,
        EmptyFiled = -2
    }
    
    public static void DisplayTasks(List<Task> tasks)
    {
        foreach (Task task in tasks)
        {
            Console.WriteLine(task.Description);
        }
    }
    
    public static ReportCode ValidityCheck(string data, out int result, int min = int.MinValue, int max = int.MaxValue)
    {
        if (int.TryParse(data, out int number))
        {
            if (number >= min && number <= max)
            {
                result = number;
                return ReportCode.Success;
            }
            else
            {
                result = default;
                return ReportCode.InvalidData;
            }
        }
        else
        {
            result = default;
            return ReportCode.IncorrectData;
        }
    }
    
    public static ReportCode ValidityCheck(string data, out float result, float min = float.MinValue, float max = float.MaxValue)
    {
        if (float.TryParse(data, out float number))
        {
            if (number >= min && number <= max)
            {
                result = number;
                return ReportCode.Success;
            }
            else
            {
                result = default;
                return ReportCode.InvalidData;
            }
        }
        else
        {
            result = default;
            return ReportCode.IncorrectData;
        }
    }
    
    public static ReportCode GetValidValue(string message, out int result, int min = int.MinValue, int max = int.MaxValue)
    {
        Console.Write(message);

        return ValidityCheck(Console.ReadLine(), out result, min, max);
    }
    
    public static ReportCode GetValidValue(string message, out float result, float min = int.MinValue, float max = int.MaxValue)
    {
        Console.Write(message);

        return ValidityCheck(Console.ReadLine(), out result, min, max);
    }
    public static bool ReportHandler(ReportCode code, string invalidMsg = "Invalid input data", string incorrectMsg = "Incorrect input data", string emptyMsg = "Error. Empty filed")
    {
        switch (code)
        {
            case ReportCode.Success:
                return true;
            case ReportCode.InvalidData:
                Console.WriteLine(invalidMsg);
                return false;
            case ReportCode.IncorrectData:
                Console.WriteLine(incorrectMsg);
                return false;
            case ReportCode.EmptyFiled:
                Console.WriteLine(emptyMsg);
                return false;
            default:
                return false;
        }
    }
}