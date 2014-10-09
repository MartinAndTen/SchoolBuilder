using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public class NackademinDirector : EducationDirector
    {
        public override IEducation Build(EducationBuilder builder)
        {
            builder.AssignTeacher();
            builder.InviteStudents();
            builder.ProcessStudentFeedBack();
            return builder.Education;
        }
    }
}
