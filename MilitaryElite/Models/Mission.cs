using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, State state)
        {
            CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; private set; }

        public State State { get; private set; }



        public void CompleteMission()
        {
            this.State = State.Finished;
        }
        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State.ToString()}";
        }
    }
}
