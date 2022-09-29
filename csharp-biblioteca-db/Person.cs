using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Person
    {
        private int id=0;
        public int Id { get; }
        public Person(string name, string lastName, string email, string pass, string number)
        {
            id=++id;
            LastName = lastName;
            FirstName = name;
            Email = email;
            Password = pass;
            Number = number;
        }

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Number { get; set; }
        
        public string FullName()
        {
            return LastName + " " + FirstName;
        }
        


        public override string? ToString()
        {
            return String.Format("| Nome: {0,30} \t| Email: {1.30} \t| Number: {2,20} ", FullName(), Email, Number);
        }
    }

}
