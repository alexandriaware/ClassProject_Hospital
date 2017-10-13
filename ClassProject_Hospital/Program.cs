using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor doctor1 = new Doctor("Doctor Ethan Harbor", 8770, "Cardiology"); // <--cute young doctor who works on old ppl

            Nurse nurse1 = new Nurse("Nurse Elain Walter", 4794, "NICU", 5); // <-- creepy older nurse who thinks he's cute

            Receptionist receptionist1 = new Receptionist("Evelyn 'Evie' Dane", 4415, "Surgery", false); // <-- thinks Nurse is creepy

            Surgeon surgeon1 = new Surgeon("Doctor Sturgis Ricard", 2418, "Neurosurgery", true);

            Console.WriteLine(surgeon1);
        }
    }
}
