using Microsoft.EntityFrameworkCore;
using Netcode.Models;

namespace Netcode.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Netcode.Models.Faculty> Faculty { get; set; } = default!;
        public DbSet<Sanpham> Sanpham { get; set; }
        public DbSet<Khachhang> Khachhang { get; set; }
    }
}