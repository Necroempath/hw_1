namespace hw_1;

public class DateToSeasonAndWeekday : Task
{
    public override string Description => "Task 5\nDetermines the season and day of the week from a given date.\n";

    public override void Execute()
    {
        Console.WriteLine("Enter data (e.g 11.07.2021): ");
        
        string date = Console.ReadLine();
        
        int[] daysInMonth = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
        
        string[] str = date.Split('.');
        
        if (str.Length != 3)
        {
                IOManager.ReportHandler(IOManager.ReportCode.IncorrectData, incorrectMsg: "Error. Incorrect date format");
                return;
        }
        
        if(IOManager.ReportHandler(IOManager.ValidityCheck(str[1], out int validMonth, 1, 12), invalidMsg: "Invalid Month data")
           && IOManager.ReportHandler(IOManager.ValidityCheck(str[0], out int validDay, 1, daysInMonth[validMonth - 1]), invalidMsg: "Invalid Day data")
           && IOManager.ReportHandler(IOManager.ValidityCheck(str[2], out int validYear, 0), invalidMsg: "Invalid Year data"))
        { 
            Console.WriteLine($"{date}: {GetSeason(validMonth, validDay)}, {GetWeekday(validDay, validMonth, validYear)}");
        }
    }

    private string GetWeekday(int day, int month, int year)
    {
        string[] daysOfWeek = ["Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"];

        if (month == 1 || month == 2)
        {
            month += 12;
            year--;
        }
        
        int K = year % 100;
        int J = year / 100;

        int week = (day + 13 * (month + 1) / 5 + K + K / 4 + J / 4 + 5 * J) % 7;
        
        return daysOfWeek[week];
    }

    public static string GetSeason(int month, int day)
    {
        switch (month)
        {
            case 12:
                return (day < 21) ? "Autumn" : "Winter";
            case 1:
            case 2:
                return "Winter";
            case 3:
                return (day < 20) ? "Winter" : "Spring";
            case 4:
            case 5:
                return "Spring";
            case 6:
                return (day < 21) ? "Spring" : "Summer";
            case 7:
            case 8:
                return "Summer";
            case 9:
                return (day < 23) ? "Summer" : "Autumn";
            case 10:
            case 11:
                return "Autumn";
            default:
                return "Invalid month";
        }
    }
}