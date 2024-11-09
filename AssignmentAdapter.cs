
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment3 Model common{
    public class AssignmentAdapter
{

    public AssignmentAdapter()
    {
    }

    public void Assignment;

    public HashSet<void> Assignments;
    public AssignmentAdapter()
    {
    }

    public void Assignment;

    public HashSet<void> Assignments;
    public Assignment ConvertToAssignment(string title, string description, DateTime dueDate, List<string> files, string unit)
    {
        return new Assignment(title, description, dueDate, files, unit);
    }

    public List<Assignment> WrapAssignments(List<Assignment> assignments)
    {
        //encapsulation the assignment objects to return
        return assignments;
    }

}
}