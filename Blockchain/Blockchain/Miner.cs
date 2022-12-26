using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    internal class Miner
    {
        private string Id;
        private string CurrentState;
        private bool started = false;

        public string GetId() {
            return Id;
        }

        public string GetCurrentState() {
            return CurrentState;
        }

        public bool isStarted() {
            if (started = true)
                return false;
            else
                return true;
        }

    }




}
