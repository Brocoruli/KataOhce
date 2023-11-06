using KataOhce;

public class MyClock : IClock
{
    public int GetHour()
    {
        return DateTime.Now.Hour;
    }
}