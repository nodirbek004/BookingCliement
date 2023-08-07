using BookingCliement.Moldels;
using BookingCliement.Services;

namespace BookingCliement.UIs.Windows;

public class Update
{
    public Update() 
    {
        Console.WriteLine(" Telefon nomeringizni kiriting");
        Console.WriteLine("Namuna:+998881813525");
        string phonenumber = Console.ReadLine();
        Console.WriteLine("YangiIsmingizni kiriting");
        string firstname = Console.ReadLine();
        Console.WriteLine("Yangi Familyangizni kiriting");
        string lastname = Console.ReadLine();


        if (firstname.Length == 0 || lastname.Length == 0 || phonenumber.Length == 0)
        {
            Console.WriteLine("malumotlar xato kiritilda boshqadan uring");
            Update update = new Update();
        }
        else
        {
        User user = new User();
            user.FirstName = firstname;
            user.Lastname = lastname;
            user.PhoneNumber = phonenumber;
            UserService userService = new UserService();
            userService.Update(user);   
            firstwindow firstwindow =new firstwindow();

        }
    }
}
