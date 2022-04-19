using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibTheatre
{
    public class Movie
    {
        private int _Id;
        private string _Title;
        private int _Duration;
        public int id
        {
            get { return _Id; }
            set { _Id = value; }
        }


        public string title
        {
            get { return _Title; }
            set { _Title = value; }
        }


        public int duration
        {
            get { return _Duration; }
            set { _Duration = value; }
        }

    }
}
