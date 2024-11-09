using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment3 Model common
{
	public class SACSDataAdapter
	{
		private List<Assessment> assessments = new List<Assessment>();
		private List<Submission> submissions = new List<Submission>();


		public List<Assessment> GetAllAssessments()
		{
			return assessments;
		}


		public List<Assessment> SearchBy(string searchTerm)
		{
			return assessments


		}
		public void OpenAssessment(int assessmentId)
		{

		}

		public void SaveAssessment(Assessment assessment)
		{

		}

		public void UpdateStatus(int assessmentId, string newStatus)
		{

		}

		public void AddNewSubmission(Submission submission)
		{

		}

		public void RemoveSubmission(int submissionId)
		{

		}
	}
}