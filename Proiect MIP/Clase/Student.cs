using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_MIP.Clase
{
    internal class Student : Persoana
    {
        private string password;

        public Student() { }
        public Student(int id, string name, string password): base(id, name)
        {
            this.password = password;
        }
        public Student(string name, string password) : base(name)
        {
            this.password = password;
    
        }
        public string getPassword() { return password; }

        public void setPassword(string password) { this.password = password;}
    }
}
