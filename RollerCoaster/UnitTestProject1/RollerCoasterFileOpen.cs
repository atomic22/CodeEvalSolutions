using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class RollerCoasterFileOpen
    {
        [TestMethod]
        public void OpenFile()
        {
            bool opened;
            opened = File.Exists("Test.txt");
            Assert.IsNotNull(opened);
        }

        [TestMethod]
        public void Can_The_File_Be_Read()
        {
            byte[] readable;
            readable = File.ReadAllBytes("Test.txt");
            Assert.IsNotNull(readable);
        }

        [TestMethod]
        public void Convert_String_To_Char_Array()
        {
            string line = "To be, or not to be: that is the question.";
            int lineLength = line.Length;
            char[] letters = line.ToCharArray();
            Assert.AreEqual(letters.Length, lineLength);
        }

        [TestMethod]
        public void Skip_WhiteSpace_In_String()
        {
            string line = "To be, or not to be: that is the question.";
            char[] letters = line.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                if (Char.IsWhiteSpace(letters[i]))
                {
                    Assert.IsTrue(Char.IsWhiteSpace(letters[i]));
                }

            }

        }

        [TestMethod]
        public void Get_Ever_Other_Letter()
        {
            string line = "To be, or not to be: that is the question.";
            char[] letters = line.ToCharArray();
            string[] everyOtherLetter = { "T", "b" };
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(letters[0].ToString(), everyOtherLetter[0].ToUpper());
            }
        }

        [TestMethod]
        public void UpperCase_Every_Other_Letter_In_A_String_with_no_spaces()
        {
            string line = "Thisisatest";
            string[] everyOtherLetter = { "T", "i", "i", "a", "e", "t" };
            int count = 0;

            for (int i = 0; i < line.Length; i += 2)
            {
                Assert.AreEqual(line[i].ToString(), everyOtherLetter[count]);
                count++;

            }
        }

        [TestMethod]
        public void Uppercase_every_other_letter_with_spaces()
        {
            string line = "This is a test of, time";
            string[] everyOtherLetter = { "T", "i", "i", "a", "t", "s", "o", "t", "m" };
            int count = 0;

            for (int i = 0; i < line.Length; i += 2)
            {
                if (!Char.IsLetter(line[i]))
                {
                    i--;
                }
                else
                {
                    Assert.AreEqual(line[i].ToString(), everyOtherLetter[count]);
                    count++;
                }
            }
        }

        [TestMethod]
        public void Capture_Every_Letter_with_no_spaces()
        {
            string line = "Thisisatest";
            string[] everyOtherLetter = { "T", "i", "i", "a", "e", "t" };
            int count = 0;
            StringBuilder sb = new StringBuilder();

            //this will get every other letter
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].ToString() == everyOtherLetter[count])
                {
                    sb.Append(line[i].ToString());
                    count++;
                }
                else
                {
                    sb.Append(line[i].ToString());
                }


            }
            Assert.AreEqual(sb.ToString(), line);
        }

        [TestMethod]
        public void Capture_Every_Letter_with_spaces()
        {
            string line = "This is a test of, time";
            string[] everyOtherLetter = { "T", "i", "i", "a", "t", "s", "o", "t", "m" };
            int count = 0;
            StringBuilder sb = new StringBuilder();

            //this will get every other letter
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].ToString() == everyOtherLetter[count])
                {
                    sb.Append(line[i].ToString());
                    if (count < everyOtherLetter.Length - 1)
                    {
                        count++;
                    }

                }
                else
                {
                    sb.Append(line[i].ToString());
                }


            }
            Assert.AreEqual(sb.ToString(), line);
        }

        [TestMethod]
        public void Capture_Every_Letter_with_spaces_no_letter_array()
        {
            string line = "This is a test of, time";
            int count = 0;
            StringBuilder sb = new StringBuilder();
            List<string> everyOtherLetter = new List<string>();
            string[] everyOtherLetterArray = { "T", "i", "i", "a", "t", "s", "o", "t", "m" };

            //loop to get the collection of everyother letter
            for (int i = 0; i < line.Length; i += 2)
            {
                //if character is a letter
                if (Char.IsLetter(line[i]))
                {
                    everyOtherLetter.Add(line[i].ToString());
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < everyOtherLetterArray.Length; i++)
            {
                Assert.AreEqual(everyOtherLetter[i], everyOtherLetterArray[i]);
            }
        }
    }
}
