using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_kpz.interfaces
{
    public interface IMoney
    {
        string getMoney();
        void setWhole(int whole);
        void setFraction(int fraction);
    }
}
