using BookingCliement.Constants;

namespace BookingCliement.Helpers;

public class TimeNow
{
    public TimeNow(int time,int a)
    {

        DateTime now = DateTime.Now;
        DateTime startOfYear = new DateTime(now.Year, 1, 1);
        TimeSpan timeSinceStartOfYear = now - startOfYear;
        int totalSeconds = (int)timeSinceStartOfYear.TotalSeconds;
        int timebooking = totalSeconds+ time * 3600;
        if (a == 1)
            File.WriteAllText(DbPath.USER_TIME_GILAM_PATH, $"{timebooking}");
        else if (a == 2) {
            File.WriteAllText(DbPath.USER_TIME_UY_PATH, $"{timebooking}");
        }
    }

}
