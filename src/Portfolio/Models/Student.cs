using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Portfolio.Models
{
    public class Student
    {
        public int Id { get; set; }

        public int Matrikelnummer { get; set; }

        public string Name { get; set; }

        public string Kurs { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}