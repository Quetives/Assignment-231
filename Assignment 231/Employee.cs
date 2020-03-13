﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_231
{
    class Employee
    {
        public string empName { get; set; }
        public int empId { get; set; }
        public Employee(string name) : this(name, 0) { }
        public Employee(string name, int Id)
        {
            empName = name;
            empId = Id;
        }
    }
}
