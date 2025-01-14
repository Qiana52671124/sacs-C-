
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment3 Model common{
    
    public class Instructor : User
{
    public string Instructor_Id { get; set; }
    public string Instructor_Name { get; set; }
    public string Instructor_Faculty { get; set; }
    public string Instructor_ContactInfo { get; set; }
    public string Instructor_Department { get; set; }
    public List<Manage> Manages { get; set; } = new List<Manage>(); // Initialize the list
    public List<Feedback> Feedbacks { get; set; } = new List<Feedback>(); // Initialize the list

    // Constructor
    public Instructor(string instructorId, string instructorName, string instructorFaculty, string instructorContactInfo, string instructorDepartment)
    {
        Instructor_Id = instructorId;
        Instructor_Name = instructorName;
        Instructor_Faculty = instructorFaculty;
        Instructor_ContactInfo = instructorContactInfo;
        Instructor_Department = instructorDepartment;
    }

    // Method to manage assessments
    public void ManageAssessment(Manage manage)
    {
        Manages.Add(manage);
        Console.WriteLine($"{Instructor_Id} managed an assessment with ID: {manage.ManageId}");
    }

    // Method to generate feedback
    public void GenerateFeedback(Feedback feedback)
    {
        Feedbacks.Add(feedback);
        Console.WriteLine($"{Instructor_Id}'s feedback is: {feedback.FeedbackText}");
    }

    public void ViewReport(Assessment assessment)
    {
        Console.WriteLine($"{Instructor_Name} is viewing the plagiarism report for {assessment.Assessment_Title}.");
    }

    // Method to open assessments
    public void OpenAssessment(Manage manage)
    {
        Console.WriteLine($"{Instructor_Name} opened the assessment with ID: {manage.ManageId}");
    }

    // Method to grade assessments
    public void GradeAssessment(Grade grade)
    {
        Console.WriteLine($"{Instructor_Name} graded the assessment with ID: {grade.AssessmentId} with a score of" +
            $" {grade.GradeValue}");
    }

    // Method to generate feedback
    public void GenerateFeedback(Feedback feedback)
    {
        Feedbacks.Add(feedback);
        Console.WriteLine($"{Instructor_Name}'s feedback is: {feedback.FeedbackText}");
    }
}

// Placeholder classes for Manage and Feedback
public class Manage
{
    public string ManageId { get; set; }
    public Manage(string manageId)
    {
        ManageId = manageId;
    }
}

public class Feedback
{
    public string FeedbackText { get; set; }
    public Feedback(string feedbackText)
    {
        FeedbackText = feedbackText;
    }
    }
        
    public HashSet<void> Units;
    {
    }
}
