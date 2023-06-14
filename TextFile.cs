using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager02
{
    internal class TextFile : IEditableFile
    {
        public void create()
        {
            Console.Write("Name of text file: ");
            Console.ReadLine();
            //make text file
            Console.WriteLine("Text file created");
        }

        public void delete()
        {
            //delete text file
            Console.WriteLine("text file deleted");
        }

        public void edit()
        {
            //edit text file
            Console.WriteLine("text file edited");
        }

        public void read()
        {
            //read text file
            Console.WriteLine("text file read");
        }

        public void update()
        {
            //update text file
            Console.WriteLine("text file updated");
        }
    }
}
