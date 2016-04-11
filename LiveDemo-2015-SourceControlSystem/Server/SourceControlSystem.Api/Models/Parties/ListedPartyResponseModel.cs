namespace GoParty.Api.Models.Partys
{
    using Infrastructure.Mapping;
    using GoParty.Models;
    using System;
    using AutoMapper;

    public class ListedPartyResponseModel : IMapFrom<Party>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Duration { get; set; }

        public string Title { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, ListedPartyResponseModel>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName));
        }
    }
}
