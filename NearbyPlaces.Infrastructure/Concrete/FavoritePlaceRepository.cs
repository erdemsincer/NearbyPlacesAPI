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
    public class FavoritePlaceRepository : GenericRepository<FavoritePlace>, IFavoritePlaceRepository
    {
        public FavoritePlaceRepository(AppDbContext context) : base(context)
        {
        }
    }
}
