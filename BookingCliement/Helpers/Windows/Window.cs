using BookingCliement.Helpers;
using System.ComponentModel;

namespace BookingCliement.UIs.Windows;

public class Window
{
    public Window() 
    {
        Console.WriteLine(@$"
                        +-----------------------------------------+
                        |                  MENU                   |
                        |             1.GILAM YUVISH =>15000      |
                        |             2.UYLARNI TOZALASH=>50000   |
                        +-----------------------------------------+
");
        Console.WriteLine("SIZ AYSI BOLIMDAN FOYDALANMOQCHISIZ");
        int a=Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("necha soatga band qilmoqchisiz");
                int b=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"sizdan {15000*b}so'm boldi ");
                int x = 1;
                while(x>0)
                {
                    TimeNow timeNow1 = new TimeNow(b, 1);
                    x = x - 1;
                } 
                WaitTime waitTime1 = new WaitTime(1);

                break;
            case 2:
                Console.WriteLine("necha soatga band qilmoqchisiz");
                int c=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"sizdan {c*50000} som boldi");
                int i= 1;
                while(i>0) {
                    TimeNow timeNow = new TimeNow(c, 2);
                    i = i - 1;

                }
                WaitTime waitTime = new WaitTime(2);
                break;
        }
    }
}
