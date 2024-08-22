using Context;
using Models.Users;
using Services.Utils;

namespace Services.Users;

public class UserService
{
    private readonly KanbanContext _context;
    private readonly PasswordUserHasher userHasher;
    public UserService(KanbanContext context,PasswordUserHasher passwordUserHasher)
    {   
        _context=context;
        userHasher=passwordUserHasher;
    }

    public User Create(User user)
    {
        user.Password=userHasher.HashPassword(user,user.Password!);
        _context.Users.Add(user);
        _context.SaveChanges();
        return user;
    }
}