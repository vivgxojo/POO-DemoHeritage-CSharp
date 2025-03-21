using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHeritage
{
    class PersonneException : Exception
    {
        public int CodeErreur;

        public PersonneException(int code, string message) : base(message) 
        {
            CodeErreur = code;
        }

        public override string ToString()
        {
            return "PersonneException : " + this.CodeErreur + " " + base.Message;
        }
    }
}
