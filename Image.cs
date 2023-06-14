using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager02
{
    internal class Image : IResizableFile
    {
        public void create()
        {
            //create image file
            Console.WriteLine("Image file created");
        }

        public void delete()
        {
            //delete image file
            Console.WriteLine("Image file deleted");
        }

        public void read()
        {
            //read image file
            Console.WriteLine("Image file read");
        }

        public void resize()
        {
            //resize image file
            Console.WriteLine("image resized");
        }

        public void update()
        {
            //update image file
            Console.WriteLine("image file updated");
        }
    }
}
