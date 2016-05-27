using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    /* The mediator pattern is a Behavioural design pattern as it defines a manner for controlling communication between classes or entities.
   It promotes loose coupling of objects by removing the need for classes to communicate with each other directly. Instead, mediator objects 
   are used to encapsulate and centralise the interactions between classes.*/

    class MediatorClient
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();

            Presenter presenter = new Presenter(mediator);
            presenter.Name = "Bob";
            mediator.Presenter = presenter;

            Attendee sam = new Attendee(mediator);
            sam.Name = "Sam";
            Attendee jim = new Attendee(mediator);
            jim.Name = "Jim";
            mediator.Attendees = new List<Attendee> { sam, jim };

            presenter.SendNewImageUrl("Slide1.jpg");
            sam.AskQuestion("How often should I do this?");
            presenter.AnswerQuestion("Daily", sam);
            presenter.SendNewImageUrl("Slide2.jpg");

            Console.Read();
        }
    }
}
