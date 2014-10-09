using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class NackademinBuilder : EducationBuilder
    {
        private IEducation educationInProgress = new Education();

        //public NackademinBuilder(IEducation education)
        //{
        //    educationInProgress = education;
        //}

        public override void AssignTeacher()
        {
            educationInProgress.Teacher = "Mattias";
        }

        public override void InviteStudents()
        {
            educationInProgress.Students = "Martin, Hans, Martin";
        }

        public override void ProcessStudentFeedBack()
        {
            educationInProgress.Feedback = "Bra";
        }

        public override IEducation Education
        {
            get { return educationInProgress; }
            set { Education = value; }
        }
    }
}
