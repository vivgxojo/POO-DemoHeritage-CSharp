using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage
{
    class Etudiant : Personne
    {
        public long Numero { get; set; }
        public string Etablissement { get; set; }
        public string Programme { get; set; }
        public Etudiant() { }
        public Etudiant(long numero, string nom, string prenom, string nas, string nam,
            string etablissement, string programme) : base(prenom, nom, nas, nam) 
        {
            //this.FirstName = prenom;
            //this.LastName = nom;
            //base.NAS = nas; //illégal car NAS est privé
            base.NAM = nam;
            this.Numero=numero;
            Etablissement=etablissement;
            Programme=programme;
        }
        public override string ToString()
        {
            return Numero + " " + base.ToString() + " " + Etablissement + " " + Programme;
        }
    }
}
