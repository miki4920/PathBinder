using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext
    : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<FileItem> Files => Set<FileItem>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        base.OnModelCreating(b);
        b.Entity<FileItem>()
         .HasOne(f => f.User)
         .WithMany()            
         .HasForeignKey(f => f.UserId)
         .OnDelete(DeleteBehavior.Cascade);
        b.Entity<FileItem>()
         .HasIndex(f => f.UserId);
    }
}