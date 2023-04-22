using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_Korondenko
{
    public class MuseyBaza

    {
        public List<Musey> museyList { get;set; }
        public void Initialize() => museyList = new List<Musey>
         {
         new Musey()
        {
            Name = "Меч Македонского",
            Vek = 12,
            Price = 100000,
            Type = "Меч"
        },
        new Musey()
        {
            Name = "Репак бай илюхич",
            Vek = 21,
            Price = 150000,
            Type = "репак"
        },
         };
     
        
    }
}

    