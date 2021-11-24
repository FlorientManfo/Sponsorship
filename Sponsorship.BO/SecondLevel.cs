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
        public int Niveau { get; set; }
        public SecondLevel()
        {
            Niveau = 2;
            Filleuls = new List<FirstLevel>();
        }
        public SecondLevel(string nom, string filiere, int telephone, string email) :base(nom, filiere, telephone, email)
        {
            Niveau = 2;
            Filleuls = new List<FirstLevel>();
        }
        public SecondLevel(SecondLevel etudiant):base(new Student(etudiant.Nom, etudiant.Filiere, etudiant.Telephone, etudiant.Email))
        {
            Niveau = etudiant.Niveau;
            Filleuls = etudiant.Filleuls;
        }
    }
}
