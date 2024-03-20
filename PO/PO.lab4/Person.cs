﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        public DateTime DateOfBirth { get; set; }  
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;   
            DateOfBirth = dateOfBirth;  
        }
        public override string ToString()
        {
            Console.WriteLine($"{FirstName} {LastName} {DateOfBirth}");
            return "";
        }
    }
}
