using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opps_Concepts
{
    public class EmployeeIndexer
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }

    public class IndexBase
    {
        //Create a varibale to hold a list of EmployeeIndexers
        public List<EmployeeIndexer> listEmployeeIndexers;

        protected string this[int employeeId, string name]
        //private string this[int employeeId, string name]
        {
            get
            {
                return listEmployeeIndexers.FirstOrDefault(x => x.EmployeeId == employeeId).Name;
            }
            set
            {
                listEmployeeIndexers.FirstOrDefault(x => x.EmployeeId == employeeId).Name = value;
            }
        }

        public (string, int) this[int employeeId]
        //private string this[int employeeId, string name]
        {
            get
            {
                return (" ", 1);
            }
        }
    }

    public class Indexers : IndexBase
    {

        //Through the constructor initialize the listEmployeeIndexers variable
        public Indexers()
        {
            listEmployeeIndexers = new List<EmployeeIndexer>();
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 101, Name = "Pranaya", Gender = "Male", Salary = 1000 });
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 102, Name = "Preety", Gender = "Female", Salary = 2000 });
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 103, Name = "Anurag", Gender = "Male", Salary = 5000 });
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 104, Name = "Priyanka", Gender = "Female", Salary = 4000 });
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 105, Name = "Hina", Gender = "Female", Salary = 3000 });
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 106, Name = "Sambit", Gender = "Male", Salary = 6000 });
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 107, Name = "Tarun", Gender = "Male", Salary = 8000 });
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 108, Name = "Santosh", Gender = "Male", Salary = 7000 });
            listEmployeeIndexers.Add(new EmployeeIndexer
            { EmployeeId = 109, Name = "Trupti", Gender = "Female", Salary = 5000 });
        }

        // The indexer takes an employeeId as parameter
        // and returns the employee name
        public string this[int employeeId]
        //private string this[int employeeId]
        {
            get
            {
                return this[employeeId, ""];
            }
            set
            {
                this[employeeId, ""] = value;
            }
        }

        public string this[string gender]
        {
            get
            {
                // Returns the total count of employees whose gender matches
                // with the gender that is passed in.
                return listEmployeeIndexers.Count(x => x.Gender.ToLower() == gender.ToLower()).ToString();
            }
            set
            {
                // Changes the gender of all employees whose gender matches
                // with the gender that is passed in.
                foreach (EmployeeIndexer employee in listEmployeeIndexers)
                {
                    if (employee.Gender == gender)
                    {
                        employee.Gender = value;
                    }
                }
            }
        }

    }
}
