using Microsoft.EntityFrameworkCore;
using todo_api.Models;

namespace todo_api.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<Todo> Todos { get; set; }
}