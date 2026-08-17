class RemoteControlCar
{
    private int distance = 0;
    private int curBattery = 100;

    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if( curBattery >0)
            return $"Battery at {curBattery}%";
        return "Battery empty";
    }

    public void Drive()
    {
        if ( curBattery > 0){
            distance += 20;
            curBattery -=1;
        }
    }
}
