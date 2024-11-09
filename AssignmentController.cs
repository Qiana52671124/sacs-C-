
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment3 Model common{
    public class AssignmentController
{

    private AssignmentDao dao;
    private AssignmentAdapter adapter;
    public AssignmentController()
    {
        dao = new AssignmentDao();
        adapter = new AssignmentAdapter();
    }

    public HashSet<void> assignments;

    public HashSet<void> unit;

    public void student;

    public void create_ assignment()
    {
        // create a assignment
        Assignment newAssignment = adapter.ConvertToAssignment(title, description, dueDate, files, unit);
        dao.SaveAssignment(newAssignment);
    }

    public void view_assignment()
    {
        List<Assignment> assignments = GetAssignments();
        Console.WriteLine("\nAssignments:");
        foreach (var assignment in assignments)
        {
            Console.WriteLine($"Title: {assignment.Title}, Due: {assignment.DueDate}, Unit: {assignment.Unit}");
        }
    }

    public void save_assignment()
    {
        Assignment newAssignment = adapter.ConvertToAssignment(title, description, dueDate, files, unit);
        dao.SaveAssignment(newAssignment);
    }

    public void publish_assignment()
    {
        // TODO implement here
    }

    public void distribute_assignment()
    {
        // TODO implement here
    }

    public void trace_assignment_deadlines()
    {
        List<Assignment> assignments = GetAssignments();
        Console.WriteLine("\nAssignments:");
        foreach (var assignment in assignments)
        {
            Console.WriteLine($"Title: {assignment.Title}, Due: {assignment.DueDate}, Unit: {assignment.Unit}");
        }
    }

    public void trace_assignment_progess()
    {
        List<Assignment> assignments = dao.QueryAssignments();
        return adapter.WrapAssignments(assignments);
    }

    public void trace_task()
    {
        List<Assignment> assignments = dao.QueryAssignments();
        return adapter.WrapAssignments(assignments);
    }

    public void check_task_status()
    {
        List<Assignment> assignments = dao.QueryAssignments();
        return adapter.WrapAssignments(assignments);
    }

}
}