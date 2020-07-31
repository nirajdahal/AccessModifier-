using DemoLibrary;
using System;
using System.Security.Cryptography.X509Certificates;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SavePerson();
            Console.WriteLine("Hello World!");
  
        }
    }
}