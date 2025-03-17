using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Domain.Entities
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Rating { get; set; }
        public string Category { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<FavoritePlace> FavoritePlaces { get; set; }
    }
}
