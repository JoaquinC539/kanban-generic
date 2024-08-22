using Microsoft.AspNetCore.Identity;
using Models;

namespace Services;

public class PasswordUserHasher
{

    private readonly PasswordHasher<User> _passwordHasher;

    public PasswordUserHasher()
    {
        _passwordHasher=new PasswordHasher<User>();
    }

    public string HasPassword(User user,string password)
    {
        return _passwordHasher.HashPassword(user,password);
    }
    public bool VerifyPassword(User user, string password)
    {
        var result=_passwordHasher.VerifyHashedPassword(user,user.Password,password);
        return result==PasswordVerificationResult.Success;
    }

}