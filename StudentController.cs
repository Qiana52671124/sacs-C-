
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment3 Model common{
    public class StudentController
{
    private CollaborationTools collaborationTools;
    private AssignmentController assignmentController;
    public string Profile { get; set; }
    public List<string> Groups { get; set; }
    public StudentController()
    {
        collaborationTools = new CollaborationTools();
        Groups = new List<string>();
        Profile = "Default Profile";
    }

    public void invite_memebers_in_group()
    {
        Console.WriteLine($"{memberName} invited to join group '{groupName}'.");
    }

    public void create_group()
    {
        Groups.Add(groupName);
        Console.WriteLine($"Group '{groupName}' created successfully.");
    }

    public void entry_group()
    {
        if (Groups.Contains(groupName))
        {
            Console.WriteLine($"Successfully joined group '{groupName}'.");
        }
        else
        {
            Console.WriteLine($"Group '{groupName}' does not exist.");
        }
    }

    public void view_group()
    {
        Console.WriteLine("Groups:");
        foreach (var group in Groups)
        {
            Console.WriteLine($"- {group}");
        }
    }

    public void update_profile()
    {
        Console.WriteLine($"Profile updated to: {user}");
    }

    public void trace_assignment_deadlines()
    {
        Console.WriteLine("Assignment Deadlines:");
        assignmentController.trace_assignment_deadlines()
    }

    public void upload_assignment()
    {
        Console.WriteLine($"Assignment '{fileName}' uploaded successfully.");

    }

    public void sumit_assignment()
    {
        Console.WriteLine($"Assignment '{fileName}' submitted for review.");
    }

}
}