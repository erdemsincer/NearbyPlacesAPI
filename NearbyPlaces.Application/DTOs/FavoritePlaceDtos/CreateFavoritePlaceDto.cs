﻿using NearbyPlaces.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.DTOs.FavoritePlaceDtos
{
    public class CreateFavoritePlaceDto
    {
        public int UserId { get; set; }
        public int PlaceId { get; set; }
       
    }
}
