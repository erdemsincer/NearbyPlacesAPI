using NearbyPlaces.Domain.Entities;
using NearbyPlaces.Infrastructure.Persistence;
using NearbyPlaces.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Infrastructure.Concrete
{
    public class PlaceRepository : GenericRepository<Place>, IPlaceRepository
    {
        public PlaceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
