using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentRegistrationWithAPI.Models
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Students> Student { get; set; }
    }
}