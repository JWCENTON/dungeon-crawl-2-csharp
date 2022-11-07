using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon.FileReader
{
    public class FileReader
    {
        private readonly string _filename;

        public FileReader(string filename)
        {
            _filename = filename;
        }

        public string Read()
        {
            StringBuilder resultBuilder = new StringBuilder();
            StreamReader reader = new StreamReader(_filename);

            string strCurrentLine;
            while ((strCurrentLine = reader.ReadLine()) != null)
            {
                resultBuilder.Append($"{strCurrentLine}{Environment.NewLine}");
            }

            return resultBuilder.ToString();
        }
    }  
}
