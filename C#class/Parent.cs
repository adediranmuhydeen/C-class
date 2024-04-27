using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_class
{
    public class Parent : BaseEntity
    {
        
        public string Address { get; set; }
        public bool IsParentOrGuidian { get; set; }

        public override void SayMyName()
        {
            Console.WriteLine($"{FirstName}, {LastName}");
        }
    }
}

