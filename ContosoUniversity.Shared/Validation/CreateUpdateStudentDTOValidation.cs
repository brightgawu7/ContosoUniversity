using ContosoUniversity.Shared.DTOs;
using FluentValidation;

namespace ContosoUniversity.Shared.Validation;

public class CreateUpdateStudentDTOValidation:AbstractValidator<CreateUpdateStudentDTO>
{
    public CreateUpdateStudentDTOValidation()
    {
		RuleFor(student => student.LastName).NotEmpty().WithMessage("Last Name is required");
		RuleFor(student => student.FirstMidName).NotEmpty().WithMessage("First Name And Or Middle Name is required");
		RuleFor(student => student.EnrollmentDate).NotEmpty().WithMessage("Enrollment Date is required");
	}
}

