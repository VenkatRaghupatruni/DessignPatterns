using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class PersonnelSystem
    {
        public string[][] GetEmployees()
        {
            string[][] employees = new string[4][];

            employees[0] = new string[] { "1201", "Jim", "Team Leader" };
            employees[1] = new string[] { "1202", "Bob", "Developer" };
            employees[2] = new string[] { "1203", "Sue", "Developer" };
            employees[3] = new string[] { "1204", "Dan", "Tester" };

            return employees;
        }

    }
}
