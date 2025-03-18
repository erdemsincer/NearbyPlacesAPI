using MediatR;
using NearbyPlaces.Application.Features.CQRS.Results.CategoryResult;
using NearbyPlaces.Application.Features.CQRS.Results.PlaceResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetAllCategoryQuery : IRequest<List<CategoryResponseDto>> { }

}
