using BookingCliement.Moldels;
using BookingCliement.Services;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;

namespace BookingCliement.UIs.Windows;

public class firstwindow
{
    public firstwindow() 
    {
        Console.WriteLine($@"

                       1.RO'YXATDAN UTISH
                       2.KIRISH
                       3.FOYDALANUVCHINI UCHIRISH
                       4.FAYDALANUVCHILARNI KORISH
                       5.MALUMOTLARNI YANGILASH

");
        Console.WriteLine("======>");
        int a=Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                booking booking =new booking();
                break;
            case 2:
                Console.WriteLine("TELEFON NOMERINGIZNI KIRITING  ===>");
                string phoneNumber=Console.ReadLine();
                UserService userService = new UserService();
                var name =userService.GetById(phoneNumber);
                Console.WriteLine($"Assalomu aleykum {name.FirstName} qaysi bolimdan foydalanmoqchisiz");
                Window window = new Window();
                break;
            case 3:
                Console.WriteLine("TELEFON NOMERINGIZNI KIRITING ===>");
                string phoneNumber1 = Console.ReadLine();
                UserService userService1 = new UserService();
                if (userService1.Delete(phoneNumber1))
                {
                    Console.WriteLine("SUCCESFUL");
                }
                else { Console.WriteLine("BUNDAY FOYDALANUVCHI MAVJUD EMAS"); }
                Window window2 = new Window();
                break;
            case 4:
                UserService userService2 = new UserService();
                var all =userService2.GetAll();
                foreach(var item in all) { Console.WriteLine(item); }
                Window window1 = new Window();
                break;
            case 5:
                Update update = new Update();
                break;

        } 
    }    
}
