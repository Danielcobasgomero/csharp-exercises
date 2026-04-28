class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int battery;
    private int batteryDrain;
    private int meters;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.battery = 100;
        this.batteryDrain = batteryDrain;
        this.meters = 0;
    }

    public bool BatteryDrained() => battery < batteryDrain;
    public int DistanceDriven() => meters;

    public void Drive()
    {
        //  updates the number of meters driven based on the car's speed.
        if (!BatteryDrained())
        {
            meters += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    int distance = 800;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.BatteryDrained() == false)
        {
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}

