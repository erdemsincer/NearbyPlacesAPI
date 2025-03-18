using MediatR;
using NearbyPlaces.Application.DTOs.PlaceDtos;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.Features.CQRS.Commands.PlaceCommand
{
    public class CreatePlaceCommand : IRequest<PlaceResponseDto>
    {
        public CreatePlaceDto CreatePlaceDto { get; set; }
    }
}
