using System;

namespace Caesar_Algorithm
{
    class Program
    {
        static void Main(string[] args) 
        {
            string alphabet = "abcçdefgğhıijklmnoöprsştuüvyzABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ ";
            string message = ""; 
            
            while(true)
            {
                getValidMessage(message, alphabet);
            }
        }

        public static void getValidMessage(string message, string alphabet)
        {
            int counter = 0;

            Console.Write("Sentence to be encrypted => ");
            message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++)
            {
                for (int k = 0; k < alphabet.Length; k++)
                {
                    if (message[i] == alphabet[k])
                    {
                        counter++;
                    }
                }
            }

            if (counter == message.Length)
            {
                Console.WriteLine("The message you enter => " + message);
                caesarEncryption(message);
            }
            else
            {
                Console.WriteLine("Please only use Turkish characters.");
            }
        }

        public static void caesarEncryption(string message)
        {
            string encryptionAlphabet = "abcçdefgğhıijklmnoöprsştuüvyzABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ >£#$½{[]}/~";
            string encryptionMessage = "";

            for (int i = 0; i < message.Length; i++)
            {
                for (int k = 0; k < encryptionAlphabet.Length; k++)
                {
                    if (message[i] == encryptionAlphabet[k])
                    {
                        encryptionMessage += encryptionAlphabet[k + 10];
                    }
                }
            }

            Console.WriteLine("Diencryptioned message => " + encryptionMessage);
            Console.ReadKey();

            Console.Write("The sentence to be decrypted => ");
            string decodingMessage = Console.ReadLine();

            reverseCaesarEncryption(decodingMessage, encryptionAlphabet);
        }

        public static void reverseCaesarEncryption(string decodingMessage, string encryptionAlphabet)
        {
            string reverseEncryptionMessage = "";

            for (int i = 0; i < decodingMessage.Length; i++)
            {
                for (int k = 0; k < encryptionAlphabet.Length; k++)
                {
                    if (decodingMessage[i] == encryptionAlphabet[k])
                    {
                        reverseEncryptionMessage += encryptionAlphabet[k - 10];
                    }
                }
            }

            Console.WriteLine("Encrypted message => " + reverseEncryptionMessage);
            Console.ReadKey();
        }
    }
}
