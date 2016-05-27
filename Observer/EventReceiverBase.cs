using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DessignPatterns
{
    public abstract class EventReceiverBase : IEventReceiverBase
    {
        private ArrayList _monitors = new ArrayList();

        public void Attach(EventMonitor monitor)
        {
            _monitors.Add(monitor);
        }

        public void Detach(EventMonitor monitor)
        {
            _monitors.Remove(_monitors);
        }

        public void Notify()
        {
            foreach (EventMonitor monitor in _monitors)
            {
                monitor.Update();
            }
        }
    }
}
