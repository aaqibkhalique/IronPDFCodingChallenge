using System;
using System.Collections.Generic;
using System.Numerics;
using NUnit.Framework;


namespace IronPDFCodingChallenge.Tests
{
    [TestFixture]
    public class PhoneTests
    {
        [Test]
        public void TestValidUserInssputs()
        {
            Assert.AreEqual("HELLO", Phone.OldPhonePad("4433555 555666096667775553#"));
            Assert.AreEqual("WORLD", Phone.OldPhonePad("9675533 5556660966#"));
            Assert.AreEqual("TEST", Phone.OldPhonePad("8337777 7777888#"));
        }

        [Test]
        public void TestValidUserInputsCorrects()
        {
            // Arrange
            string userInput = "2 2 77 444 22#";
            string expected = "AAQIB";

            // Act
            string result = Phone.OldPhonePad(userInput);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void CheckUserInputWithBackSpaceRemovesPreviousCharacter()
        {
            // Arrange
            string input = "227*#";
            string expected = "B";

            // Act
            string result = Phone.OldPhonePad(input);

            // Assert
            Assert.AreEqual(expected, result);
        }




    }
}
