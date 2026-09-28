using System;

namespace _04_Tutorial
{
    internal class College
    {
        public string name;
        public string uni_name;
        public string department;

        public College(string name, string uni_name, string department)
        {
            this.name = name;
            this.uni_name = uni_name;
            this.department = department;
        }

        public void DisplayName()
        {
            Console.WriteLine("Name of the college: " + name);
        }

        public void DisplayUniName()
        {
            Console.WriteLine("University Name: " + uni_name);
        }

        public void DisplayDepartment()
        {
            Console.WriteLine("Department Name: " + department);
        }

        public void Display()
        {
            DisplayName();
            DisplayUniName();
            DisplayDepartment();
        }
    }

    class SOE : College
    {
        private string Event_name;
        protected double Cost_of_Event;
        public string coordinator_name;

        public SOE(string name, string uni_name, string department,
                   string Event_name, double Cost_of_Event, string coordinator_name)
            : base(name, uni_name, department)
        {
            this.Event_name = Event_name;
            this.Cost_of_Event = Cost_of_Event;
            this.coordinator_name = coordinator_name;
        }

        public void DisplayEventName()
        {
            Console.WriteLine("Event Name: " + Event_name);
        }

        public void DisplayCostEvent()
        {
            Console.WriteLine("Cost of event: " + Cost_of_Event);
        }

        public void DisplayCordName()
        {
            Console.WriteLine("Coordinator Name: " + coordinator_name);
        }

        public static void Program_3()
        {
            SOE s1 = new SOE(
                "Global",
                "RKU",
                "Computer Science",
                "Techno_Planet",
                1000,
                "Raviraj"
            );

            SOE s2 = new SOE(
                "Engineering",
                "RKU",
                "Information Technology",
                "Tech_Fest",
                1500,
                "Aaryan"
            );

            s1.Display();
            s1.DisplayEventName();
            s1.DisplayCostEvent();
            s1.DisplayCordName();

            Console.WriteLine("----------------------");

            s2.Display();
            s2.DisplayEventName();
            s2.DisplayCostEvent();
            s2.DisplayCordName();

            Console.WriteLine("\n");
            Console.WriteLine("Name: Bharvadiya Aaryan V");
            Console.WriteLine("Enrollment No: 25SOEIT13013");
        }
    }
}