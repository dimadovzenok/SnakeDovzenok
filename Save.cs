using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeDovzenok
{
    class Save
    {
        public Save()
        {
        }

        public void to_file(string x, int y, int s)
        {
            StreamWriter to_file = new StreamWriter(@"C:\Users\PC\source\repos\SnakeDovzenok\SnakeDovzenok\tabl.txt", true);
            to_file.WriteLine("Имя:" + x + " Очки:" + y + " Длина змеи:" + s);
            to_file.Close();
        }

        public void from_file()
        {
            StreamReader from_file = new StreamReader(@"C:\Users\PC\source\repos\SnakeDovzenok\SnakeDovzenok\tabl.txt", true);
            string text = from_file.ReadToEnd();
            Console.WriteLine(text);
            from_file.Close();
        }

        internal void to_file(string name, int bal)
        {
            throw new NotImplementedException();
        }
    }
}

