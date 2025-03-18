using Microsoft.Extensions.DependencyInjection;
using NearbyPlaces.Infrastructure.Concrete;
using NearbyPlaces.Infrastructure.Repositories;

namespace NearbyPlaces.Infrastructure.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // Generic repository servisi
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            // Tüm entity repository'leri burada register ediliyor:
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPlaceRepository, PlaceRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IReviewReplyRepository, ReviewReplyRepository>();
            services.AddScoped<IPhotoRepository, PhotoRepository>();
            services.AddScoped<IContactMessageRepository, ContactMessageRepository>();
            services.AddScoped<IFavoritePlaceRepository, FavoritePlaceRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<INotificationRepository, NotificationRepository>();

            return services;
        }
    }
}
