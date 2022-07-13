using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class DataContext : DbContext
    {
        public DataContext() : base("FaceRecognizaion")
        {
            if (!Database.Exists("FaceRecognizaion"))
                Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());

        }
            public DbSet<School> schools { get; set; }
            public DbSet<Attendance> attendances { get; set; }
            public DbSet<Authentication> authentications { get; set; }
            public DbSet<Roles> roles { get; set; }
            public DbSet<SchoolClass> schoolClasses { get; set; }
            public DbSet<SchoolClassSections> SchoolClassSections { get; set; }
            public DbSet<SchoolShift> schoolShifts { get; set; }
            public DbSet<Student> students { get; set; }
            public DbSet<StudentClassSections> studentClassSections { get; set; }
            public DbSet<TeacherClass> teacherClasses { get; set; }
            public DbSet<TeacherClassSections> TeacherClassSections { get; set; }
            public DbSet<UserManagement> userManagements { get; set; }
            public DbSet<StudentClass> studentClasses { get; set; }
    }
}

