using NUnit.Framework;
using Projeto_Arquivo;

namespace Projeto_Arquivo_Test
{
    public class Tests
    {
        FileProvider f = new FileProvider();
        bool fileExist;
         [SetUp]
         public void Setup()
         {

         }

        [Test]
        public void File_Name_Does_Exists()
        {

            fileExist = f.FileExists(@"C:\Windows\Regedit.exe");

            Assert.IsTrue(fileExist);
        }
        [Test]
        public void File_Name_Does_Not_Exists()
        {
            fileExist = f.FileExists(@"C:\Windows\Frozen");

            Assert.IsFalse(fileExist);
        }
            }
}