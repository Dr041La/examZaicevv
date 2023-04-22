using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_Korondenko
{
    public class Musey
    {
        private string _name;
        private int _vek;
        private int _price;
        private string _type;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Vek
        {
            get { return _vek; }
            set { _vek = value; }
        }
        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
       /* public Musey (string Name, int Carates, int Price, string Type)
        {
            _name = Name;
            _Vek = Vek;
            _price = Price;
            _type = Type;

        }
       */
    }
}
