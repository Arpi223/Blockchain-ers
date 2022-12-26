using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Blockchain
{
    class Block
    {
        private string id;
        private string PreviousId;
        private string hashId;
        private string PreviousHashId;


        public Block() // For creating genesis block
        {
            id = "0";
            PreviousId = "0";
            hashId = ComputeSha256Hash(id);
            PreviousHashId = ComputeSha256Hash(PreviousId);
            Console.WriteLine(hashId);

        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using SHA256 sha256Hash = SHA256.Create();
            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }


    }
}
