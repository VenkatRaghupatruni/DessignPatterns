using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class Mediator
    {
        public Presenter Presenter { get; set; }

        public List<Attendee> Attendees { get; set; }

        public void UpdateImage(string url)
        {
            foreach (Attendee attendee in Attendees)
            {
                attendee.ReceiveImage(url);
            }
        }

        public void SendAnswer(string answer, Attendee attendee)
        {
            attendee.ReceiveAnswer(answer);
        }

        public void SendQuestion(string question, Attendee attendee)
        {
            Presenter.ReceiveQuestion(question, attendee);
        }

    }
}
