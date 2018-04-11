using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StudentCourses.Models;

namespace StudentCourses.DAL
{
    public class UniversityInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<UniversityContext>
    {
        protected override void Seed(UniversityContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Arwa",LastName="Alromaih",EnrollmentDate=DateTime.Parse("2018-04-01")},
            new Student{FirstMidName="Sarah",LastName="Alrabeeah",EnrollmentDate=DateTime.Parse("2018-04-01")},
            new Student{FirstMidName="Asma",LastName="Alzahrani",EnrollmentDate=DateTime.Parse("2018-04-01")},
            new Student{FirstMidName="Ghada",LastName="Almarri",EnrollmentDate=DateTime.Parse("2018-04-01")},
            new Student{FirstMidName="Ohoud",LastName="Alshairy",EnrollmentDate=DateTime.Parse("2018-04-01")},
            new Student{FirstMidName="Kawthar",LastName="Albuali",EnrollmentDate=DateTime.Parse("2018-04-01")},
            new Student{FirstMidName="Leana",LastName="Alkhuwaildi",EnrollmentDate=DateTime.Parse("2018-04-01")},
            new Student{FirstMidName="Raneem",LastName="Alnaseer",EnrollmentDate=DateTime.Parse("2018-04-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseNumber=3351,Title="Principles of Software Eng'g"},
            new Course{CourseNumber=4412,Title="E-Commerce",Credits=3,},
            new Course{CourseNumber=2232,Title="Calculus for Students of Busi"},
            new Course{CourseNumber=3323,Title="Business Intelligence"},
            new Course{CourseNumber=2245,Title="Network Security"},
            new Course{CourseNumber=2243,Title="Cloud Computing"},
            new Course{CourseNumber=3322,Title="Learning Outcome Asse"}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=20119234,CourseNumber=3351},
            new Enrollment{StudentID=20119234,CourseNumber=4412},
            new Enrollment{StudentID=20119234,CourseNumber=2232},
            new Enrollment{StudentID=20120897,CourseNumber=3323},
            new Enrollment{StudentID=20120897,CourseNumber=3322},
            new Enrollment{StudentID=20120897,CourseNumber=2243},
            new Enrollment{StudentID=20138123,CourseNumber=3351},
            new Enrollment{StudentID=20141981,CourseNumber=3351,},
            new Enrollment{StudentID=20141981,CourseNumber=4412},
            new Enrollment{StudentID=20158763,CourseNumber=2232},
            new Enrollment{StudentID=20161781,CourseNumber=3323},
            new Enrollment{StudentID=20179789,CourseNumber=3141},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}