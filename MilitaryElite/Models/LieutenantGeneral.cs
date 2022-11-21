using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly ICollection<IPrivate> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<IPrivate> privates)
            : base(id, firstName, lastName, salary)
        {
            //privates = new HashSet<IPrivate>();
            this.privates = privates;  
        }

        public IReadOnlyCollection<IPrivate> Privates
            => (IReadOnlyCollection<IPrivate>)privates;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine(base.ToString())
                .AppendLine($"Privates:");

            foreach (IPrivate pr in this.Privates)
            {
                sb.AppendLine($"  {pr.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }



    }
}
