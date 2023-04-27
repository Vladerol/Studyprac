using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verstka
{
    public class Print
    {
        public Print(int Id,string Surname,string Name,int age,string sity)
        {
            this.Id = Id;
            this.Surname = Surname;
            this.Name = Name;
            this.Age = age;
            this.Sity = sity;
        }
        public int Id { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Sity { get; set; }
    }
}
