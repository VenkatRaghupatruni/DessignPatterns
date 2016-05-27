using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class Intranet
    {
        private IIntranetPhoneList _phoneListSource;

        public Intranet(IIntranetPhoneList phoneListSource)
        {
            _phoneListSource = phoneListSource;
        }

        public void ShowPhoneList()
        {
            string phoneNumbers = _phoneListSource.GetPhoneList();

            Console.WriteLine(phoneNumbers);
        }

    }
}
