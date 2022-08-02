using System.Collections.Generic;

namespace University.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<StudentCourse>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<StudentCourse> JoinEntities { get; set; }
  }
}