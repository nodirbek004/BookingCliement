using BookingCliement.Interfaces;
using BookingCliement.Moldels;
using BookingCliement.Constants;
using Newtonsoft.Json;
using BookingCliement.Helpers;
using System.Globalization;
using BookingCliement.UIs.Windows;

namespace BookingCliement.Services;

public class UserService : IUserService
{
    public UserService() 
    {
        string source = File.ReadAllText(DbPath.USER_DB_PATH);

        if (string.IsNullOrEmpty(source))
        {
            File.WriteAllText(DbPath.USER_DB_PATH, "[]");
        }

    }    
    public Responce<User> Create(User user)
    {
        string source=File.ReadAllText(DbPath.USER_DB_PATH);
        if (string.IsNullOrEmpty(source)) 
        {
            File.WriteAllText(DbPath.USER_DB_PATH, "[]");
        }
        List<User> users = JsonConvert.DeserializeObject<List<User>>(source);

        User existUser=users.FirstOrDefault(i=>i.PhoneNumber==user.PhoneNumber);

        if (existUser is not null)
            return new Responce<User>
            {
                StatusCode = 404,
                Message = "This student not fount",
                Data = null

            };

        string userId = File.ReadAllText(DbPath.USER_ID_PATH);

        if (string.IsNullOrEmpty(userId)) 
        {
            userId = "1";
        }
        user.Id = long.Parse(userId);

        users.Add(user);
        source = JsonConvert.SerializeObject(users, Formatting.Indented);

        File.WriteAllText(DbPath.USER_DB_PATH, source);
        File.WriteAllText(DbPath.USER_ID_PATH, $"{user.Id + 1}");
        firstwindow firstwindow =new firstwindow();

        return new Responce<User>
        {
            StatusCode = 200,
            Message = "Success",
            Data = user

        };



    }

    public bool Delete(string phoneNumber)
    {
        string source = File.ReadAllText(DbPath.USER_DB_PATH);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(source);

        User existUser=users.FirstOrDefault(i=>  i.PhoneNumber==phoneNumber);
        if (existUser is null)
            return false;


        users.Remove(existUser);

        source=JsonConvert.SerializeObject(users,Formatting.Indented);
        File.WriteAllText(DbPath.USER_DB_PATH , source);
        return true;

        
    }

    public  List<User> GetAll()
    {
        string source = File.ReadAllText(DbPath.USER_DB_PATH);
        return JsonConvert.DeserializeObject<List<User>>(source);

    }

    public User GetById(string phoneNumber)
    {
        string source =File.ReadAllText(DbPath.USER_DB_PATH);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(source);
        User existuser =users.FirstOrDefault(u => u.PhoneNumber==phoneNumber);

        if (existuser == null)
            return null;
        return existuser;

    }

    public User Update(User user)
    {
        List<User> users =GetAll();
        User existuser =users.FirstOrDefault(i=>i.PhoneNumber==user.PhoneNumber);
        if (existuser == null)
            return null;

        existuser.PhoneNumber=user.PhoneNumber;
        existuser.FirstName = user.FirstName;
        existuser.Lastname = user.Lastname;

        string json =JsonConvert.SerializeObject(users,Formatting.Indented);
        File.WriteAllText(DbPath.USER_DB_PATH, json);

        return user;
    }

 
    }




