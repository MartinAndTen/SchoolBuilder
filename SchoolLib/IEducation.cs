using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLib
{
    public interface IEducation
    {
        string Teacher { get; set; }
        string Students { get; set; }
        string Feedback { get; set;  }
    }
}
