using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab3.Proxy
{
    class SmartTextReaderLocker
    {
        private SmartTextReader reader;
        private string restriction;

        public SmartTextReaderLocker(string file, string restriction)
        {
            this.reader = new SmartTextReader(file);
            this.restriction = restriction;
        }

        public char[][] Reading()
        {
            if (Regex.IsMatch(this.reader.FilePath, restriction))
            {
                Console.WriteLine("Access denied!");
                return new char[0][];
            }

            return reader.Reading();
        }
    }
}
