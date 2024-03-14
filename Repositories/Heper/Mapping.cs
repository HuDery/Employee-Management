using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessObjects.Models;
using Repositories.DTOs;

namespace Repositories.Heper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Employee, ListEmployeeDTO>().ReverseMap();
            CreateMap<Employee, CreateEmployeeDTO>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeDTO>().ReverseMap();
        }
    }
}
