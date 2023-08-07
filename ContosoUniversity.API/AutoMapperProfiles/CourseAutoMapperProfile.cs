using AutoMapper;
using ContosoUniversity.Domain.Models;
using ContosoUniversity.Shared.DTOs.Courses;
using ContosoUniversity.Shared.DTOs.Students;

namespace ContosoUniversity.API.AutoMapperProfiles;
public class CourseAutoMapperProfile:Profile
{
    public CourseAutoMapperProfile()
    {
        CreateMap<Course, StudentCourseDTO>().ReverseMap();
        CreateMap<Course, CourseDTO>().ReverseMap();
    }
}
