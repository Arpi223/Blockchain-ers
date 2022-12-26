using System;
using System.Collections.Generic;
using System.Text;

namespace Blockchain
{
    class Blockchain
    {
        public List<Block> blockchain;
        public Blockchain()
        {
            if (blockchain.Count != 0) {
                Console.WriteLine("Blockchain already has a genesis block");
                return;
            }
            Block genesisBlock = new Block();
            blockchain.Add(genesisBlock);
        }

        public void AddToChain(Block block)
        {
            if (blockchain.Count == 0)
            {
                Console.WriteLine("First you must add the genesis block");
                return;
            }
            if (blockchain[^1].HashId == block.PreviousHashId)
            {
                blockchain.Add(block);
                Console.WriteLine("Block added");
                return;
            }
            else
            {
                Console.WriteLine("Invalid hashId");
                return;
            }
        }
    }
}
