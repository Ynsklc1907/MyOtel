using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOtel
{
    public class Personel:BaseClass
    {
       

        public Personel(string n, string sn)
        {
            maxId++;
            Id = maxId;

            Name = n;
            SurName = sn;
        }

      

        public string SurName { get; set; }

        public string PersonelInfo
        {
            get
            {
                return string.Format("({0}) {1} {2}", Id, Name, SurName);
            }
        }
    }
}
