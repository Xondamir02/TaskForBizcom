﻿namespace ClassRoom.Entities;

public class StudentScience
{
    public Student? Student { get; set; }
    public long StudentId { get; set; }
    public Science? Science { get; set; }
    public long ScienceId { get; set; }
}