using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Person
    {
        //private string formerLastName = "";
        protected string formerLastName ="";

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        private string _ssn;

        public string SSN
        {
            get {
             return $"***-**-{_ssn.Substring(_ssn.Length - 4) }";
            }
            set {
                _ssn = value;     
            }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello {FirstName}");
        }

        public void ChangeLastName(string lastname)
        {
            formerLastName = LastName;
            LastName = lastname;
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess();
            string conn = data.GetConnectionString();
        }


    }

}
