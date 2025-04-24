using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Proxy
{
    class SmartTextReader
    {
        protected string file;

        public string FilePath => file;
        public SmartTextReader(string file)
        {
            this.file = file;
        }

        public char[][] Reading()
        {
            string[] lines = File.ReadAllLines(this.file);
            char[][] result = lines.Select(line => line.ToCharArray()).ToArray();

            foreach (var line in result)
            {
                Console.WriteLine(new string(line));
            }

            return result;
        }
    }
}
