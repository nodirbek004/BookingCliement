using BookingCliement.Constants;
using BookingCliement.UIs.Windows;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel.Design;

namespace BookingCliement.Helpers;

public class WaitTime
{
    public WaitTime(int a)
    {
        DateTime now = DateTime.Now;
        DateTime startOfYear = new DateTime(now.Year, 1, 1);

        TimeSpan timeSinceStartOfYear = now - startOfYear;
        int totalSeconds = (int)timeSinceStartOfYear.TotalSeconds;
        if (a == 1)
        {
            string time = File.ReadAllText(DbPath.USER_TIME_UY_PATH);
            
            int number=int.Parse(time);
            if (number > totalSeconds)
            {
                a=number-totalSeconds;
                int minut = a % 3600 / 60;
                int soat = a / 3600;
                Console.WriteLine($" sizning navbatingiz {soat}:{minut} keyin keladi");
                Console.WriteLine("BIZNING XIZMATLARIMIZDAN FOYDALANGANINGIZ UCHUN RAXMAT");
                firstwindow firstwindow =new firstwindow();

            }
            else
            {
                Console.WriteLine("succesful");
                firstwindow firstwindow =new firstwindow();
            }
        }
        else if(a == 2)
        {
            string time = File.ReadAllText(DbPath.USER_TIME_GILAM_PATH);

            int number = int.Parse(time);
            if (number > totalSeconds)
            {

                Console.WriteLine($" sizning navbatingiz {(number - totalSeconds) / 3600} soadan keyin keladi");
                firstwindow firstwindow = new firstwindow();

            }
            else
            {
                Console.WriteLine("SIZNING NAVBATINGIZ");
                Console.WriteLine("BIZNING XIZMATLARIMIZDAN FOYDALANGANINGIZ UCHUN RAXMAT");
                firstwindow firstwindow = new firstwindow();
            }
        }
    
        
    }
}
