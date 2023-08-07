
using AutoMapper;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs.Courses;

namespace ContosoUniversity.API.AutoMapperProfiles;
public class DepartmentAutoMapperProfile:Profile
{
    public DepartmentAutoMapperProfile()
    {
        
        CreateMap<Department, CourseDepartmentDTO>().ReverseMap();

    }

}
