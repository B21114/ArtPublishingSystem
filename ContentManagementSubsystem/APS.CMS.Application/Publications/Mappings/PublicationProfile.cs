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
            CreateMap<Content, PublicationDetailsDto>();
        }
    }
}
