using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06_EmployeeData
{
    class p06_EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            long personalID = long.Parse(Console.ReadLine());
            long uniqueEmployeeNumber = long.Parse(Console.ReadLine());
            
            Console.WriteLine($"First name: {firstName}\n\rLast name: {lastName}\n\rAge: {age}\n\rGender: {gender}\n\rPersonal ID: {personalID}\n\rUnique Employee number: {uniqueEmployeeNumber}");
        }
    }
}
