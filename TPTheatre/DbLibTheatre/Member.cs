using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibTheatre
{
    public class Member
    {
        private int _Id;
        private string _Nom;
        private string _Prenom;
        public int id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        public string  prenom
        {
            get { return _Prenom; }
            set { _Prenom= value; }
        }

    }
}
