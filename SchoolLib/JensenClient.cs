using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    class JensenClient : EducationBuilder
    {
        public override string AssignTeacher()
        {
            return "Konstig lärare";
        }
        public override string InviteStudents()
        {
            return "Bara Bosse";
        }
        public override string ProcessStudentFeedBack()
        {
            return "Fett oflyt";
        }
    }
}
