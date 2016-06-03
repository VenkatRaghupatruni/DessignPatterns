using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity
{
    class UnityClient
    {
        static void Main(string[] args)
        {

            IPlayer obj = Factory.CreateInstance();
            obj.PlayerName = " Sachin Tendulkar ";
            obj.TeamName = " India ";
            obj.DisplayDetails();
            IPlayer obj1 = Factory.CreateInstance();
            obj.PlayerName = " Shane warne";
            obj.TeamName = " Australia ";
            obj.DisplayDetails();
            Console.Read();

            
            Console.WriteLine();
            Console.Read();
        }

    }
}
