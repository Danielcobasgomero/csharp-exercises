static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double SuccessRate;
        if (speed == 0)
        {
            SuccessRate = 0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            SuccessRate = 100;
        }
        else if (speed >= 5 && speed <= 8)
        {
            SuccessRate = 90;
        }
        else if (speed == 9)
        {
            SuccessRate = 80;
        }
        else
        {
            SuccessRate = 77;
        }

        Console.WriteLine(SuccessRate / 100);

        return SuccessRate / 100;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return 221 * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double carsPerMinute = 221.0 / 60.0;
        double carsPerSpeed = carsPerMinute * speed;
        Double successRate = SuccessRate(speed);

        return (int)Math.Floor(carsPerSpeed * successRate);
    }
}
