class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay.TakeLast(1).ToArray()[0];

    public void IncrementTodaysCount()
    { 
        birdsPerDay[birdsPerDay.Length-1]++;
    }

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
    {
        int totalBirds = 0;
        foreach (int bird in birdsPerDay.Take(numberOfDays))
        {
            totalBirds += bird;
        }
        return totalBirds;
    }

    public int BusyDays()
    {
        int totalBirds = 0;
        foreach (int bird in birdsPerDay)
        {
            if (bird >= 5)
            {
                totalBirds ++;
            }
        }
        return totalBirds;
    }
}
