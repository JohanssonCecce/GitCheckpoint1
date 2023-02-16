using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCheckpoint1
{
    class Calculate
    {
        public int Z { get; set; }
        public Calculate(int z)
        {
            Z = z;
            int x = 1;
            int y = 9;
            Z = x + y;
        }
    }
}
