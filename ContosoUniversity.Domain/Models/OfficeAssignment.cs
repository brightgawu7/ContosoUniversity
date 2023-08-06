using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ContosoUniversity.Domain.Models;

public class OfficeAssignment
{
	[Key]
	public int InstructorId { get; set; }
	[StringLength(50)]
	[Display(Name = "Office Location")]
	public string Location { get; set; } = string.Empty;	

	public Instructor Instructor { get; set; }
}

