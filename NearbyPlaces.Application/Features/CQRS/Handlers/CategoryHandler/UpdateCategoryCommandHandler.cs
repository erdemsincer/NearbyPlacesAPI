using AutoMapper;
using MediatR;
using NearbyPlaces.Application.Features.CQRS.Commands.CategoryCommand;
using NearbyPlaces.Application.Features.CQRS.Results.CategoryResult;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, CategoryResponseDto>
    {
        private readonly ICategoryRepository _placeRepository;
        private readonly IMapper _mapper;

        public UpdateCategoryCommandHandler(ICategoryRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }

        public async Task<CategoryResponseDto> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var place = await _placeRepository.GetByIdAsync(request.UpdateCategoryDto.Id);
            _mapper.Map(request.UpdateCategoryDto, place);
            _placeRepository.Update(place);
            await _placeRepository.SaveChangesAsync();
            return _mapper.Map<CategoryResponseDto>(place);
        }
    }
}
