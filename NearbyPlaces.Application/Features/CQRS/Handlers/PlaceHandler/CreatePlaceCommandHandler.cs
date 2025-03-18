using AutoMapper;
using MediatR;
using NearbyPlaces.Application.Features.CQRS.Commands.PlaceCommand;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using NearbyPlaces.Domain.Entities;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.PlaceHandler
{
    public class CreatePlaceCommandHandler : IRequestHandler<CreatePlaceCommand, PlaceResponseDto>
    {
        private readonly IPlaceRepository _placeRepository;
        private readonly IMapper _mapper;

        public CreatePlaceCommandHandler(IPlaceRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public async Task<PlaceResponseDto> Handle(CreatePlaceCommand request, CancellationToken cancellationToken)
        {
            var place = _mapper.Map<Place>(request.CreatePlaceDto);
            await _placeRepository.AddAsync(place);
            await _placeRepository.SaveChangesAsync();
            return _mapper.Map<PlaceResponseDto>(place);
        }
    }
}
