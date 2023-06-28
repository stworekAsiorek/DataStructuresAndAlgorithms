using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Practice.StateMachine
{
    public class StateTransition
    {
        public string State { get; set; }
        public string Command { get; set; }

        public override bool Equals(object obj)
        {
            return obj is StateTransition other && this.State == other.Command && this.Command == other.Command;
        }

        public override int GetHashCode()
        {
            return new {State, Command}.GetHashCode();
        }
    }
}
