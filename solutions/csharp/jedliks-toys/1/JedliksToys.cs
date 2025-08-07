using System.Reflection.Metadata.Ecma335;

class RemoteControlCar
{
    public int Precentage = 100;
    public int Meters = 0;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {this.Meters} meters";
    }

    public string BatteryDisplay()
    {
        string a = (this.Precentage > 0) ? $"Battery at {this.Precentage}%" : $"Battery empty";
        return a;
    }

    public void Drive()
    {
        if (this.Precentage <= 0)
            return;

        this.Meters += 20;
        this.Precentage -= 1;
        BatteryDisplay();
    }
}
