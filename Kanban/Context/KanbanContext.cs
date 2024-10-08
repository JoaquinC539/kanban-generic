using Microsoft.EntityFrameworkCore;
using Models.Teams;
using Models.Users;

namespace Context;

public class KanbanContext:DbContext
{
    public KanbanContext(DbContextOptions<KanbanContext> options):base(options)
    {

    }
    public DbSet<Team> Teams=>Set<Team>();
    public DbSet<User> Users=>Set<User>();
}