namespace ClassRoom.Entities;

public class Grading
{
    public Student? Student { get; set; }
    public long StudentId { get; set; }
    public Science? Science { get; set; }
    public long ScienceId { get; set; }
    public int Grade { get; set; }
}