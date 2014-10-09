using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public interface IEducation
    {
         string Teacher { get; }
         string Students { get; }
         string Feedback { get; }
    }
}
