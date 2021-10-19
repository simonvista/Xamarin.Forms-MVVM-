﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public string PictureUrl { get; set; }

        public Employee(int id,string name,string design,string url)
        {
            EmployeeId = id;
            EmployeeName = name;
            Designation = design;
            PictureUrl = url;
        }
    }
}
