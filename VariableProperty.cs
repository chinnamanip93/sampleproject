using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_ConsoleApp
{
  public  class VariableProperty
   {

        public class UserDetails
        {
            public  int    Id        { get; set; }
            public string UserName   { get; set; }
            public string EmailId    { get; set; }
            public string PassWord   { get; set; }
            public string UserRoleId  { get; set; }
            public double PhoneNumber { get;  set;}
            public bool   IsActive      {get; set; }
            public DateTime CreatedOn { get; set; }
            public DateTime UpdatedOn { get; set; }
            public List<UserDetails> UserDetailsList { get; set; }

        }

        public class UserRole
        {
            public int Id { get; set; }
            public string RoleName { get; set; }
            public bool IsActive { get; set; }
        }

      //  public static  List<VariableProperty.EmployeeDetails> EmployeeDetalisList { get;set;}
        public static class EmployeeDetails {

            public static int Id { get; set; }
            public static string Name { get; set; }
            public static string Designation { get; set; }
            public static string WorkingLocation { get; set; }
            public static string  CompanyName { get; set; }
            public static string EducationQulification { get; set; }
            public static string Address { get; set; }
            public static string FatherName { get; set; }
            public static string Occupation { get; set; }
            public static string MotherTongue { get; set; }
            public static string Nationality { get; set; }
            public static string PermentAddress { get; set; }
            
        }
        public static class Weekday
        {
            
            public  enum days
            {        
                Sunday      = 1,
                Monday      = 2,
                Tuesday     = 3,
                Wednesday  = 4,
                Thursday   = 5,
                Friday      = 6,
                Saturday  = 7
            }
        }
        public static class Season
        {
            public enum Names
            {
                Winter = 1,
                Spring = 2,
                Summer = 3,
                Fall   = 4
            }
        }
      public static class Month
        {
            public enum Name
            {
                january     =   1,
                February    =   2,
                March       =   3,
                April       =   4,
                May         =   5,
                June        =   6,
                July        =   7,
                August      =   8,
                September   =   9,
                October     =  10,
                November    =  11,
                December    =  12
            }
        }       
   }
}
