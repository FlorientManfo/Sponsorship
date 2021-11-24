using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sponsorship.BO
{
    public class FirstLevel : Student
    {

        public SecondLevel Parrain { get; set; }
        public int Level { get; set; }
        public FirstLevel()
        {
            Level = 1;
            Parrain = null;
        }
        public FirstLevel(string fullName, string faculty, int phone, string email) : base(fullName, faculty, phone, email)
        {
            Level = 1;
            Parrain = null;
        }
        public FirstLevel(FirstLevel etudiant) : base(new Student(etudiant.FullName, etudiant.Faculty, etudiant.Phone, etudiant.Email))
        {
            Level = etudiant.Level;
            Parrain = etudiant.Parrain ;
        }
    }
}
