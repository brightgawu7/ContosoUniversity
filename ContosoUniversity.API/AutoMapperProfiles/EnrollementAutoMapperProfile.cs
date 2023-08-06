using AutoMapper;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs;

namespace ContosoUniversity.API.AutoMapperProfiles;

public class EnrollementAutoMapperProfile : Profile
{
	public EnrollementAutoMapperProfile()
	{
		CreateMap<Enrollment, EnrollmentDTO>().ReverseMap();
	}
}

