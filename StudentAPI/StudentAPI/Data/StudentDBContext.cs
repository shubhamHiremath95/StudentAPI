using Microsoft.EntityFrameworkCore;
using StudentAPI.Model;

using System.Collections.Generic;

namespace StudentAPI.Data
{
    public class StudentDBContext : DbContext
    {
        

        public StudentDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }    

        
    }
}
