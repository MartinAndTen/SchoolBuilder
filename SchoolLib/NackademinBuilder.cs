using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    class NackademinBuilder : EducationBuilder
    {
        private abstractEducation educationInProgress;

        public override void AssignTeacher(IEducation education)
        {
            educationInProgress = education.EducationInProgress;
        }
        public override void InviteStudents()
        {
        }
        public override void ProcessStudentFeedBack()
        {
        }
    }
}
