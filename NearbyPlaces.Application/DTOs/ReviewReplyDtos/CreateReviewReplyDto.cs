using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Application.DTOs.ReviewReplyDtos
{
    public class CreateReviewReplyDto
    {
        public string ReplyText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
