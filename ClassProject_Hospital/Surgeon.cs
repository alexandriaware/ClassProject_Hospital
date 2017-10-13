using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject_Hospital
{
    class Surgeon : Doctor
    {
        //fields
        private string specialtyArea;
        private bool isOperating;

        //Properties
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
        }

        public bool IsOperating { get; set; }

        //Constructors
        public Surgeon()
        {
            //default
        }

        public Surgeon (string employeeName, int employeeNum, string specialtyArea, bool isOperating)
        {
            this.employeeName = employeeName;
            this.employeeNum = employeeNum;
            this.specialtyArea = specialtyArea;
            this.isOperating = isOperating;
        }

        //Method
        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write("\t" + specialtyArea + "\t" + isOperating);
        }
    }
}
