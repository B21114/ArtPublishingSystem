using APS.CMS.Application.Publications.Queries.GetPublicationById;
using APS.DBS.Domain.Entities;
using AutoMapper;

namespace APS.CMS.Application.Publications.Mappings
{
    /// <summary>
    /// Класс публичного экзепляра.
    /// </summary>
    public class PublicationProfile : Profile
    {
        /// <summary>
        /// Конструктор публичного экземпляра.
        /// </summary>
        public PublicationProfile()
        {
            CreateMap<Content, PublicationDetailsDto>()
                .ForMember(o => o.Id, o2 => o2.MapFrom(o3 => o3.Id))
                .ForMember(o => o.AuthorFullName, o2 => o2.MapFrom(o3 => o3.Author))
                .ForMember(o => o.Uploaddatetime, o2 => o2.MapFrom(o3 => o3.Uploaddatetime))
                .ForMember(o => o.Ispublic, o2 => o2.MapFrom(o3 => o3.Ispublic));
        }
    }
}
