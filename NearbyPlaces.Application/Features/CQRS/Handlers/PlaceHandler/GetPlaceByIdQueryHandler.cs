using AutoMapper;
using MediatR;
using NearbyPlaces.Application.Features.CQRS.Queries.PlaceQueries;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.PlaceHandler
{
    public class GetPlaceByIdQueryHandler : IRequestHandler<GetPlaceByIdQuery, PlaceResponseDto>
    {
        private readonly IPlaceRepository _placeRepository;
        private readonly IMapper _mapper;

        public GetPlaceByIdQueryHandler(IPlaceRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public async Task<PlaceResponseDto> Handle(GetPlaceByIdQuery request, CancellationToken cancellationToken)
        {
            var place = await _placeRepository.GetByIdAsync(request.Id);
            return _mapper.Map<PlaceResponseDto>(place);
        }
    }
}
