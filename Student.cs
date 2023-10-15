using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
   public  class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }     
    }
    public class studentlistted
    {

        List<Student> Allstudent = new List<Student>() {
        new Student() { StudentID = 1, StudentName = "John", Age = 13,} ,
        new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  Age = 20 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
        };
        public studentlistted()
        {
            Allstudent.Add(new Student() { StudentID = 6, StudentName = "Subbu", Age = 26 });
            Allstudent.Add(new Student() { StudentID = 7, StudentName = "Sentamil", Age = 27 });
            Allstudent.Add(new Student() { StudentID = 8, StudentName = "Thiyagu", Age = 33 });
            Allstudent.Add(new Student() { StudentID = 9, StudentName = "Saravanan", Age = 28 });
            Allstudent.Add(new Student() { StudentID = 10, StudentName = "Mani", Age = 26 });
            Allstudent.Add(new Student() { StudentID = 11, StudentName = "Ram", Age = 26 });
            Allstudent.Add(new Student() { StudentID = 12, StudentName = "Mathi", Age = 26 });
            Allstudent.Add(new Student() { StudentID = 13, StudentName = "Sathiya", Age = 26 });
        }

    public void GetStudent()
        {
            // first one is returen type IEnumrable<stdent> 
            var studentlist = Allstudent.Where(x => x.Age > 20);
            studentlist.ToHashSet().ToList();
            // second one is return type list<student>
            var studentlist1 = Allstudent.Where(x => x.Age > 0).ToList();

            studentlist1.Add(new Student() { StudentID = 14, StudentName = "Ayyanan", Age = 26 });
            studentlist1.Add(new Student() { StudentID = 15, StudentName = "Arul", Age = 27 });
            studentlist1.Add(new Student() { StudentID = 16, StudentName = "Baskar", Age = 33 });
            studentlist1.Add(new Student() { StudentID = 17, StudentName = "Bass", Age = 28 });
            studentlist1.Add(new Student() { StudentID = 18, StudentName = "Gopal", Age = 26 });
            studentlist1.Add(new Student() { StudentID = 19, StudentName = "Krishna", Age = 26 });
            studentlist1.Add(new Student() { StudentID = 20, StudentName = "Mathi", Age = 26 });
            studentlist1.Add(new Student() { StudentID = 21, StudentName = "Sathiya", Age = 26 });

            

            //studentlist1.AddRange(studentlist);

            var lasttworecords = (from a in Allstudent
                                  orderby a.StudentID descending
                                  select  new {StudentName = a.StudentName ,
                                          address ="chennai"
                                  }).Take(2);

            var lasttworecordsLamdaExpression = Allstudent.OrderByDescending(s => s.StudentID).Take(2);

            var firsttworecords = Allstudent.OrderBy(s => s.StudentID).Take(2);
        }
    }  
}
