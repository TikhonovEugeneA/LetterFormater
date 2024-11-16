using LetterFormater;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;

namespace LetterFormatedTests
{
    [TestClass]
    public class TextFormattingTests
    {
        [TestMethod]
        public void TestTextFormatingWithStub()
        {
            //arrange

            var formater = new LetterFormater.SimlpeTextFormater();
            string input = " My line  ";
            int lineLenght = 10;

            //act

            string result = formater.FormatLine(input, lineLenght);

            //assert

            Assert.AreEqual(input, result);
        }
    }
}
