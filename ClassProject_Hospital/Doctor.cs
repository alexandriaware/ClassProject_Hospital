using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject_Hospital
{
    class Doctor : Hospital_Employee
    {
        //fields
        protected string specialty;

        //Properties
        public string Specialty
        {
            get { return this.specialty; }
            
        }

        //Constructor
        public Doctor()
        {
            //default
        }
        public Doctor(string employeeName, int employeeNum, string specialty)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.specialty = specialty; 
        }

        //Methods
        public override string GetInfo()
        {
            
            return base.GetInfo() + "\t" + specialty;
        }




    }
}
