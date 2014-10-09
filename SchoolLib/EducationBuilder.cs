using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public abstract class EducationBuilder
    {
        public abstract IEducation Education { get; }

        public virtual void AssignTeacher()
        {
        }

        public virtual void InviteStudents()
        {
        }

        public virtual void ProcessStudentFeedBack()
        {
        }
    }
}
