using System;
using System.Collections.Generic;

namespace assignment3 Model common
{
    public class Assessment
    {
        public string Assessment_Id { get; set; }
        public string Assessment_Title { get; set; }
        public string Assessment_Type { get; set; }
        public string Assessment_Date { get; set; }
        public string Assessment_Id { get; set; }
        public string Assessment_Title { get; set; }
        public string Group_Number { get; set; }
        public string Grade { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<Turnitin> Turnitins { get; set; } = new List<Turnitin>();
        public List<Create> Creates { get; set; } = new List<Create>();
        public List<Grade> Grades { get; set; } = new List<Grade>();
        public List<Assessment> Grades { get; set; } = new List<Assessment>();

        public Assessment(string assessmentId, string assessmentTitle, string assessmentType, string grade = "Not Graded", string groupNumber, string assessmentDate)
        {
            Assessment_Id = assessmentId;
            Assessment_Title = assessmentTitle;
            Assessment_Type = assessmentType;
            Assessment_Date = assessmentDate;
            Group_Number = groupNumber;
            Grade = grade;
        }

        public void CreateAssessment(Create create)
        {
            Creates.Add(create);
            Console.WriteLine($"{Assessment_Id} created an assessment with ID: {create.CreateId}");
        }

        public void GradeAssessment(Grade grade)
        {
            Grades.Add(grade);
            Console.WriteLine($"{Assessment_Id}'s grade is: {grade.GradeValue}");
        }
        
        public void SubmitAssessment(User student)
        {
            Console.WriteLine($"{student.User_Name} submitted the assessment: {Assessment_Title}");
        }

        public void CreatePlagiarismReport()
        {
            Console.WriteLine($"Plagiarism report created for assessment: {Assessment_Title}.");
        }
    }
}