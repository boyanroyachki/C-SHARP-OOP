using MilitaryElite.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }

        void CompleteMission();
        
    }
}
