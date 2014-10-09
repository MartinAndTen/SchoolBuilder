using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolLib
{
    public abstract class abstractEducation : IEducation
    {
        public abstractEducation(IEducation education)
        {

        }

        public string Teacher
        {
            get
            {
                return Teacher;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Students
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Feedback
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}