using System.Security.Cryptography.X509Certificates;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int speed;
    public int batteryDrain;
    public int distanceDrive;
    public int battery;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.distanceDrive = 0;
        this.battery = 100;
    }

    public bool BatteryDrained()
    {
        if (battery < batteryDrain)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public int DistanceDriven()
    {
        return distanceDrive;
    }

    public void Drive()
    {
        if(battery >= batteryDrain)
        {
            distanceDrive += speed;
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
    public int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        if ((car.battery / car.batteryDrain) * car.speed >= distance)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
