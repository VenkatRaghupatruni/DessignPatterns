using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);

        public string Name { get; set; }

        public double MonthlySalary { get; set; }

    }
}
