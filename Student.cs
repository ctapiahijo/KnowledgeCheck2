using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck
{
    public class Student : Person
    {
        public string? StudentId {  get;  set; }
        public DateTime EnrollmentDate { get;  set; }
    }
}
