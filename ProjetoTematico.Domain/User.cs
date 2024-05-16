using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTematico.Domain;

public class User
{
    private const string _userName = "teste";
    private const string _password = "123";
    [Key]
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public User(string login, string password)
    {
        Login = login;
        Password = password; 
        //Implementar banco
    }
    public bool ValidateLogin(User user)
    {
        if (user.Login.Equals(_userName) && user.Password.Equals(_password))
        {
            return true;
        }
        return false;
    }
}
