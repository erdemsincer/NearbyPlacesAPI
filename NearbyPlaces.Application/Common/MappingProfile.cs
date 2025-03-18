using AutoMapper;
using NearbyPlaces.Application.DTOs.CategoryDtos;
using NearbyPlaces.Application.DTOs.PlaceDtos;
using NearbyPlaces.Application.DTOs.UserDtos;
using NearbyPlaces.Application.DTOs.ReviewDtos;
using NearbyPlaces.Application.DTOs.PhotoDtos;
using NearbyPlaces.Application.DTOs.ContactMessageDtos;
using NearbyPlaces.Application.DTOs.FavoritePlaceDtos;
using NearbyPlaces.Application.DTOs.RoleDtos;
using NearbyPlaces.Application.DTOs.UserRoleDtos;
using NearbyPlaces.Application.DTOs.NotificationDtos;
using NearbyPlaces.Application.DTOs.ReviewReplyDtos;
using NearbyPlaces.Domain.Entities;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using NearbyPlaces.Application.Features.CQRS.Results.CategoryResult;

namespace NearbyPlaces.Application.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Category
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryResponseDto>().ReverseMap();

            // Place
            CreateMap<Place, CreatePlaceDto>().ReverseMap();
            CreateMap<Place, UpdatePlaceDto>().ReverseMap();
            CreateMap<Place, ResultPlaceDto>().ReverseMap();
            CreateMap<Place, PlaceResponseDto>().ReverseMap();


            // User
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
            CreateMap<User, ResultUserDto>().ReverseMap();

            // Review
            CreateMap<Review, CreateReviewDto>().ReverseMap();
            CreateMap<Review, UpdateReviewDto>().ReverseMap();
            CreateMap<Review, ResultReviewDto>().ReverseMap();

            // ReviewReply
            CreateMap<ReviewReply, CreateReviewReplyDto>().ReverseMap();
            CreateMap<ReviewReply, UpdateReviewReplyDto>().ReverseMap();
            CreateMap<ReviewReply, ResultReviewReplyDto>().ReverseMap();

            // Photo
            CreateMap<Photo, CreatePhotoDto>().ReverseMap();
            CreateMap<Photo, UpdatePhotoDto>().ReverseMap();
            CreateMap<Photo, ResultPhotoDto>().ReverseMap();

            // ContactMessage
            CreateMap<ContactMessage, CreateContactMessageDto>().ReverseMap();
            CreateMap<ContactMessage, ResultContactMessageDto>().ReverseMap();

            // FavoritePlace
            CreateMap<FavoritePlace, CreateFavoritePlaceDto>().ReverseMap();
            CreateMap<FavoritePlace, ResultFavoritePlaceDto>().ReverseMap();

            // Role
            CreateMap<Role, CreateRoleDto>().ReverseMap();
            CreateMap<Role, UpdateRoleDto>().ReverseMap();
            CreateMap<Role, ResultRoleDto>().ReverseMap();

            // UserRole
            CreateMap<UserRole, CreateUserRoleDto>().ReverseMap();
            CreateMap<UserRole, ResultUserRoleDto>().ReverseMap();

            // Notification
            CreateMap<Notification, CreateNotificationDto>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDto>().ReverseMap();
            CreateMap<Notification, ResultNotificationDto>().ReverseMap();
        }
    }
}
