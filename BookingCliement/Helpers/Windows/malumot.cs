using System.Threading.Channels;

namespace BookingCliement.UIs.Windows;

public class malumot
{
    public malumot()
    {
        Console.WriteLine(@$"
       
                           ░█████╗░░██████╗░██████╗░█████╗░██╗░░░░░░█████╗░███╗░░░███╗██╗░░░██╗
                           ██╔══██╗██╔════╝██╔════╝██╔══██╗██║░░░░░██╔══██╗████╗░████║██║░░░██║
                           ███████║╚█████╗░╚█████╗░███████║██║░░░░░██║░░██║██╔████╔██║██║░░░██║
                           ██╔══██║░╚═══██╗░╚═══██╗██╔══██║██║░░░░░██║░░██║██║╚██╔╝██║██║░░░██║
                           ██║░░██║██████╔╝██████╔╝██║░░██║███████╗╚█████╔╝██║░╚═╝░██║╚██████╔╝
                           ╚═╝░░╚═╝╚═════╝░╚═════╝░╚═╝░░╚═╝╚══════╝░╚════╝░╚═╝░░░░░╚═╝░╚═════╝░ 

                               ░█████╗░██╗░░░░░███████╗██╗░░░██╗██╗░░██╗██╗░░░██╗███╗░░░███╗
                               ██╔══██╗██║░░░░░██╔════╝╚██╗░██╔╝██║░██╔╝██║░░░██║████╗░████║
                               ███████║██║░░░░░█████╗░░░╚████╔╝░█████═╝░██║░░░██║██╔████╔██║
                               ██╔══██║██║░░░░░██╔══╝░░░░╚██╔╝░░██╔═██╗░██║░░░██║██║╚██╔╝██║
                               ██║░░██║███████╗███████╗░░░██║░░░██║░╚██╗╚██████╔╝██║░╚═╝░██║
                               ╚═╝░░╚═╝╚══════╝╚══════╝░░░╚═╝░░░╚═╝░░╚═╝░╚═════╝░╚═╝░░░░░╚═╝

                               BIZNING KOMPANYA SIZNING UYINGIZNI CHIZROYLI BOLISHIGA YORDAM
                               BERADI YANI BIZNING XIZMATLARIMIZ GILAM YUVISH VA UYLARNI TOZA
                               LASHADAN IBORAT BU XIZMATLARSDAN FOYDALANISH UCHUN 1 NI BOSING

");
        Console.WriteLine("=====>");
        int a=Convert.ToInt32(Console.ReadLine());
        if (a == 1)
        {
           firstwindow firstwindow=new firstwindow();
            Console.Clear();
        }
    }
}
