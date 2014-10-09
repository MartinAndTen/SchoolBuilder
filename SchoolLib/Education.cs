using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class Education : IEducation
    {
        public string Teacher
        {
            get;
            set;
        }

        public string Students
        {
            get;
            set;
        }

        public string Feedback
        {
            get;
            set;
        }
    }
}
