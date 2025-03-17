using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearbyPlaces.Domain.Entities
{
    public class ReviewReply
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public string ReplyText { get; set; }
        public DateTime CreatedAt { get; set; }
        public Review Review { get; set; }
    }
}
