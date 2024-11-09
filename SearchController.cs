using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment3 Model common
{
    public class SearchController
    {
        private SACSDataAdapter dataAdapter;

        public SearchController(SACSDataAdapter adapter)
        {
            this.dataAdapter = adapter;
        }

        public List<Assessment> SearchAssessmentByGroupNum(string name)
        {
            var assessments = dataAdapter.GetAllAssessments();
            var results = assessments.Where(a => a.Title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            return results;
        }

        public List<Assessment> SearchAssessmentByCourse(string course)
        {
            var assessments = dataAdapter.GetAllAssessments();
            var results = assessments.Where(a => a.Course == course).ToList();
            return results;
        }
    }
}