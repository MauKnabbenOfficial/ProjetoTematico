using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Application;

public class UserDto
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public UserDto(string login, string password)
    {
        Login = login;
        Password = password;
    }
}
