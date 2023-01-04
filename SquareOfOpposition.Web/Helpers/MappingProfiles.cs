using AutoMapper;
using SquareOfOpposition.Web.Models.Domain;
using SquareOfOpposition.Web.ViewModels;

namespace SquareOfOpposition.Web.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Square, SquareViewModel>();
            CreateMap<SquareViewModel, Square>();
        }
    }
}
