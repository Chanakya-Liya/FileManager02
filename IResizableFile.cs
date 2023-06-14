using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager02
{
    interface IResizableFile : IFile
    {
        void resize();
    }
}
