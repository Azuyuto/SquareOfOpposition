using AutoMapper;
using SquareOfOpposition.Web.Models.Domain;
using SquareOfOpposition.Web.ViewModels;

namespace SquareOfOpposition.Web.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Square
            CreateMap<Square, SquareViewModel>();
            CreateMap<SquareViewModel, Square>();

            // State
            CreateMap<State, StateViewModel>();

            CreateMap<SquareViewModel, Square>();
        }
    }
}
