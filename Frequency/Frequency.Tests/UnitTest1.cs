using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Frequency.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OpenFile()
        {
            Assert.IsNotNull(File.OpenText("Test.txt"));
        }
    }
}
