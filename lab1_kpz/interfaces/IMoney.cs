using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_kpz.interfaces
{
    public interface IMoney
    {
        public string getMoney();
        public void setWhole(int whole);
        public void setFraction(int fraction);
    }
}
