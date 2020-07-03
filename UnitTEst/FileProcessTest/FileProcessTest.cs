using NUnit.Framework;
using System;
using UnitTEst;

namespace FileProcessTest
{
    public class Tests
    {
        private FileProcess _fileProcess;
        private bool fromCall;
        [SetUp]
        public void Setup()
        {
            _fileProcess = new FileProcess();

       //   _fileProcess = Substitute

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void File_Name_Does_Exist() {

            fromCall = _fileProcess.FileExists(@"C:\Windows\write.exe");

            Assert.IsTrue(fromCall);
            
        }
        [Test]
        public void File_Name_Does_Not_Exist() {

            fromCall = _fileProcess.FileExists(@"NotExistFile.txt");

            Assert.IsFalse(fromCall);

        }
        [Test]
      //  [ExpectedException(typeof(ArgumentNullException))]
        public void File_Name_Null_Or_Empty_Throw_Null_Exception() {

            // fromCall = _fileProcess.FileExists("");

            Assert.Inconclusive();
        }

        [Test]
        //  [ExpectedException(typeof(ArgumentNullException))]
        public void File_Name_Null_Or_Empty_Should_Throw_Null_Exception_Using_Try_Catch()
        {

            try
            {
                fromCall = _fileProcess.FileExists("");
            }
            catch(ArgumentNullException ex)
            {
                return;
            }

            Assert.Fail("Not throw exception");

            
        }
    }
}