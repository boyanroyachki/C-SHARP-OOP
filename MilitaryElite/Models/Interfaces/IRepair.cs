using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Interfaces
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }
    }
}
