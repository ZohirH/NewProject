using Api.Data.Entity;
using AutoMapper;



    public class ServiceProfile : Profile
    {
    public ServiceProfile()
    {
        CreateMap<ArtistModel, Artist>()   
        .ForMember(dest => dest.ArtName, opt => opt.MapFrom(src => src.ArtistName));
        
    }
    }


