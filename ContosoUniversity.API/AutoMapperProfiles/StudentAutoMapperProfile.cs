using AutoMapper;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs;

namespace ContosoUniversity.API.AutoMapperProfiles;
public class StudentAutoMapperProfile : Profile
{
	public StudentAutoMapperProfile()
	{
		CreateMap<Student, StudentDTO>().ReverseMap();
		CreateMap<Student, StudentDetailDTO>().ReverseMap();
		CreateMap<Student, CreateUpdateStudentDTO>().ReverseMap();
	}
}
