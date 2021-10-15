using APS.CMS.Application.Publications.Queries.GetPublicationById;
using APS.CMS.Application.Publications.Queries.GetPublicationList;
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
                .ForMember(dto => dto.Id, o2 => o2.MapFrom(o3 => o3.Id))
                .ForMember(dto => dto.Name, o2 => o2.MapFrom(o3 => o3.Name))
                .ForMember(
                    destinationMember: dto => dto.AuthorFullName, 
                    memberOptions: o2 => o2.MapFrom(o3 => string.Join(
                        " ", 
                        o3.Author.Lastname, 
                        o3.Author.Firstname, 
                        o3.Author.Patronymic)))
                .ForMember(dto => dto.UploadDateTime, o2 => o2.MapFrom(o3 => o3.UploadDateTime))
                .ForMember(dto => dto.IsPublic, o2 => o2.MapFrom(o3 => o3.IsPublic));

            CreateMap<Content, PublicationListItemDto>()
                .ForMember(dto => dto.Id, o2 => o2.MapFrom(o3 => o3.Id))
                .ForMember(dto => dto.Name, o2 => o2.MapFrom(o3 => o3.Name))
                .ForMember(destinationMember: dto => dto.AuthorFullName,
                memberOptions: o2 =>o2.MapFrom(o3 => string.Join(
                    " ", 
                    o3.Author.Lastname,
                    o3.Author.Firstname,
                    o3.Author.Patronymic)))
                .ForMember(dto => dto.UploadDateTime, o2 => o2.MapFrom(o3 => o3.UploadDateTime))
                .ForMember(dto => dto.IsPublic, o2 => o2.MapFrom(o3 => o3.IsPublic));
        }
    }
}
