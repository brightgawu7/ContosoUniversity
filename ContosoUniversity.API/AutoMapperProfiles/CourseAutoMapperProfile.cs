using AutoMapper;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs;

namespace ContosoUniversity.API.AutoMapperProfiles;
public class CourseAutoMapperProfile:Profile
{
    public CourseAutoMapperProfile()
    {
        CreateMap<Course, CourseDTO>().ReverseMap();
    }
}
