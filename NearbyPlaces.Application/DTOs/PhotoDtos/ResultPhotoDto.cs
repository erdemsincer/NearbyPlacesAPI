using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.DTOs.PhotoDtos
{
    public class ResultPhotoDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int PlaceId { get; set; }
    }
}
