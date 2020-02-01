using System;
using System.IO;

namespace Projeto_Arquivo
{
    public class FileProvider
    {
        public bool FileExists(string fileName)
        {

            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException(fileName);
            }

            return File.Exists(fileName);
        }
    }
}
