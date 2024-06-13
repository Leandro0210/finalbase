using System;

namespace CesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la frase:");
            string input = Console.ReadLine();

            Console.WriteLine("Ingrese el desplazamiento:");
            if (int.TryParse(Console.ReadLine(), out int shift))
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Cifrar");
                Console.WriteLine("2. Descifrar");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        string encrypted = Cipher.Encrypt(input, shift);
                        Console.WriteLine($"Frase cifrada: {encrypted}");
                        break;
                    case "2":
                        string decrypted = Cipher.Decrypt(input, shift);
                        Console.WriteLine($"Frase descifrada: {decrypted}");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione 1 para cifrar o 2 para descifrar.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("El desplazamiento debe ser un número entero.");
            }
        }
    }
}
