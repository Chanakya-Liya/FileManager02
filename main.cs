// See https://aka.ms/new-console-template for more information
using FileManager02;

while (true)
{
    Console.Write("enter text, image, pdf or exit: ");
    string FileType = Console.ReadLine();
    if (FileType.Equals("text"))
    {
        TextFile textFile = new TextFile();
        textFile.create();
        while (true)
        {
            Console.WriteLine("enter edit, delete, update or exit");
            string command = Console.ReadLine();
            if (command.Equals("edit"))
            {
                textFile.edit();
            }
            else if (command.Equals("delete"))
            {
                textFile.delete();
                break;
            }
            else if (command.Equals("update"))
            {
                textFile.update();
            }
            else if (command.Equals("read"))
            {
                textFile.read();
            }
            else if (command.Equals("exit"))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
    else if (FileType.Equals("image"))
    {
        Image imageFile = new Image();
        imageFile.create();
        while (true)
        {
            Console.WriteLine("enter read,delete, update, resize or exit");
            string command = Console.ReadLine();
            if (command.Equals("edit"))
            {
                imageFile.read();
            }
            else if (command.Equals("delete"))
            {
                imageFile.delete();
                break;
            }
            else if (command.Equals("update"))
            {
                imageFile.update();
            }
            else if (command.Equals("read"))
            {
                imageFile.read();
            }
            else if (command.Equals("resize"))
            {
                imageFile.resize();
            }
            else if (command.Equals("exit"))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
    else if (FileType.Equals("pdf"))
    {
        PDF pdfFile = new PDF();
        pdfFile.create();
        while (true)
        {
            Console.WriteLine("enter delete, process, read, update or exit");
            string command = Console.ReadLine();
            if (command.Equals("delete"))
            {
                pdfFile.delete();
                break;
            }
            else if (command.Equals("process"))
            {
                pdfFile.process();
            }
            else if (command.Equals("read"))
            {
                pdfFile.read();
            }
            else if (command.Equals("update"))
            {
                pdfFile.update();
            }
            else if (command.Equals("exit"))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
    else if (FileType.Equals("exit"))
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
