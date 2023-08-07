using AutoMapper;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs.Students;

namespace ContosoUniversity.API.AutoMapperProfiles;

public class EnrollementAutoMapperProfile : Profile
{
	public EnrollementAutoMapperProfile()
	{
		CreateMap<Enrollment, StudentEnrollmentDTO>().ReverseMap();
	}
}

