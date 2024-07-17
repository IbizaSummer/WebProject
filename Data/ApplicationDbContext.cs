using Microsoft.EntityFrameworkCore;

namespace WebProject.Data // 使用你的实际命名空间
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // 添加你的 DbSet 属性
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
}
