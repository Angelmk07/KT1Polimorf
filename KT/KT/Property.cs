using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT
{
    public abstract class Property
    {
        internal int worth;
        public Property (int worth)
        {
            this.worth = worth;
        }
        public abstract int Tax();
        
    }
}
