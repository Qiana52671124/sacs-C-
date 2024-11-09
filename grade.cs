using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3 Model common
{
    public class Grade
    {
        public string AssessmentId { get; set; }
        public string GradeValue { get; set; }

        public Grade(string assessmentId, int gradeValue)
        {
            AssessmentId = assessmentId;
            GradeValue = gradeValue;
        }
    }

}
