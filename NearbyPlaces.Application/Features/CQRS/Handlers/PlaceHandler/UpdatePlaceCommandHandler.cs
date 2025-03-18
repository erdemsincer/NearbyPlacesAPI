using AutoMapper;
using MediatR;
using NearbyPlaces.Application.Features.CQRS.Commands.PlaceCommand;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.PlaceHandler
{
    public class UpdatePlaceCommandHandler : IRequestHandler<UpdatePlaceCommand, PlaceResponseDto>
    {
        private readonly IPlaceRepository _placeRepository;
        private readonly IMapper _mapper;

        public UpdatePlaceCommandHandler(IPlaceRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public async Task<PlaceResponseDto> Handle(UpdatePlaceCommand request, CancellationToken cancellationToken)
        {
            var place = await _placeRepository.GetByIdAsync(request.UpdatePlaceDto.Id);
            _mapper.Map(request.UpdatePlaceDto, place);
            _placeRepository.Update(place);
            await _placeRepository.SaveChangesAsync();
            return _mapper.Map<PlaceResponseDto>(place);
        }
    }
}
