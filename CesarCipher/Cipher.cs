using System;
using System.Text;

namespace CesarCipher
{
    public class Cipher
    {
        public static string Encrypt(string text, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char character in text)
            {
                if (char.IsLetter(character))
                {
                    char baseAscii = char.IsUpper(character) ? 'A' : 'a';
                    int alphabetSize = 26;

                    int charIndex = character - baseAscii;
                    int shiftedIndex = (charIndex + shift) % alphabetSize;

                    if (shiftedIndex < 0)
                    {
                        shiftedIndex += alphabetSize;
                    }

                    char shiftedChar = (char)(baseAscii + shiftedIndex);
                    result.Append(shiftedChar);
                }
                else
                {
                    result.Append(character);
                }
            }

            return result.ToString();
        }

        public static string Decrypt(string text, int shift)
        {
            
            return Encrypt(text, -shift);
        }
    }
}
