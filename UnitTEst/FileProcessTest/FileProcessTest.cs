using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Configuration;
using System.IO;
using UnitTEst;
using Assert = NUnit.Framework.Assert;
using TestContext = NUnit.Framework.TestContext;

namespace FileProcessTest
{
    public class Tests
    {
        private const string FILE_NOT_EXIST = @"NotExistFile.txt";
        private const string FILE_EXIST = @"C:\Windows\write.exe";
        public TestContext TestContext { get; set; }
        private string FileNameExist;
        private FileProcess _fileProcess;
        private bool _fromCall;
        [SetUp]
        public void Setup()
        {

            _fileProcess = Substitute.For<FileProcess>();

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void File_Name_Does_Exist() {


            _fromCall = _fileProcess.FileExists(FILE_EXIST);

            TestContext.WriteLine("Creating File: " + FILE_EXIST);
            
            Assert.IsTrue(_fromCall);

        }
        [Test]
        public void File_Name_Does_Not_Exist() {

            _fromCall = _fileProcess.FileExists(FILE_NOT_EXIST);

            Assert.IsFalse(_fromCall);

        }
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void File_Name_Null_Or_Empty_Throw_Null_Exception() {

            //_fileProcess.When(x => x.FileExists(Arg.Any<string>())).Do(_ =>
            //{ throw new ArgumentNullException(Arg.Any<string>());});

         
         // _fileProcess.FileExists("");
            
        }

        [Test]
       public void File_Name_Null_Or_Empty_Should_Throw_Null_Exception_Using_Try_Catch()
        {

            try
            {
                _fromCall = _fileProcess.FileExists("");
            }
            catch(ArgumentNullException ex)
            {
                return;
            }

            Assert.Fail("Not throw exception");

            
        }

        public void Set_Good_File_Name()
        {
            FileNameExist = ConfigurationManager.AppSettings["FileNameExist"];
            if (FileNameExist.Contains("[AppPath]"))
            {
                FileNameExist = FileNameExist.Replace(
                    "[AppPath]", 
                    Environment.GetFolderPath(
                    Environment.SpecialFolder
                    .ApplicationData));
            }
        }
    }
}