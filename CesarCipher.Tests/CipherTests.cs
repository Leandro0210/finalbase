using System;
using Xunit;

namespace CesarCipher.Tests
{
    public class CipherTests
    {

        [Fact]
        public void Encrypt_ShouldHandleNonAlphabeticCharacters()
        {
            // Arrange
            string input = "Hello, World 123!";
            int shift = 5;
            string expected = "Mjqqt, Btwqi 123!";

            // Act
            string result = Cipher.Encrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Encrypt_ShouldHandleUppercaseLetters()
        {
            // Arrange
            string input = "HELLO, WORLD!";
            int shift = 7;
            string expected = "OLSSV, DVYSK!";

            // Act
            string result = Cipher.Encrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Encrypt_ShouldHandleUppercaseLetters()
        {
            // Arrange
            string input = "WORLD, HELLO!";
            int shift = 7;
            string expected = "DVYSK, OLSSV!";

            // Act
            string result = Cipher.Encrypt(input, shift);

            // Assert
            Assert.Equal(expected, result);
        }
    
    }
}