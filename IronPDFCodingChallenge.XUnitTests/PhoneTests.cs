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



    }
}
