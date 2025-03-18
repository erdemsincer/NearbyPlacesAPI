using MediatR;
using NearbyPlaces.Application.Features.CQRS.Commands.PlaceCommand;
using NearbyPlaces.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.PlaceHandler
{
    public class DeletePlaceCommandHandler : IRequestHandler<DeletePlaceCommand>
    {
        private readonly IPlaceRepository _placeRepository;

        public DeletePlaceCommandHandler(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        public async Task<Unit> Handle(DeletePlaceCommand request, CancellationToken cancellationToken)
        {
            var place = await _placeRepository.GetByIdAsync(request.Id);
            _placeRepository.Delete(place);
            await _placeRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
