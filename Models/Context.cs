using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RegistroNotasApi.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options): base(options){

        }
        public DbSet<Alternatives> alternatives{get; set;}
        public DbSet<Answer> answers{get; set;}
        public DbSet<Chapter> chapters{get; set;}
        public DbSet<Course> courses{get; set;}
        public DbSet<Exam> exams{get; set;}
        public DbSet<Facultad> facultads{get; set;}
        public DbSet<PS> ps{get; set;}
        public DbSet<Question> questions{get; set;}
        public DbSet<Registration> registrations{get; set;}
        public DbSet<Semester> semesters{get; set;}
        public DbSet<Student> students{get; set;}
        public DbSet<Teacher> teachers{get; set;}
        
    }
}