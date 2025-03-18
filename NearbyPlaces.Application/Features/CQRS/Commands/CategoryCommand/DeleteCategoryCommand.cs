﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.Features.CQRS.Commands.CategoryCommand
{
    public class DeleteCategoryCommand:IRequest
    {
        public int Id { get; set; }
    }
}
