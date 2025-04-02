namespace IronPDFCodingChallenge.XUnitTests
{
    public class PhoneTests
    {
        [Theory]
        [InlineData("2 2 77 444 22#", "AAQIB")]
        [InlineData("227*#", "B")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURING")]
        public void Test_Input_ReturnsCorrectOutput(string input, string expected)
        {
            // Act
            string result = Phone.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2#", "A")]
        [InlineData("7777#", "S")]
        [InlineData("0#", " ")]
        public void Test_SingleKeyPress_ReturnsCorrectOutput(string input, string expected)
        {
            // Act
            string result = Phone.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("999 33 7777#", "YES")]
        [InlineData("66 666#", "NO")]
        [InlineData("666 55 2 999#", "OKAY")]
        public void Test_RepeatedKeyPresses_ReturnsCorrectOutput(string input, string expected)
        {
            // Act
            string result = Phone.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("2 22*#", "A")]
        [InlineData("777* 22 2#", "BA")]
        [InlineData("77**#", "")]
        public void Test_BackspaceHandling_RemovesPreviousCharacter(string input, string expected)
        {
            // Act
            string result = Phone.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("123", "")]
        [InlineData("**#", "")]
        [InlineData("****#", "")]
        [InlineData("2*3*#", "")]
        public void Test_InvalidInputs_ReturnsEmptyString(string input, string expected)
        {
            // Act
            string result = Phone.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }


    }
}
