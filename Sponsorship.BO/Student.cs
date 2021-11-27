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

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Phone == student.Phone &&
                   Email == student.Email;
        }

        public override int GetHashCode()
        {
            int hashCode = 1182145806;
            hashCode = hashCode * -1521134295 + Phone.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }
    }
}
