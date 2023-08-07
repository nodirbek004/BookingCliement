using BookingCliement.Helpers;
using BookingCliement.Moldels;

namespace BookingCliement.Interfaces;

public  interface IUserService
{
    Responce<User> Create(User user);
    User Update(User user);
    bool Delete(string phoneNumber);
    User GetById(string phoneNumber);
    List<User> GetAll();

}
