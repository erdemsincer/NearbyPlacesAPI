using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Domain.Entities
{
    public class Photo
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int PlaceId { get; set; }
        public Place Place { get; set; }
    }
}
