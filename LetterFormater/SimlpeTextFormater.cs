using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFormater
{
    public class SimlpeTextFormater
    {
        public string FormatLine(string line, int lineLenght)
        {
            if (string.IsNullOrEmpty(line)) throw new ArgumentException("Строка не может быть нулевой или пустой.");
            if (lineLenght < line.Length) throw new ArgumentException("Длина строки не может быть меньше длины входной строки.");
            int numSpaces = 0;

            foreach (char c in line)
            {;
                if (c == ' ') numSpaces++;
            }
            int padding = (lineLenght - line.Length) / 2;
            string paddedLine = line.PadLeft(line.Length + padding).PadRight(lineLenght);
            return paddedLine;
        }
    }
}
