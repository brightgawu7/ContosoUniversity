using AutoMapper;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs.Students;

namespace ContosoUniversity.API.AutoMapperProfiles;
public class StudentAutoMapperProfile : Profile
{
	public StudentAutoMapperProfile()
	{
		CreateMap<Student, StudentsDTO>().ReverseMap();
		CreateMap<Student, StudentDetailDTO>().ReverseMap();
		CreateMap<Student, CreateUpdateStudentDTO>().ReverseMap();
	}
}
