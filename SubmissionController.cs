using System;

namespace assignment3 Model common
{
    public class SubmissionController
    {
        private SACSDataAdapter dataAdapter;

        public SubmissionController(SACSDataAdapter adapter)
        {
            this.dataAdapter = adapter;
        }

        public void SubmitAssessment(User user, Assessment assessment)
        {
            dataAdapter.SaveAssessment(assessment);
            Console.WriteLine($"{user.Username} submitted assessment: {assessment.Title}");
        }

        public void SubmitFeedback(User user, Feedback feedback, Assessment assessment)
        {
            assessment.Feedbacks.Add(feedback);
            Console.WriteLine($"{user.Username} submitted feedback for assessment: {assessment.Title}");
        }
    }
}