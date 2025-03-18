using MediatR;
using NearbyPlaces.Application.DTOs.CategoryDtos;
using NearbyPlaces.Application.Features.CQRS.Results.CategoryResult;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.Features.CQRS.Commands.CategoryCommand
{
    public class CreateCategoryCommand : IRequest<CategoryResponseDto>
    {
        public CreateCategoryDto CreateCategoryDto { get; set; }
    }
}
