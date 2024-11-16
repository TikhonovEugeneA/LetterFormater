using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetterFormater;

namespace LetterFormaterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var formatter = new SimlpeTextFormater();
            try
            {
                string result = formatter.FormatLine("Hello World", 20);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}
