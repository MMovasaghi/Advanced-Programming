using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp001.Classes;

namespace ConsoleApp001
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------------
            Person person = new Person();
            person.Id = 10;
            person.FirstName = "Benyamin";
            person.LastName = "Rahmani";
            person.gender = Classes.Enum.Gender.Male;
            person.birthdate = new BirthDate()
            {
                Day = 2,
                Month = 5,
                Year = 2001
            };
            //........
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            Student student = new Student(); // Student base class is Person
            student.Id = 10;
            student.FirstName = "Hossein";
            student.LastName = "Gholi";
            student.gender = Classes.Enum.Gender.Male;
            student.UniCode = "3456789";
            student.birthdate = new BirthDate()
            {
                Day = 25,
                Month = 2,
                Year = 2030
            };
            //........
            //-----------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            Teacher teacher = new Teacher(); // Teacher base class is Person
            teacher.Id = 10;
            teacher.FirstName = "Zahra";
            teacher.LastName = "Hasani";
            teacher.gender = Classes.Enum.Gender.Female;
            teacher.CoCode = "4567";
            teacher.birthdate = new BirthDate()
            {
                Day = 20,
                Month = 5,
                Year = 2020
            };
            //........
            //-----------------------------------------------------------------------------------------
        }
    }
}
