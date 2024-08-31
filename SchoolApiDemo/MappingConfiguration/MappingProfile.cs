using AutoMapper;
using SchoolApiDemo.Dtos;
using SchoolApiDemo.Models;

namespace SchoolApiDemo.MappingConfiguration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>()
            .ReverseMap();

            CreateMap<Course, CourseDto>()
            .ReverseMap();
        }
    }
}
