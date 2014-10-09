using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    class NackademinClient : EducationBuilder
    {
        private abstractEducation educationInProgress;

        public override string AssignTeacher()
        {
            return "Mattias";
        }
        public override string InviteStudents()
        {
            return "Martin, Martin, Hasse";
        }
        public override string ProcessStudentFeedBack()
        {
            return "Bra";
        }
    }
}
