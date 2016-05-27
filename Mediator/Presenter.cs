using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class Presenter :PresentationMember
    {
        public Presenter(Mediator mediator) : base(mediator) { }

        public void SendNewImageUrl(string url)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presenter changed image URL to '{0}'.", url);
            _mediator.UpdateImage(url);
        }

        public void ReceiveQuestion(string question, Attendee attendee)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Presenter received question from {0}.\n'{1}'"
                , attendee.Name, question);
        }

        public void AnswerQuestion(string answer, Attendee attendee)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Presenter answered question for {0}.\n'{1}'"
                , attendee.Name, answer);
            _mediator.SendAnswer(answer, attendee);
        }

    }
}
