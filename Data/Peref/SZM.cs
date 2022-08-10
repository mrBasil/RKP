using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKP.Data.Peref
{
    public abstract class SZM
    {
        protected int ID = 0;
        public virtual void Load() { }
        public virtual void UnLoad() { }
        public virtual void Stop() { }

        /// <summary>
        /// Скорость нагрузки разгрузки, в случае с частотниками, частота
        /// </summary>
        public virtual int Speed { get; set; }

    }
}
