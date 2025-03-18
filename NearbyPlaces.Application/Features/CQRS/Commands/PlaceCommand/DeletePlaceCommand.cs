using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.Features.CQRS.Commands.PlaceCommand
{
    public class DeletePlaceCommand : IRequest
    {
        public int Id { get; set; }
    }
}
