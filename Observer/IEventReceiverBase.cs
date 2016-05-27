using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns
{
    public interface IEventReceiverBase
    {
        void Attach(EventMonitor em);
        void Detach(EventMonitor em);
        void Notify();
    }
}
