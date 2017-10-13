using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject_Hospital
{
    class Receptionist : Hospital_Employee
    {
        //fields
        private string department;
        private bool onPhone;

        //Properties   <---properties are PUBLIC, Ali.
        public string Department
        {
            get { return this.department; }
        }

        public bool OnPhone { get; set; }
        

        //Constructors 
        public Receptionist()
        {
            //default
        }

        public Receptionist(string employeeName, int employeeNum, string department, bool onPhone)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.department = department;
            this.onPhone = onPhone;
        }

        //Method
        public override string GetInfo()
        {
            return employeeName + "\t" + employeeNum + "\t" + department + "\t" + onPhone;
        }



    }
}
