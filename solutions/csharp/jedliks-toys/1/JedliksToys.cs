class RemoteControlCar
{
    public int Meters = 0;
    public int Battery = 100;
    /*
    covers 20 meters 
    cost 
    1% percent of the battery
    */
    public static RemoteControlCar Buy()
    {
        var newRemoteControlledCar = new RemoteControlCar();
        return newRemoteControlledCar;
    }

    public string DistanceDisplay()
    {
        return $"Driven {Meters} meters";
    }

    public string BatteryDisplay()
    {
        if(Battery > 0){
            return $"Battery at {Battery}%";
        }else{
            return "Battery empty";
        }
    }

    public void Drive()
    {
        if(Battery > 0){
            Meters += 20;
            Battery -= 1;
        }
    }
}
