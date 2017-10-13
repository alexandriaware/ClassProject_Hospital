using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject_Hospital
{
    class Hospital_Employee
    {
        //fields
        protected string employeeName;
        protected int employeeNum;

        //Properties
        public string EmployeeName
        {
            get { return this.employeeName; }
        }

        public int EmployeeNum
        {
            get { return this.employeeNum; }
        }

        //Constructors
        public Hospital_Employee()
        {
            //default
        }

        public Hospital_Employee(string employeeName, int employeeNum)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
        }

        //Method
        public virtual void GetInfo()
        {
            Console.WriteLine("Employee name: " + employeeName + " " + employeeNum);
        }
        

    }
}
