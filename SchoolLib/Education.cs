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
            get
            {
                return Teacher;
            }
            set
            {
                Teacher = value;
            }
        }

        public string Students
        {
            get
            {
                return Students;
            }
            set
            {
                Teacher = value;
            }
        }

        public string Feedback
        {
            get
            {
                return Feedback;
            }
            set
            {
                Feedback = value;
            }
        }
    }
}
