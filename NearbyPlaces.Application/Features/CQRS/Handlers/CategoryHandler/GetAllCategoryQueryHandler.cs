using AutoMapper;
using MediatR;
using NearbyPlaces.Application.Features.CQRS.Queries.CategoryQueries;
using NearbyPlaces.Application.Features.CQRS.Results.CategoryResult;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class GetAllCategorysQueryHandler : IRequestHandler<GetAllCategoryQuery, List<CategoryResponseDto>>
    {
        private readonly ICategoryRepository _placeRepository;
        private readonly IMapper _mapper;

        public GetAllCategorysQueryHandler(ICategoryRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryResponseDto>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var places = await _placeRepository.GetAllAsync();
            return _mapper.Map<List<CategoryResponseDto>>(places);
        }
    }
}
