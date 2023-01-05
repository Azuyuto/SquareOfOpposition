using AutoMapper;
using SquareOfOpposition.Common.Enum;
using SquareOfOpposition.Web.Models.Domain;
using SquareOfOpposition.Web.ViewModels;
using System.Collections.ObjectModel;

namespace SquareOfOpposition.Web.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            // Square
            CreateMap<Square, SquareViewModel>()
                .ForMember(dest => dest.StateAI, opt => 
                opt.MapFrom(src => src.States.Where(a => a.StateTypeId == (int)StateTypeEnum.AI).FirstOrDefault()))
                .ForMember(dest => dest.StateEO, opt =>
                opt.MapFrom(src => src.States.Where(a => a.StateTypeId == (int)StateTypeEnum.EO).FirstOrDefault()))
                .ForMember(dest => dest.StateIO, opt =>
                opt.MapFrom(src => src.States.Where(a => a.StateTypeId == (int)StateTypeEnum.IO).FirstOrDefault()))
                .ForMember(dest => dest.States, config => config.Ignore());
            CreateMap<SquareViewModel, Square>()
                .ForMember(dest => dest.States, config => config.Ignore());

            // State
            CreateMap<State, StateViewModel>()
                .ForMember(dest => dest.Square, opt =>
                opt.MapFrom(src => src.Square))
                .ForMember(dest => dest.StateType, opt =>
                opt.MapFrom(src => (StateTypeEnum)src.StateTypeId))
                .ForMember(dest => dest.StateTransition, opt =>
                opt.MapFrom(src => src.OutTransitions));
            CreateMap<StateViewModel, State>()
                .ForMember(dest => dest.StateTypeId, opt =>
                opt.MapFrom(src => (int)src.StateType));
        }
    }
}
