using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsService.Api
{
    internal class FavoritePet
    {
        public int id { get; set; }
        public string user_id { get; set; }
        public string image_id { get; set; }
        public string sub_id { get; set; }
        public DateTime created_at { get; set; }
        public ImageInfo? image { get; set; }
    }
    public class ImageInfo
    {
        public string? url { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
    }
}
