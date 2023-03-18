using BlazorStudentRegistration.Shared.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazorStudentRegistration.Server.DbModel
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options)
        : base(options)
        {
        }
        
        public DbSet<Students> Students { get; set; }
    }
}
