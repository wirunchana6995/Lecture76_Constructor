using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture77_Constructor
{
    class Customer
    {
        
        string firstName = "";
        string lastName = "";

        //constructor ถูกสร้างเมื่อ object ถูก new ขึ้นมา
        public Customer()
        {
            Console.WriteLine("Hello World");
        }

        public Customer(string firstName, string lastName) //parameter ชื่อเหมือนตัวแปร firstName, lastName ข้างบน
        {
            Console.WriteLine("Hello " + firstName + " "+lastName);
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
