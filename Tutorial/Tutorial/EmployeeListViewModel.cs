using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class EmployeeListViewModel
    {
        //approach 2: w/o model is not good
        public string[] Employees { get; set; }

        public EmployeeListViewModel()
        {
             Employees = new string[]
             {
                 "Rob Finnerty", "Bill Wrestler","Geri-Beth Hooper","Keith Joyce-Purdy","Sheri Spruce","Burt Indybrick"
             };
        }
    }
}
