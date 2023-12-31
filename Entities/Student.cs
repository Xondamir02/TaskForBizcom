﻿namespace ClassRoom.Entities;

public class Student
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime BirthDate { get; set; }
    public Guid StudentRegNumber { get; set; }
    public List<StudentScience>? StudentSciences { get; set; }
    public List<Grading>? Grades { get; set; }
}