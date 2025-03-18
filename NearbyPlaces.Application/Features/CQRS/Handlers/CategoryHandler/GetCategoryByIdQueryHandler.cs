using AutoMapper;
using MediatR;
using NearbyPlaces.Application.Features.CQRS.Queries.CategoryQueries;
using NearbyPlaces.Application.Features.CQRS.Results.CategoryResult;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, CategoryResponseDto>
    {
        private readonly ICategoryRepository _placeRepository;
        private readonly IMapper _mapper;

        public GetCategoryByIdQueryHandler(ICategoryRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public async Task<CategoryResponseDto> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var place = await _placeRepository.GetByIdAsync(request.Id);
            return _mapper.Map<CategoryResponseDto>(place);
        }
    }
}
