using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public abstract class PresentationMember
    {
        protected Mediator _mediator;
 
        public PresentationMember(Mediator mediator)
        {
            _mediator = mediator;
        }
 
        public string Name { get; set; }
 
        public void ReceiveAnswer(string answer)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} received anwer.\n'{1}'.", Name, answer);
        }
    }        
}
