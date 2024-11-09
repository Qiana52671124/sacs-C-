
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System;
using System.Collections.Generic;

namespace assignment3 Model common
{
    public class User
{
    public string User_Id { get; set; }
    public string User_Name { get; set; }
    public string User_ContactInfo { get; set; }
    public string User_Department { get; set; }
    public Group Details { get; set; }

    public User(string userId, string userName, string userContactInfo, string userDepartment)
    {
        User_Id = userId;
        User_Name = userName;
        User_ContactInfo = userContactInfo;
        User_Department = userDepartment;
    }

    // Method to view an assessment
    public void ViewAssessment(Assignment assignment)
    {
        Console.WriteLine($"{User_Id} is viewing the assignment with ID: {assignment.Assignment_Id}");
    }

    // Method to submit an assessment
    public void SubmitAssessment(Assignment assignment)
    {
        Console.WriteLine($"{User_Id} submitted the assignment with ID: {assignment.Assignment_Id}");
    }

    // Method to check the grade
    public void CheckGrade(Assignment assignment)
    {
        Console.WriteLine($"{User_Id}'s grade for the assignment with ID: {assignment.Assignment_Id} is {assignment.Grade}");
    }
}
}

//namespace assignment3 Model common{
//public class User {

//public User() {
//}

//public void ID;

//public void user_name;

//public void password;

//public void email;

//}
//}