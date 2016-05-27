using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    
    public sealed class ApplicationState
    {
        // Singleton Implementation
        private static ApplicationState _instance;
        private static object _lockThis = new object();

        private ApplicationState() { }

        public static ApplicationState GetState()
        {
            lock (_lockThis)
            {
                if (_instance == null) _instance = new ApplicationState();
            }

            return _instance;
        }

        // State Information
        public string LoginId { get; set; }
        public int MaxSize { get; set; }

    }
}
