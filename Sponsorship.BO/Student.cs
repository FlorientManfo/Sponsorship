using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sponsorship.BO
{
    [Serializable]
    public class Student
    {
        public string FullName { get; set; }
        public string Faculty { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public Student()
        {

        }

        public Student(string fullName, string faculty, int phone, string email)
        {
            FullName = fullName;
            Faculty = faculty;
            Phone = phone;
            Email = email;
        }

        public Student(Student etudiant):this(etudiant.FullName, etudiant.Faculty, etudiant.Phone, etudiant.Email)
        {
        }
    }
}
