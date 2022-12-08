using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._0
{
    struct Repository1
    {

        private Worker[] Workers;

        public Worker this[int index]
        { 
            get { return Workers[index]; } 
            set { Workers[index] = value; }
        }

        public Repository1 (params Worker[] Args)
        {
            Workers = Args;
        }
    }
}
