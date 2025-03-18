using AutoMapper;
using MediatR;
using NearbyPlaces.Application.Features.CQRS.Commands.CategoryCommand;
using NearbyPlaces.Application.Features.CQRS.Results.CategoryResult;
using NearbyPlaces.Domain.Entities;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CategoryResponseDto>
    {
        private readonly ICategoryRepository _placeRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public async Task<CategoryResponseDto> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var place = _mapper.Map<Category>(request.CreateCategoryDto);
            await _placeRepository.AddAsync(place);
            await _placeRepository.SaveChangesAsync();
            return _mapper.Map<CategoryResponseDto>(place);
        }
    }
}
