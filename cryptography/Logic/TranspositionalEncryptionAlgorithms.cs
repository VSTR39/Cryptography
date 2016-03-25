using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace cryptography.Logic
{

    class TranspositionalEncryptionAlgorithms
    {
        string message;

        public TranspositionalEncryptionAlgorithms(string _message)
        {
            message = _message;
        }

        /*   private int[] getDigits(int key)
           {
               int i = 0, j = 0;
               int lastDigit;
               int[] arr = new int[8];

               while (key != 0)
               {
                   lastDigit = key % 10;
                   arr[i] = lastDigit;
                   key = key / 10;
                   i++;
               }
               return arr;
           }*/

        bool validateKey(int[] arr)
        {
            bool valid = true;

            int i = 0, j = 0;


            for (i = 0; i < arr.Length; i++)
            {
                for (j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            valid = false;
                            return valid;
                        }
                    }
                }
            }

            return valid;
        }

        private int[] generateKey(int length)
        {
            int from = 0;
            int key;
            int[] arr = new int[length];
            Random rand = new Random();
            int i = 0, j = 0;
            for (i = 0; i < length; i++)
            {
                key = rand.Next(from, length-1);
                arr[i] = key;
                for (j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        key = rand.Next(from, length);
                        arr[i] = key;
                    }
                }
            }


            return arr;

        }

        void saveKey(int[] key)
        {
            using (StreamWriter file = File.CreateText("keys.txt"))
                if (file == null)
                {
                    System.IO.File.WriteAllText("keys.txt", key.ToString());
                }
                else file.WriteLine(key.ToString());

        }
        public string BlockCipherEncryption(int length_of_key)
        {
            return _BlockCipherEncryption(length_of_key);
        }


        private string _BlockCipherEncryption(int length_of_key)
        {
            int i = 0, j = 0;

            string encr_message = "";
            string message1 = "";
            char []temp = new char [length_of_key];
            int[] key1 = generateKey(length_of_key);

            while (!validateKey(key1)) key1 = generateKey(length_of_key);

            saveKey(key1);

            message1 = message;
            while ((message1.Length % key1.Length) != 0)
            {
                message1 = message1 + " ";
            }


            for (i = 0; i < message1.Length; i++)
            {
                if (i < key1.Length)
                {
                    encr_message = encr_message + message1[key1[i % key1.Length]];
                }
                else
                {
                    for (j = 0; j < key1.Length; j++)
                    {
                        
                        temp[j] = message1[i + j];
                        

                    }
                    for (j = 0; j < key1.Length; j++)
                    {

                        encr_message = encr_message + temp[key1[j % key1.Length]];

                    }

                    i = i + j;
                    if (i == message1.Length - length_of_key) break;
                }

            }


            return encr_message;
        }
    }
}
