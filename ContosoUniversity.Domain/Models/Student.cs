﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Domain.Models;
public class Student
{
	public int Id { get; set; }

	[Required]
	[StringLength(50)]
	[Display(Name = "Last Name")]
	public string LastName { get; set; } = string.Empty;


	[Required]
	[StringLength(50)]
	[Column("FirstName")]
	[Display(Name = "First Name")]
	public string FirstMidName { get; set; } = string.Empty;

	[DataType(DataType.Date)]
	[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
	[Display(Name = "Enrollment Date")]
	public DateTime EnrollmentDate { get; set; }


	[Display(Name = "Full Name")]
	public string FullName
	{
		get
		{
			return LastName + ", " + FirstMidName;
		}
	}

	public ICollection<Enrollment>? Enrollments { get; set; }
}
