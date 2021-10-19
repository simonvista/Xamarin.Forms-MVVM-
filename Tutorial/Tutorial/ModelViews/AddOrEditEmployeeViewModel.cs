using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class AddOrEditEmployeeViewModel
    {
        public Employee Employee { get; set; } 

        public AddOrEditEmployeeViewModel()
        {
            Employee = new Employee();
        }
    }
}
