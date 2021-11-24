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
        public string Nom { get; set; }
        public string Filiere { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }

        public Student()
        {

        }

        public Student(string nom, string specialite, int telephone, string email)
        {
            Nom = nom;
            Filiere = specialite;
            Telephone = telephone;
            Email = email;
        }

        public Student(Student etudiant):this(etudiant.Nom, etudiant.Filiere, etudiant.Telephone, etudiant.Email)
        {
        }
    }
}
