using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unity
{
    public class Player: IPlayer
    {
        public Player()
         {
         }         

         string name;
         string teamName;        

         public string PlayerName
         {
             get 
             {
                 return name; 
             }
             set
             {
                 name = value; 
             }
        }
         
        public string TeamName
        {
             get
             {
                 return teamName; 
             }
             set
             {
                 teamName = value; 
             }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Player Name = \t" + name + " \tPlayer Team Name = \t" + teamName);
            //Console.WriteLine(p.PlayerName);
        }
    


    }
}
