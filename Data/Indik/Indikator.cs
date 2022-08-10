using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKP.Data.Indik
{
    public abstract class Indikator
    {
       public virtual double data { get;}
       public virtual double zero_data { get; set; }

       public int ID = 0;

    }
}
