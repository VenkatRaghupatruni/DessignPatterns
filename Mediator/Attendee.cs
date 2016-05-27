using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class Attendee: PresentationMember
    {
        public Attendee(Mediator mediator) : base(mediator) { }

        public void AskQuestion(string question)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} asked question.\n'{1}'", Name, question);
            _mediator.SendQuestion(question, this);
        }

        public void ReceiveImage(string url)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Image for {0} updated to '{1}'.", Name, url);
        }
    }
}
