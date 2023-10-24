using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NEWNEW
{
    public class Employee : Company
    {
        string _name;
        string _surname;
        string _username;
        byte _age;

        

        public void Getnames(string name, string surname)
        {
            _name = name;
            _surname = surname;
            string CapsName = char.ToUpper(name[0]) + name.Substring(1);
            string CapsSurname = char.ToUpper(surname[0]) + surname.Substring(1);

            Console.WriteLine(CapsName + " " + CapsSurname);
        }
       
        public void GetAge(byte age)
        {
            if (age > 0) 
            { 
            _age = age;
                Console.WriteLine(age);
            }
            else Console.WriteLine("Age must be more than 0");

        }



    }
}
