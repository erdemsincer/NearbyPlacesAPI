using MediatR;
using NearbyPlaces.Application.Features.CQRS.Commands.CategoryCommand;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Application.Features.CQRS.Handlers.CategoryHandler
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly ICategoryRepository _placeRepository;

        public DeleteCategoryCommandHandler(ICategoryRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var place = await _placeRepository.GetByIdAsync(request.Id);
            _placeRepository.Delete(place);
            await _placeRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
