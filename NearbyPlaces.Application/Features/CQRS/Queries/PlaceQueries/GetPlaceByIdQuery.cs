using MediatR;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.Features.CQRS.Queries.PlaceQueries
{
    public class GetPlaceByIdQuery : IRequest<PlaceResponseDto>
    {
        public int Id { get; set; }
    }
}
