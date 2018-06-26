using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchage
{
    public class Elements
    {
        public string name { get; set; }
      public  decimal note { get; set; }
       public Elements(string name=null, decimal note=0)
        {
           this.name = name;
           this.note = note;
        }
    }
}
