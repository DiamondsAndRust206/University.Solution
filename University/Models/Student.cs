using System.Collections.Generic;

namespace University.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<StudentCourse>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public string DateEnrolled { get; set; }

    public virtual ICollection<StudentCourse> JoinEntities { get;}
  }
}