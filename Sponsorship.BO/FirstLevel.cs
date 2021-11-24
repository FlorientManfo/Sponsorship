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
        public int Niveau { get; set; }
        public FirstLevel()
        {
            Niveau = 1;
            Parrain = null;
        }
        public FirstLevel(string nom, string filiere, int telephone, string email) : base(nom, filiere, telephone, email)
        {
            Niveau = 1;
            Parrain = null;
        }
        public FirstLevel(FirstLevel etudiant) : base(new Student(etudiant.Nom, etudiant.Filiere, etudiant.Telephone, etudiant.Email))
        {
            Niveau = etudiant.Niveau;
            Parrain = etudiant.Parrain ;
        }
    }
}
