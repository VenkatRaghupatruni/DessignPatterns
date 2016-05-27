using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class PayrollVisitor :VisitorBase
    {
        public override void Visit(Worker employee)
        {
            Console.WriteLine("{0} paid {1}.", employee.Name, employee.MonthlySalary);
        }

        public override void Visit(Manager employee)
        {
            Console.WriteLine("{0} paid {1} + Bonus."
                , employee.Name, employee.MonthlySalary);
        }

    }
}
