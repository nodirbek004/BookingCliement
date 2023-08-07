using BookingCliement.Moldels;
using BookingCliement.Services;

namespace BookingCliement.UIs.Windows;

public class booking
{
   public booking() 
    {


        Console.WriteLine("Ismingizni kiriting");
        string firstname=Console.ReadLine();
        Console.WriteLine("Familyangizni kiriting");
        string lastname=Console.ReadLine();
        Console.WriteLine("Telefon nomeringizni kiriting");
        Console.WriteLine("Namuna:+998881813525");
        string phonenumber=Console.ReadLine();




        if (firstname.Length ==0 || lastname.Length ==0 || phonenumber.Length==0 )
        {
            Console.WriteLine("malumotlar xato kiritilda boshqadan uring");
            booking booking = new booking();
        }
        else
        {
            User user = new User();
            user.FirstName = firstname;
            user.Lastname = lastname;
            user.PhoneNumber = phonenumber;
            UserService userService = new UserService();
            userService.Create(user);
        }
    }
}
