using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Adapter
{
    class FileWriterAdapter : Logger
    {
        private FileWriter _fileWriter;
        public FileWriterAdapter(string file)
        {
            _fileWriter = new FileWriter(file);
        }
        public override void Log(string message)
        {
            _fileWriter.WriteLine(message);
        }
        public override void Error(string message)
        {
            _fileWriter.WriteLine(message);
        }
        public override void Warn(string message)
        {
            _fileWriter.WriteLine(message);
        }
    }
}
