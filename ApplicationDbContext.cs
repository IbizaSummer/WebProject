using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // 在这里添加你的DbSet属性，例如：
    public DbSet<User> Users { get; set; }
    public DbSet<Photo> Photos { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

public class Photo
{
    public int Id { get; set; }
    public string FileName { get; set; }
    public byte[] ImageData { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
