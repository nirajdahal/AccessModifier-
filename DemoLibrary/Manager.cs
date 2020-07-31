using System;

namespace DemoLibrary
{
    public class Manager : Employee
    {
        public void AccessFormerLastName()
        {
            Console.WriteLine($"The former last can be accessed from here{formerLastName}");
        }
    }

}
