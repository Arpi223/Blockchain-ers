using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain
{
    public class Miner
    {
        private string Id { get; set; }
        private double CurrentState { get; set; }
        private bool Started { get; set; }

        public string GetId() {
            return Id;
        }

        public Miner(string id, double currentState,bool started)
        {
            Id = id;
            CurrentState = currentState;
            Started = started;

        }

        public double GetCurrentState() {
            return CurrentState;
        }

        public bool isStarted() {
            if (Started == true)
                return false;
            else
                return true;
        }

    }




}
