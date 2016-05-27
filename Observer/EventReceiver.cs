using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DessignPatterns
{
    public class EventReceiver : EventReceiverBase
    {
        private string _lastMessage;

        public string GetLastMessage()
        {
            return _lastMessage;
        }

        public void LogMessage(string message)
        {
            _lastMessage = message;
            Notify();
        }
    }
}
