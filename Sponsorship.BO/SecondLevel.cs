using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sponsorship.BO
{
    [Serializable]
    public class SecondLevel:Student
    {
        public List<FirstLevel> Filleuls { get; set; }
        public int Level { get; set; }
        public SecondLevel()
        {
            Level = 2;
            Filleuls = new List<FirstLevel>();
        }
        public SecondLevel(string fullName, string faculty, int phone, string email) :base(fullName, faculty, phone, email)
        {
            Level = 2;
            Filleuls = new List<FirstLevel>();
        }
        public SecondLevel(SecondLevel etudiant):base(new Student(etudiant.FullName, etudiant.Faculty, etudiant.Phone, etudiant.Email))
        {
            Level = etudiant.Level;
            Filleuls = etudiant.Filleuls;
        }
    }
}
