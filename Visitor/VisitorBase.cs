using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public abstract class VisitorBase
    {
        public abstract void Visit(Worker employee);

        public abstract void Visit(Manager employee);

    }
}
