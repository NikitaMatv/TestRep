using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class User
    {
        private int _Id;
        private string _Name;
        private string _LastName;
        private int _Age;
        private string _City;


        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

    }
}
