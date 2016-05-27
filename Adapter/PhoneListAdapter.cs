using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class PhoneListAdapter : IIntranetPhoneList
    {
        private PersonnelSystem _personnel;
 
        public PhoneListAdapter(PersonnelSystem personnel)
        {
            _personnel = personnel;
        }
 
        public string GetPhoneList()
        {
            string[][] employees = _personnel.GetEmployees();
            StringBuilder phoneList = new StringBuilder();
 
            foreach (string[] employee in employees)
            {
                phoneList.Append(employee[1]);
                phoneList.Append(',');
                phoneList.Append(employee[2]);
                phoneList.Append(',');
                phoneList.Append(employee[0]);
                phoneList.Append('\n');
            }
 
            return phoneList.ToString();
    }

    }
}
