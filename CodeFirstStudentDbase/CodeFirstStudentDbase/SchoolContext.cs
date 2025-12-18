using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeFirstStudentDbase.StudentConfiguration;

namespace CodeFirstStudentDbase
{
    public class SchoolContext: DbContext
    {
        public SchoolContext() : base("SchoolDB-CodeFirstStudent")
        {
            Database.SetInitializer<SchoolContext>(new SchoolDBInitializer());
        }

       

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}
