using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Module1
{
    internal class NewEmployee
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string Department { get; set; }

        // getters and setters
        public int GetId() => Id;
        public void SetId(int id) => Id = id;
        public string GetName() => Name;
        public void SetName(string name) => Name = name;
        public string GetDepartment() => Department;
        public void SetDepartment(string department) => Department = department;

        // constructor
        public NewEmployee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }
    }

    internal class LINQ
    {

        List<NewEmployee> employees = new List<NewEmployee>();


        public void AddEmployee(NewEmployee employee)
        {
            employees.Add(employee);
        }

        public void DisplayEmployeesinIT()
        {
            var employeeQuery = employees.Where(e=>e.GetDepartment() == "IT");
            Console.WriteLine("Employees in IT Department:");
            foreach (var emp in employeeQuery)
            {
                Console.WriteLine($"ID: {emp.GetId()}, Name: {emp.GetName()}, Department: {emp.GetDepartment()}");
            }
        }
    }

}
