using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Blockchain
{
    class Block
    {
        public string Id;
        public string PreviousId;
        public string HashId;
        public string PreviousHashId;


        public Block() // For creating genesis block
        {
            Id = "0";
            PreviousId = "0";
            HashId = ComputeSha256Hash(Id);
            PreviousHashId = ComputeSha256Hash(PreviousId);

        }

        public Block(string id, string previousId)
        {
            Id = id;
            PreviousId = previousId;
            HashId = ComputeSha256Hash(Id);
            PreviousId = ComputeSha256Hash(PreviousId);
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
