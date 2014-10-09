using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class JensenBuilder : EducationBuilder
        {
        private IEducation educationInProgress = new Education();

        public override void AssignTeacher()
        {
            educationInProgress.Teacher = "Lars";
        }

        public override void InviteStudents()
        {
            educationInProgress.Students = "Bosse";
        }

        public override void ProcessStudentFeedBack()
        {
            educationInProgress.Feedback = "Konstig";
        }


        public override IEducation Education
        {
            get { return educationInProgress; }
            set { Education = value; }
        }

    }
}

