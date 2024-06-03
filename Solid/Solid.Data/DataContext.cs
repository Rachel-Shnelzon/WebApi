using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Solid.Data
{
    public class DataContext
    {
        public List<Course> Courses { get; set; }
        public List<Lecture> Lectures { get; set; }
        public List<Pupil> Pupils { get; set; }
        public DataContext()
        {
            Courses = new List<Course>() { new Course() { Id = 1, Name = "C#",
                NumOfStudents = 10 } };
            Lectures = new List<Lecture>() { new Lecture() { Id = 2, Name = "Prag",
                City = "BneyBrak", Phone = "0527684393", Salary = 8000 } };
            Pupils = new List<Pupil>(){new Pupil(){Id=3, Name="Yehudit",
                Phone="0527602359",Address="breslev", Age=19 }};
        }
    }
}
