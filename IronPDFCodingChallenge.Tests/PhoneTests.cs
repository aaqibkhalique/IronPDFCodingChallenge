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

        [Test] 
        public void CheckUserInputWithInvalidInput()
        {
            // Arrange
            string input1 = "";
            string input2 = "123";
            string input3 = "**#";

            // Act
            string result1 = Phone.OldPhonePad(input1);
            string result2 = Phone.OldPhonePad(input2);
            string result3 = Phone.OldPhonePad(input3);

            // Assert
            Assert.AreEqual("", result1);
            Assert.AreEqual("", result2);
            Assert.AreEqual("", result3);
        }


    }
}
