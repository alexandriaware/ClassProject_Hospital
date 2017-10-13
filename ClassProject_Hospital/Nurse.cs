using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject_Hospital
{
    class Nurse : Hospital_Employee
    {
        //fields
        private string department;
        private int numOfPatients;


        //Properties
        public string Department
        {
            get { return this.department; }
        }
        
        public int NumOfPatients
        {
            get { return this.numOfPatients; }
        }
        

        //Constructor
        public Nurse()
        {
            //default
        }
        public Nurse(string employeeName, int employeeNum, string department, int numOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.department = department;
            this.numOfPatients = numOfPatients;
        }

        //Method
        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write("\t" + department + "\t" + numOfPatients);
        }


    }
}
