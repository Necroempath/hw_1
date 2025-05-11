namespace hw_1;

public class TemperatureConversion : Task
{
    private enum TemperatureScale
    {
        Celsius = 1,
        Fahrenheit
    }
    
    public override string Description => "Task 6\nConverts temperature between Celsius and Fahrenheit.\n";

    public override void Execute()
    {
        TemperatureScale temperatureScale = default;
        TemperatureScale temperatureScaleOpposite = default;
        float tempMin = default;
        string name = default;
        
        if (IOManager.ReportHandler(
                IOManager.GetValidValue("Choose temperature scale type\n\t1.Celsius\n\t2.Fahrenheit\n", out float option, 1,
                    2), invalidMsg: "Invalid temperature scale type"))
        {
            switch (option)
            {
                case 1:
                    temperatureScale = TemperatureScale.Celsius;
                    temperatureScaleOpposite =  TemperatureScale.Fahrenheit;
                    tempMin = -273.15f;
                    name = "Celsius";
                    break;
                case 2:
                    temperatureScale = TemperatureScale.Fahrenheit;
                    temperatureScaleOpposite = TemperatureScale.Celsius;
                    tempMin = -459.67f;
                    name = "Fahrenheit";
                    break;
            }
        
            if (IOManager.ReportHandler(IOManager.GetValidValue($"Enter temperature in {name}:\t", out float result,
                    tempMin), invalidMsg: $"Invalid temperature. Min accessible temp in {temperatureScale} scale is {tempMin}"))
            {
                Console.WriteLine($"{result} in {temperatureScale} equals {ConvertTemperature(result, temperatureScale)} in {temperatureScaleOpposite}");
                
            }
        }
        
    }

    private static float ConvertTemperature(float result, TemperatureScale temperatureScale)
    {
        switch (temperatureScale)
        {
            case TemperatureScale.Celsius:
                return result * 9 / 5 + 32;
            case TemperatureScale.Fahrenheit:
                return (result - 32) * 5 / 9;
            default:
                return default;
        }
    }
}
