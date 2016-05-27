using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    /* The visitor pattern is a Behavioural design pattern as it defines a manner for controlling communication between classes or entities.
     It separates a set of structured data from the functionality that may be performed upon it.
     This promotes loose coupling and enables additional operations to be added without modifying the data classes.*/
    
    public class VistorClient
    {
        static void Main(string[] args)
        {
            Manager bob = new Manager();
            bob.Name = "Bob";
            bob.MonthlySalary = 5000;

            Manager sue = new Manager();
            sue.Name = "Sue";
            sue.MonthlySalary = 4000;

            Worker jim = new Worker();
            jim.Name = "Jim";
            jim.MonthlySalary = 2000;

            Worker tom = new Worker();
            tom.Name = "Tom";
            tom.MonthlySalary = 1800;

            Worker mel = new Worker();
            mel.Name = "Mel";
            mel.MonthlySalary = 1900;

            bob.Subordinates.Add(sue);
            bob.Subordinates.Add(jim);
            sue.Subordinates.Add(tom);
            sue.Subordinates.Add(mel);

            OrganisationalStructure org = new OrganisationalStructure(bob);

            PayrollVisitor payroll = new PayrollVisitor();
            PayriseVisitor payrise = new PayriseVisitor(0.05);

            org.Accept(payroll);
            org.Accept(payrise);
            org.Accept(payroll);

            Console.WriteLine("Total pay increase = {0}.", payrise.TotalIncrease);

            Console.Read();
        }
    }
}
