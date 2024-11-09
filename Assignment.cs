
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace assignment3 Model common{
    public class Assignment
{

    public Assignment()
    {
    }

    public String title { get; set; };

    public String description { get; set; };

    public DataTime due date{ get; set; };

public string relavent_files { get; set; };


public void Unit;
public Assignment(string title, string description, DateTime dueDate, List<string> files, string unit)
{
    Title = title;
    Description = description;
    DueDate = dueDate;
    RelevantFiles = files;
    Unit = unit;
}

}
}