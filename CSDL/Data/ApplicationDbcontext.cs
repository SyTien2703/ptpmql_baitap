using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSDL.Models;

namespace CSDL.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options){}

        public DbSet<Person> Person {get; set ;}
        public DbSet<Employee> Employee { get; set; } = default!;
    }
}