using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager02
{
    internal class PDF : IProcessFile
    {
        public void create()
        {
            //create PDF file
            Console.WriteLine("PDF file created");
        }

        public void delete()
        {
            //delete PDF file
            Console.WriteLine("PDF file deleted");
        }

        public void process()
        {
            //Process PDF file
            Console.WriteLine("PDF file processed");
        }

        public void read()
        {
            //read PDF file
            Console.WriteLine("PDF file read");
        }

        public void update()
        {
            //update PDF file
            Console.WriteLine("PDF file updated");
        }
    }
}
