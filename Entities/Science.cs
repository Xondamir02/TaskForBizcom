namespace ClassRoom.Entities;

public class Science
{
    public long Id { get; set; }
    public string Name { get; set; }
    public Teacher? Teacher { get; set; }
    public long TeacherId { get; set; }
    public List<StudentScience>? StudentSciences { get; set; }
    public List<Grading>? Grades { get; set; }
}