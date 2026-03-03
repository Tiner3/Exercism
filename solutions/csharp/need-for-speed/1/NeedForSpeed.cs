class RemoteControlCar
{
    public int Speed { get; set; }
    public int BatteryDrain { get;  set; }
    public int MetersDriven { get; set; }
    public int BatteryLeft { get; set; }
    public RemoteControlCar(int speed,int BatteryDrain) 
    { 
        this.Speed = speed;
        this.BatteryDrain = BatteryDrain;
        this.MetersDriven = 0;
        this.BatteryLeft = 100;
    }

    public bool BatteryDrained()
    {
        return (BatteryLeft < BatteryDrain) ? true : false;
    }

    public int DistanceDriven()
    {
        return MetersDriven;
    }

    public void Drive()
    {
        if (BatteryLeft < BatteryDrain)
            return;

        BatteryLeft -= BatteryDrain;
        MetersDriven += Speed;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    public int Distance { get; set; }

    public RaceTrack(int distance)
    {
        this.Distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (Distance > car.DistanceDriven()) 
        {
            if (car.BatteryLeft < car.BatteryDrain)
                return false;
            car.Drive();
        }
        return true;
    }
}
