using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage
{
    class Personne
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string NAS;
        private string _nam;
        protected string NAM 
        {
            get { return _nam; } 
            set 
            {
                if (value.StartsWith(LastName.Substring(0, 3).ToUpper()))
                    _nam = value;
                else
                {
                    PersonneException e = new PersonneException(1, "NAM non valide.");
                    throw e;
                }
            }
        }
        public Personne() { }
        public Personne(string firstName, string lastName, string nas, string nam)
        {
            FirstName = firstName; 
            LastName = lastName;
            NAS = nas;
            NAM = nam;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + NAS + " " + NAM;
        }
    }
}
