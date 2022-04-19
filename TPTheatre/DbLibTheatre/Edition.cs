using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibTheatre
{
    public class Edition
    {
        internal string annee;
        private int _Id;
        private DateTime _Annee;
        public int id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int Id { get; internal set; }

        public DateTime année
        {
            get { return _Annee; }
            set { _Annee = value; }
        }
    }
}
