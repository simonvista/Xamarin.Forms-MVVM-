using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    public class EnrollStudentViewModel
    {
        //same properties as corresponding UI, EnrollStudentPage.xaml
        //we need to create properties as entName, entEmail, swFS
        public string FullName { get; set; }
        public string Email { get; set; }
        public bool IsForeign { get; set; }
    }
}
