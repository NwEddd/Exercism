class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int time)
    {
        return ExpectedMinutesInOven()-time;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers*2;
    }

    public int ElapsedTimeInMinutes (int layersAdded, int timePassed)
    {
        return (layersAdded * 2) + timePassed;
    }


}
