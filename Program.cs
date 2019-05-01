using System;
using System.Collections.Generic;

namespace list_employees
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<object> employees { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string companyName, DateTime dateFounded, List<object> hiredEmployees)
        {
            Name = companyName;
            CreatedOn = dateFounded;
            employees = hiredEmployees;
        }
    }

    class Employee
    {
        public string firstName { get; }
        public string lastName { get; }
        public string jobTitle { get; }
        public DateTime startDate { get; }


        public Employee(string first, string last, string title, DateTime start)
        {
            firstName = first;
            lastName = last;
            jobTitle = title;
            startDate = start;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee redfield = new Employee("Chris", "Redfield", "Team Lead", DateTime.Now);
            Employee valentine = new Employee("Jill", "Valentine", "Master of Unlocking", DateTime.Now);
            Employee burton = new Employee("Barry", "Burton", "Advisor", DateTime.Now);

            List<object> incomingEmployees = new List<object>();
            incomingEmployees.Add(redfield);
            incomingEmployees.Add(valentine);
            incomingEmployees.Add(burton);

            // Create an instance of a company. Name it whatever you like.
            Company umbrella = new Company("Umbrella Corporation", DateTime.Now, incomingEmployees);
            // Create three employees


            // Assign the employees to the company
            foreach(Employee employee in umbrella.employees){
                Console.WriteLine($"{employee.firstName} {employee.lastName} works for {umbrella.Name} as {employee.jobTitle} since {employee.startDate}");
            }
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
