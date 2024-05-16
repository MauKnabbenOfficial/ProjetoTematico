using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Application;

public class UserService
{
    public static bool Login(string login, string password)
    {
        var userDto = new UserDto(login, password);

        Domain.User user = new Domain.User(userDto.Login, userDto.Password);

        return user.ValidateLogin(user);
    }
}
