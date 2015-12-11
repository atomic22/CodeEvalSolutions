using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringList.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void correct_number_of_letters()
        {
            int stringLength = 3;
            string[] letters = { "A", "A", "A", "A" };
            List<string> letterGroups = new List<string>();
            for (int i = 0; i < stringLength; i++)
            {
                letterGroups.Add(letters[i]);
            }

            Assert.AreEqual(stringLength, letterGroups.Count);
        }

        [TestMethod]
        public void alphabetical_order_of_list()
        {
            string[] correctOrder =  { "a", "b", "c" };
            List<string> letters = new List<string>(new string[] { "b", "c", "a" });
            letters.Sort();
            for (int i = 0; i < letters.Count; i++)
            {
                Assert.AreEqual(correctOrder[i], letters[i]);
            }
        }

        
    }
}
