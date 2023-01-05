using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SquareOfOpposition.Web.Interfaces;
using SquareOfOpposition.Web.Models.Domain;
using SquareOfOpposition.Web.Repository;
using SquareOfOpposition.Web.ViewModels;

namespace SquareOfOpposition.Web.Controllers
{
    public class AjaxController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISquareRepository _squareRepository;
        private readonly IStateTransitionRepository _stateTransitionRepository;
        private readonly IStateRepository _stateRepository;

        public AjaxController(IMapper mapper, ISquareRepository squareRepository, IStateTransitionRepository stateTransitionRepository,
            IStateRepository stateRepository)
        {
            _mapper = mapper;
            _squareRepository = squareRepository;
            _stateTransitionRepository = stateTransitionRepository;
            _stateRepository = stateRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SquareTable()
        {
            var squareList = _squareRepository.GetAll().Select(s => _mapper.Map<SquareViewModel>(s)).ToList();
            return PartialView(squareList);
        }

        public void AddTransition(int pickupStateId, int destinationStateId)
        {
            _stateTransitionRepository.Add(new StateTransition()
            {
                PickupState = _stateRepository.GetMany(a => a.Id == pickupStateId).First(),
                PickupStateId = pickupStateId,
                DestinationState = _stateRepository.GetMany(a => a.Id == destinationStateId).First(),
                DestinationStateId = destinationStateId
            });
            _stateTransitionRepository.SaveChanges();
        }

        public void RemoveTransition(int pickupStateId, int destinationStateId)
        {
            var tranition = _stateTransitionRepository.GetMany(a => a.PickupStateId == pickupStateId && a.DestinationStateId == destinationStateId).First();
            _stateTransitionRepository.Remove(tranition);
            _stateTransitionRepository.SaveChanges();
        }

        public void RenameTransition(int pickupStateId, int destinationStateId, string newName)
        {
            var tranition = _stateTransitionRepository.GetMany(a => a.PickupStateId == pickupStateId && a.DestinationStateId == destinationStateId).First();
            tranition.Name = newName;
            _stateTransitionRepository.SaveChanges();
        }
    }
}
