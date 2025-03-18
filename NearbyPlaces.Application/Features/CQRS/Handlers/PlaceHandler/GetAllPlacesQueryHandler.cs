using AutoMapper;
using MediatR;
using NearbyPlaces.Application.Features.CQRS.Queries.PlaceQueries;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.PlaceHandler
{
    public class GetAllPlacesQueryHandler : IRequestHandler<GetAllPlacesQuery, List<PlaceResponseDto>>
    {
        private readonly IPlaceRepository _placeRepository;
        private readonly IMapper _mapper;

        public GetAllPlacesQueryHandler(IPlaceRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public async Task<List<PlaceResponseDto>> Handle(GetAllPlacesQuery request, CancellationToken cancellationToken)
        {
            var places = await _placeRepository.GetAllAsync();
            return _mapper.Map<List<PlaceResponseDto>>(places);
        }
    }
}
