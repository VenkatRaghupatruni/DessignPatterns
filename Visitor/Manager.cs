using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class Manager :EmployeeBase
    {
        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }

        public List<EmployeeBase> Subordinates { get; private set; }

        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);

            foreach (EmployeeBase subordinate in Subordinates)
            {
                subordinate.Accept(visitor);
            }
        }


    }
}
