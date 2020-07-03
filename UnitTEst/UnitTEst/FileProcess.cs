using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTEst
{
    public class FileProcess
    {
            public bool FileExists (string nameFile)
        {
            if (string.IsNullOrEmpty(nameFile))
            {
                throw new ArgumentNullException("fileName");
            }
            return File.Exists(nameFile);
        }

    }
}
