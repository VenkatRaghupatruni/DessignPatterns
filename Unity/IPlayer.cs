using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity
{
    public interface IPlayer
    {
        string PlayerName
        {
            get;
            set;
        }
        string TeamName
        {
            get;
            set;
        }

        void DisplayDetails();
    }
}
