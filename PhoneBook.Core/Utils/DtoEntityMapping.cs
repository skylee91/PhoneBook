using AutoMapper;
using PhoneBook.Core.Models;
using PhoneBook.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Core.Utils
{
    public static class DtoEntityMapping
    {
        public static IMapper Mapper => _lazy.Value;

        // Lazy<T> type allows  thread safety mode for Lazy<Singleton>
        private static readonly Lazy<IMapper> _lazy = new(() =>
        {
            var config = new MapperConfiguration(cfg => {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            
            var mapper = config.CreateMapper();
            return mapper;
        });

    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ContactDto, Contact>().ReverseMap();
        }
    }
}
