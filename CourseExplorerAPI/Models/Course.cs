using System;
using System.Collections.Generic;

namespace CourseExplorerAPI.Models;

public partial class Course
{
    public int Id { get; set; }

    public string? Geoutcomes { get; set; }

    public string? Cat { get; set; }

    public string? CatDes { get; set; }

    public string? CourseNumber { get; set; }

    public short? Credits { get; set; }

    public string? CourseName { get; set; }

    public string? Equivalent { get; set; }

    public string? Prereqs { get; set; }

    public string? Note { get; set; }

    public string? Description { get; set; }
}
